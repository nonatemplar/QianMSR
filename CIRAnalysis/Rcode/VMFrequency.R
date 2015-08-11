install.packages("ff")
install.packages("mixtools")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)


data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/freq_test.txt", sep="\t", header=F,fill = TRUE )


colnames(data) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                   "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                   "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                   "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")

produced_table <-as.data.frame(data[,c("PreciseTimeStamp","LogicalContainterId","RoleType","RCAEngineCategory","Duration")])
produced_table$PreTime<-strptime(produced_table[,"PreciseTimeStamp"], "%m/%d/%Y %I:%M:%S %p")

VM_list<-unique(produced_table$LogicalContainterId)

lifetime<-c()

count<-c()
means<-c()
stds<-c()

for (i in 1:length(VM_list)) {
  vm_t<-produced_table[which(produced_table$LogicalContainterId==VM_list[i]),]
  count[i]=nrow(vm_t)
  lifetime[i] = as.numeric(vm_t$PreTime[nrow(vm_t)]- vm_t$PreTime[1],units="hours")
  if (nrow(vm_t)>3) {
    dur<-as.numeric(vm_t$PreTime[2:length(vm_t$PreTime)]-vm_t$PreTime[1:length(vm_t$PreTime)-1], units="hours")
    means[i]<-mean(dur)
    stds[i]<-sd(dur)
  }
  
}


mu1=703.338
sig1=1429.83
mu2=0.73845
sig2=0.66536

lt<-lifetime[9941]



gmmclassifier <- function (lt, mu1, sig1, mu2, sig2) {

  pc1<-pnorm(lt, mean=mu1, sd=sig1, lower.tail=FALSE) 

  pc2<-pnorm(lt, mean=mu2, sd=sig2, lower.tail=FALSE) 
  if (pc1 >= pc2) {
    return(1)
  }else{
    return(2)
  }
}

bins <- seq(min())

hist(l$lifetime,breaks =20, col = "lightblue", border = "pink",
     xlab="Duration (hour)", ylab="Frequency")

unplanned_list <- produced_table$

vm_t<-produced_table[which(as.character(produced_table$LogicalContainterId)==as.character(VM_list[12594])),]

vm_cir <- vm_t[vm_t$RCAEngineCategory=="CustomerInitiated",]
vm_ur <- vm_t[vm_t$RCAEngineCategory=="Unplanned",]


rs_vm<-getpoints(vm_cir,1, 0.3)


xlim=c(min(rs_vm$PreTime, vm_ur$PreTime), max(rs_vm$PreTime, vm_ur$PreTime))
plot(vm_cir$PreTime, rep(0.5, length(vm_cir$PreTime)), 
     ylim=c(0,3),
     #xlim=c(as.numeric(vm_cir$PreTime[1]),as.numeric(vm_cir$PreTime[10])),
     xlab="Time", ylab="Type of Reboot",
     col= "blue", pch=16)
points(vm_ur$PreTime, rep(2, length(vm_ur$PreTime)), col="red", pch=16)
points(rs_vm$PreTime, rep(1, length(rs_vm$PreTime)), col="green", pch=16)
legend("topright", legend=c("Unplanned","CustomerInitiated", "Filtered CustomerInitiated"), pch=c(16,16), col=c("red","blue","green"))


#
getpoints <- function(vm_t, thres, per) {
  dur<-as.numeric(vm_t$PreTime[2:length(vm_t$PreTime)]-vm_t$PreTime[1:length(vm_t$PreTime)-1], units="hours")
  bins <- seq(min(dur)-thres, max(dur)+thres, by=thres)  #Set break width to=1 hour
  h<-hist(dur,breaks =bins,plot = F)
  out_range=h$breaks[which(h$density>per)]
  if (!length(out_range)==0) {
    for (j in 1:length(out_range)) {
      vm_t<-vm_t[which(dur<out_range[j] | dur>out_range[j]+thres),]
    }
  }
  
  return(vm_t)
}


###range(h$breaks[which(h$density>0.3)],h$breaks[which(h$density>0.3)+1])

hist(vm_t$PreTime, col = "lightblue", border = "pink",
     xlab="Duration (hour)", ylab="Frequency")



hist(means)

hist(stds)

res<- as.data.frame(cbind(VM_list, TimePoint, lifetime, count, means,stds))

res[order(res$count, res$stds, decreasing=T),]

plot_res<-res[which(!is.na(res$means)&!is.na(res$stds)),]

l<-plot_res[plot_res$count>=10,]

l<-l[order( l$count, l$lifetime,  decreasing=T),]



plot(plot_res$means,plot_res$stds)

x<- plot_res[,c("means","stds")]
km<-kmeans(x,4, iter.max = 2000, nstart = 1, algorithm ="Lloyd", trace=FALSE)

gmmmodel <- normalmixEM(plot_res$means, k=2, lambda=c(0.9,0.1), mu=c(1, 2000),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)


write.csv(km$centers, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/freq_clusters.csv", quote=F, row.names=F)