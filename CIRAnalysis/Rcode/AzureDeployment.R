
install.packages("ff")
install.packages("mixtools")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)


#Function
gmmclassifier <- function (lt, paras) {
  dist<-c()
  for (i in 1:nrow(paras)) {
    dist[i] <- dnorm(lt, mean=paras[i,1], sd=paras[i,2]) 
  }
  
  return (which(dist==max(dist))[1])
}


CreatePlotting<- function(plot, unit) {
  
  h <- hist(plot$LifeTime,  breaks =max(plot$LifeTime)/unit, plot=F)
  
  num <- c(0,h$counts)
  
  incNum <- c(0)
  
  for (i in 2:length(num)) {
    incNum[i]= incNum[i-1]+num[i]
  }
  x<-h$breaks/unit
  rateInc <- incNum/incNum[length(incNum)]
  rateNum<-num/incNum[length(incNum)]
  
  output<- as.data.frame(cbind(x,num,rateInc,rateNum))
  
  return(output)
}


#Exec

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/VM_lifetime_suspended_with_VMs_5.txt", sep="\t", header=F,fill = TRUE )

colnames(data) <- c("DeploymentGUID","CreateTime", "DeploymentType", "DeploymentStatus","DeploymentProgressStatus", "DeploymentLastChangingOperationStarted", "DeploymentLastUpdated", "Cluster","DataCenter","Region")

AzureDeployments<-as.data.frame(data)

AzureDeployments<- AzureDeployments[-which(as.character(AzureDeployments$CreateTime) =="1/1/0001 12:00:00 AM"  | as.character(AzureDeployments$CreateTime) =="1/1/1601 12:00:00 AM"  |as.character(AzureDeployments$DeploymentLastUpdated) =="1/1/1801 12:00:00 AM" ),]

AzureDeployments$StartTime<-strptime(AzureDeployments[,"CreateTime"], "%m/%d/%Y %I:%M:%S %p")

AzureDeployments$LastTime<-strptime(AzureDeployments[,"DeploymentLastUpdated"], "%m/%d/%Y %I:%M:%S %p")

AzureDeployments$LifeTime<-as.numeric(AzureDeployments$LastTime - AzureDeployments$StartTime, units="hours")

#write.csv(AzureDeployments, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/AzureDeployments.csv", col.names=T, row.names=F, quote=F)
LongDeployments<- AzureDeployments[AzureDeployments$LifeTime>=24*365,]

write.table(Long_high[,"DeploymentGUID"], "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/DeploymentLifetime/OutTables/List_LongLT_HighDT.txt", sep="\t", col.names=F, row.names=F, quote=F)



AzureDeployments<- AzureDeployments[!is.na(AzureDeployments$LifeTime),]

AzureDeployments<-AzureDeployments[AzureDeployments$LifeTime > 0,]

AzureDeployments$LTCategory<- floor(log10(AzureDeployments$LifeTime+1))



#smallDep<-AzureDeployments[AzureDeployments$LifeTime <0,]
#table(smallDep$LifeTime)

plotAzure<- AzureDeployments[AzureDeployments$DeploymentType=="IaaS" | AzureDeployments$DeploymentType=="PaaS", ]
#unique(AzureDeployments$DeploymentType)

#IaaS <- AzureDeployments[AzureDeployments$DeploymentType=="IaaS" | AzureDeployments$DeploymentType=="Iaas", ]
#PaaS <- AzureDeployments[AzureDeployments$DeploymentType=="PaaS", ]





Iaas_plot<- hist(IaaS$LifeTime/(24*60), breaks=10000)

x = Iaas_plot$breaks
y = c(0, Iaas_plot$density)

Paas_plot<- hist(PaaS$LifeTime/(24*60), breaks=5000)

x2 = Paas_plot$breaks
y2 = c(0, Paas_plot$density)


plot(x2, y2, type="b", col="green", xlim= c(0,100))
points(x,y, type="b", col="blue")



##Density
plotAzure<-AzureDeployments

plotAzure <- plotAzure[plotAzure$DeploymentType!="Unknown",]



plotIaaS <-plotAzure[plotAzure$DeploymentType == "IaaS" | plotAzure$DeploymentType == "Iaas", ]


plotIaaS$Group=c()

plotIaaS[which(plotIaaS$LifeTime<1516.38),"Group"] = 1
plotIaaS[which(plotIaaS$LifeTime>1516.38 & plotIaaS$LifeTime<21674.17),"Group"] = 2
plotIaaS[which(plotIaaS$LifeTime>21674.17 & plotIaaS$LifeTime<121050.00),"Group"] =3
plotIaaS[which(plotIaaS$LifeTime>121050.00),"Group"] =4


