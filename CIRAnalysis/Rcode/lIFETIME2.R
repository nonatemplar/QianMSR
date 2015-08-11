start <- as.POSIXct("2015-01-01")
end <-as.POSIXct("2015-02-02")
deployment<-AzureDeployments[AzureDeployments$StartTime >= start & AzureDeployments$LastTime < end,]

VM= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/TimeSeries.txt", sep="\t", header=F,fill = TRUE )

colnames(VM) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                 "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                 "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                 "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")

produced_table <-as.data.frame(VM[,1:21])
time_format <- "%m/%d/%Y %I:%M:%S %p"

produced_table$PreTime<-strptime(produced_table[,"PreciseTimeStamp"], "%m/%d/%Y %I:%M:%S %p")
produced_table$STime<-strptime(produced_table[,"StartTime"], "%m/%d/%Y %I:%M:%S %p")
produced_table$ETime<-strptime(produced_table[,"EndTime"], "%m/%d/%Y %I:%M:%S %p")

res <-merge(produced_table, deployment, by.x="TenantName", by.y="DeploymentGUID")



count <-table(as.character(res$TenantName))
lt<-c()

for (i in 1:length(count)) {
  lt[i] = deployment[deployment$DeploymentGUID==names(count[i]),]$LifeTime
}

plot(lt,count$value)

ggplot(res, aes(x= LifeTime,fill=DeploymentType)) + geom_histogram(position="stack")  +
  
  #  scale_fill_gradient(name= "Lifetime (log10)",low = "black", high = "pink")+
  