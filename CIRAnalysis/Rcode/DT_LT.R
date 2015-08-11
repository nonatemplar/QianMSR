

install.packages("ff")
install.packages("mixtools")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)


dtltplot= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/DeploymentLifetime/Deployment_DT_RCAEngine_20150501_aggr.txt", sep="\t", header=F,fill = TRUE )

colnames(dtltplot) <-c("DeploymentGUID", "RCAEngineCategory", "Downtime","Lifetime")

dtltplot <- as.data.frame(dtltplot)

resplot<- merge(AzureDeployments, dtltplot, by.x="DeploymentGUID", by.y="DeploymentGUID")

Long_high<-resplot[resplot$LTCategory==3, ]

write.table(Long_high[,"DeploymentGUID"], "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/DeploymentLifetime/OutTables/List_LongLT_HighDT.txt", sep="\t", col.names=F, row.names=F, quote=F)


resplot$Group=c()

for (i in 1:length(resplot$LifeTime)) {
  
  resplot$Group[i] <- gmmclassifier(resplot$LifeTime[i], paras)
}

resplot$Group <- as.factor(resplot$Group)



resplot$freq= resplot$Downtime/ resplot$Lifetime
resplot$Group=c()
for (i in 1:length(resplot$freq)) {
  r = resplot$freq[i]
  if (r<=0.001) {
    resplot$Group[i]=1
  }else if(r>0.001 & r<=0.01){
    resplot$Group[i]=2
  }else if(r>0.01& r<=0.05) {
    resplot$Group[i]=3
  }else if(r>0.05& r<=0.125){
    resplot$Group[i]=4
  }else if(r>0.125& r<=0.5){
    resplot$Group[i]=5
  }else if(r>0.5& r<=1){
    resplot$Group[i]=6
  }else{
    resplot$Group[i]=7
  }

}

resplot$Group <- as.factor(resplot$Group)

resplot<-resplot[resplot$RCAEngineCategory=="CustomerInitiated",]

b<- boxplot(resplot[resplot$DeploymentType=="IaaS","freq"])

paas<- resplot[resplot$DeploymentType=="PaaS" & resplot$freq>=0.0000875 & resplot$freq<=0.4488778,]


dur <- paas$freq

gmmmodel <- normalmixEM(dur, k=4, lambda=c(0.2,0.3, 0.3,0.2), mu=c(0.000,0.007, 0.1,0.4 ),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)

gmmmodel$lambda
gmmmodel$mu
gmmmodel$sigma

paras<-cbind(gmmmodel$mu, gmmmodel$sigma)

paas$Group=c()

for (i in 1:length(paas$LifeTime)) {
  
  paas$Group[i] <- gmmclassifier(paas$freq[i], paras)
}

paas$Group <- as.factor(paas$Group)


paas$Group=c()
for (i in 1:length(paas$freq)) {
  r = paas$freq[i]
  if (r<=0.01) {
    paas$Group[i]=1
  }else if(r>0.01 & r<=0.07){
    paas$Group[i]=2
  }else if(r>0.07& r<=0.13) {
     paas$Group[i]=3
  }else if(r>0.13& r<=0.25){
    paas$Group[i]=4
  }else if(r>0.25& r<=0.32){
    paas$Group[i]=5
#  }else if(r>0.32& r<=0.38){
#    paas$Group[i]=6
#  }else if(r>0.38& r<=0.42){
#    paas$Group[i]=7
  }else{
    paas$Group[i]=6
  }
  
}
paas$Group <- as.factor(paas$Group)


ggplot(data=paas, aes(x= Lifetime, y=Downtime, colour=Group)) +
  
  geom_point( size=2) 

ggplot(data=paas, aes(x=Group , y=Lifetime, group=Group , fill=Group)) + geom_boxplot() +ylim(0,1000)


#IaaS

dur <- iaas$freq

gmmmodel <- normalmixEM(dur, k=4, lambda=c(0.4,0.3, 0.2,0.1), mu=c(0.000,0.05, 0.1,0.15 ),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)

gmmmodel$lambda
gmmmodel$mu
gmmmodel$sigma

paras<-cbind(gmmmodel$mu, gmmmodel$sigma)

iaas$Group=c()

for (i in 1:length(iaas$LifeTime)) {
  
  iaas$Group[i] <- gmmclassifier(iaas$freq[i], paras)
}

iaas$Group <- as.factor(iaas$Group)

ggplot(data=iaas, aes(x= Lifetime, y=Downtime, colour=Group)) +
  
  geom_point( size=2) 

ggplot(data=iaas[iaas$Group==3,], aes(x= Lifetime, y=Downtime, colour=Group)) +
  
  geom_point( size=2)





outlier_paas<-resplot[resplot$DeploymentType=="PaaS"& resplot$freq>=0.8,]



outlier_iaas<-resplot[resplot$DeploymentType=="IaaS"& resplot$freq>=0.8,]

iaas<- resplot[resplot$DeploymentType=="IaaS"& resplot$freq>=0.0000843 & resplot$freq<=0.1515152,]

ggplot(data=resplot, aes(x= DeploymentType, y= freq, colour=DeploymentType)) + geom_boxplot() + ylim(0,1) + ylab("Downtime/Lifetime Ratio")

ggplot(data=iaas, aes(x= freq)) + geom_histogram(binwidth=0.01) +
#  xlim(0.0,0.1) + 
  xlab("Ratio") +
  ylab("Nubmber of Deployments")



ggplot(data=iaas, aes(x= Lifetime, y=Downtime)) +
  
  geom_point( size=2) +
  xlim(0,1000)

ggplot(data=paas[paas$Group==5,], aes(x= Lifetime, y=Downtime, colour=Group)) +
  
  geom_point( size=2)

ggplot(data=resplot[resplot$freq >1 & resplot$freq <100,], aes(x= Lifetime, y=Downtime, colour=DeploymentType,shape=DeploymentType)) +
  
  geom_point( size=2) +
  
  
  
  xlim(0,10000)














ivs= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/DeploymentLifetime/Deployment_DT_20150501_IVS.txt", sep="\t", header=F,fill = TRUE )

colnames(ivs) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                   "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                   "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                   "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")
ivs <- as.data.frame(ivs)

downtime <- table(ivs$TenantName)
tenant <- names(downtime)

dc_aggr<- as.data.frame(cbind(tenant,downtime))

ivs_dtlt<-merge(iaas, dc_aggr, by.x="DeploymentGUID", by.y="tenant")

ggplot(data=ivs_dtlt, aes(x= Lifetime, y=Downtime, colour=Group)) +
  
  geom_point( size=2) +
  xlim(0,1000)


ggplot(data=ivs_dtlt, aes(x= freq, fill=Group)) +geom_histogram(binwidth= 0.01, colour="black") +
  xlab("Downtime/Lifetime Ratio") +
  ylab("Number of Deployments")