plotIaaS[which(plotIaaS$LifeTime>60*24*0 & plotIaaS$LifeTime<=60*24*30),"Group"] = 1
plotIaaS[which(plotIaaS$LifeTime>60*24*30),"Group"] =2
plotIaaS$Group<-as.factor(plotIaaS$Group)

plotIaaS <-plotIaaS[plotIaaS$LifeTime <120,]

plotPaaS <-plotAzure[plotAzure$DeploymentType == "PaaS", ]

plotPaaS <-plotPaaS[plotPaaS$LifeTime <4430.00,]


plotPaaS$Group=c()

for (i in 1:length(plotPaaS$LifeTime)) {
  
  plotPaaS$Group[i] <- gmmclassifier(plotPaaS$LifeTime[i], paras)
}

plotPaaS$Group <- as.factor(plotPaaS$Group)

ggplot(plotAzure, aes(x= LifeTime,y=..density.., group=DeploymentType, fill=DeploymentType))+
  #  geom_histogram(binwidth=60*24*30, alpha=0.5, position="dodge") +
  stat_density(alpha=.2, kernel="gaussian",colour="black", size=0.5) +
  xlim(1,10000)+
  ylim(0,100)

###Deployment Plot


ggplot(plotAzure[plotAzure$Region == "US Gov Iowa" |plotAzure$Region=="US Gov Virginia", ], aes(x=Cluster,group=DeploymentType,fill=DeploymentType)) + geom_histogram(position="dodge")  +
  
#  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  theme(axis.text.x = element_text(angle = 90, hjust = 1))




###IaaS Plot

ggplot(plotIaaS[plotIaaS$Region!="US West" & plotIaaS$DataCenter != "",], aes(x=Cluster,group=Group,fill=Group)) + geom_histogram(position="stack")  +
  
  #  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  theme(axis.text.x = element_text(angle = 90, hjust = 1)) +
  geom_hline(yintercept=0.5,linetype="dotted", size=1, colour="white")+
  scale_fill_discrete(name= "Lifetime Group (days)", labels=c("<=30", ">30"))



iaasMap <- ggplot(plotIaaS, aes(x=LifeTime/(60*24), y=..count..))
iaasMap + 
  #  geom_histogram(binwidth=1, alpha=0.5, position="dodge")+
  stat_density(alpha=.2, kernel="gaussian",colour="black", size=0.5) +
  geom_vline(xintercept =23, linetype = "dotted", size = 1) +
  geom_vline(xintercept =30, linetype = "dotted", size = 1) +
  xlim(0,60)  +
  xlab("Lifetime (Days)") + 
  ylab("Density of Deployments (per Day)") 


aggr<- table(plotIaaS$Region, plotIaaS$Group)

rank <-sort( aggr[,2]/aggr[,1], decreasing = T )

rank<- sort(table(plotIaaS$Region),decreasing=T)


theTable <- within(plotIaaS,Region <- factor(Region, levels=names(rank)))

ggplot(theTable[!is.na(theTable$Region) & theTable$Region!="",], aes(x=Region,group=Group,fill=Group)) + geom_histogram(position="stack")  +
  
  #  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  theme(axis.text.x = element_text(angle = 90, hjust = 1)) +
  geom_hline(yintercept=0.5,linetype="dotted", size=1, colour="white")+
  scale_fill_discrete(name= "Lifetime Group (days)", labels=c("<=30", ">30"))




stat_bin(binwidth = 60*1, alpha=0.4)


###PaaS Plot


paasMap <- ggplot(plotPaaS, aes(x=LifeTime, y=..count.., group=DeploymentType, fill=DeploymentType))
paasMap + 
  geom_histogram(binwidth=0.5, alpha=0.5, position="identity") +
  #stat_density(alpha=.2, kernel="gaussian",colour="black", size=0.5) +
  xlim(0, 120) 

paasMap + geom_histogram(binwidth=1, alpha=0.5, position="identity") +
  xlim(60*0, 60*1) 

paasMap+ stat_density(alpha=.2, kernel="gaussian",colour="black", size=0.5) +
  #  stat_bin(binwidth = 1, alpha=0.4) +
  xlim(0, 120) +
  ylim(0, 3000) +
  geom_vline(xintercept =0.5472481, linetype = "dotted", size = 1) +
  geom_vline(xintercept =12, linetype = "dotted", size = 1) +
  geom_vline(xintercept =20.5, linetype = "dotted", size = 1) +
  geom_vline(xintercept =39.9103316, linetype = "dotted", size = 1) +
  geom_vline(xintercept =69, linetype = "dotted", size = 1) +
  xlab("LifeTime (Minutes)")+
  ylab("Density of Deployments (per Minute)")


