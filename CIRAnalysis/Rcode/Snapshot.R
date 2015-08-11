
library(ggplot2)

ss= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/DeploymentLifetime/running_snapshot.txt",  sep="\t", header=F,fill = TRUE )

colnames(ss) <- c("DeploymentGUID","CreateTime", "AuditTime","DeploymentType")

deps<-as.data.frame(ss)

deps$StartTime <-strptime(deps[,"CreateTime"], "%m/%d/%Y %I:%M:%S %p")

deps$SuspendTime <- as.POSIXct(deps$AuditTime)

deps<-deps[deps$CreateTime !="1/1/0001 12:00:00 AM" & deps$CreateTime !="1/1/1601 12:00:00 AM" & deps$CreateTime !="1/1/1801 12:00:00 AM"]

curr<- as.POSIXct("2015-07-06")

deps$living<-as.numeric(curr - deps$StartTime, units="hours")





table(deps$living)[1:10]

quantile(deps$living[!is.na(deps$living)])

plotdeps<- deps[deps$living<=1558 & deps$DeploymentType=="IaaS",]

ggplot(plotdeps, aes(x=living/24)) +
  geom_bar(binwidth=1, fill="green", colour="black") + xlim(20,70) +
  xlab("Days") +
  ylab("Number of Tenants")

ggplot(plotdeps, aes(x=living)) +stat_bin(breaks=c(0, 0.5,2,24, 24*5, 24*30,1558), fill="green", colour="black")+coord_polar()+xlim(0,500)

h<-hist(deps$living, breaks= 100)