ggplot(plotPaaS[which(plotPaaS$Region=="US Gov Iowa" | plotPaaS$Region=="US Gov "),], aes(x=Cluster,group=Group,fill=Group)) + geom_histogram(position="fill")  +
  
#  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  theme(axis.text.x = element_text(angle = 90, hjust = 1)) +
  scale_fill_discrete(name= "Lifetime Group")

ggplot(plotPaaS[plotPaaS$Region!="",], aes(x=Region,group=Group,fill=Group)) + geom_histogram(position="dodge")  +
  
  #  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  theme(axis.text.x = element_text(angle = 90, hjust = 1)) +
  scale_fill_discrete(name= "Lifetime Group (mins)", labels=c("1.07", "12.05", "20.12", "33.29", "79.68"))



map +  stat_density(alpha=.2,  kernel = "gaussian", colour="black", size=1)



## ploty


paas <- CreatePlotting(plotPaaS,60*24)
iaas <- CreatePlotting(plotIaaS, 60*24)


par(mfrow = c(2, 1)) 
plot(log10(paas$x),  log10(paas$num), type="p", pch=16, cex=0.5, col="pink",
     xlab="Lifetime in days (Log10))", ylab="Number of Deployments (Log10)")
points(log10(iaas$x),  log10(iaas$num), type="p", pch=16,cex=0.5, col="blue")
grid()
legend("topright",legend=(c("PaaS", "IaaS")), col=c("pink", "blue"), pch=c(16,16))



plot(paas$x,  paas$rateInc, type="l", lwd=2, col="pink",
     #xlim=xl,
     ylim=c(0,1.1),
     main="Deployment Lifetime",
     xlab="Lifetime (days)", ylab="Incremental Ratio of Deployments"
)
points(paas$x,  paas$rateNum, type="l", lwd=1, lty="dashed", col="pink")
abline(v= max(paas$x), lty="dotted", lwd=2, col="pink")
points(iaas$x,  iaas$rateInc, type="l", lwd=2, col="blue")
points(iaas$x,  iaas$rateNum, type="l", lwd=1,lty="dashed", col="blue")
abline(v= max(iaas$x), lty="dotted", lwd=2, col="blue")
grid()



##Fitting

#fit<-lm(log(rateNum)~h$breaks)

#summary(fit)

##plotting

xl=c(0,24)


par(mfrow = c(2, 1)) 
plot(h$breaks/(60),  rateNum, type="h", lwd=1.5, col="pink",
     #xlim=xl,
     #ylim=c(0,20000),
     main="Distribution: VM DT Lifetime",
     xlab="Duration (hrs)", ylab="Amount of VMs"
)
points(h$breaks,  rateNum, type="l", lwd=1.5, col="blue")
grid()
plot(h$breaks/(60),  rateInc, type="l", pch=19,
     #xlim=xl,
     ylim=c(0,1),
     main="Percent of Tenants",
     xlab="Duration (hrs)", ylab="Incremental Percent of Tenants(%)"
)
grid()
dev.off()

##GMM PaaS

dur <- plotPaaS$LifeTime[plotPaaS$LifeTime<120]

gmmmodel <- normalmixEM(dur, k=5, lambda=c(0.2,0.3, 0.3, 0.1,0.1 ), mu=c(0.01,10, 20, 40,100 ),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)

gmmmodel$lambda
gmmmodel$mu
gmmmodel$sigma

paras<-cbind(gmmmodel$mu, gmmmodel$sigma)

##GMM IaaS

dur <- plotIaaS$LifeTime[plotPaaS$LifeTime<124400.00]

gmmmodel <- normalmixEM(dur, k=5, lambda=c(0.4,0.4,0.2 ), mu=c(0.01, 60*24*40, 124400),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)

gmmmodel$lambda
gmmmodel$mu/60/24
gmmmodel$sigma

paras<-cbind(gmmmodel$mu, gmmmodel$sigma)









#Write list

start <- as.POSIXct("2015-05-01")
deploymentlist<-AzureDeployments[AzureDeployments$StartTime >= start,c("DeploymentGUID", "LifeTime")]

write.table(deploymentlist, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/Deployment_list_0501.txt", sep="\t", row.names = F, col.names = F, quote = F)