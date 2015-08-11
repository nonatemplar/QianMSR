data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/DT_Accenture_3.csv", sep="\t", header=F,fill = TRUE )


colnames(data) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                   "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                   "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                   "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")

produced_table <-as.data.frame(data)
produced_table$PreTime<-strptime(produced_table[,"PreciseTimeStamp"], "%m/%d/%Y %I:%M:%S %p")

plot<-produced_table[produced_table$RCALevel2=="ContainerControlActionType=InternalVmStop",]


start <- as.POSIXct("2015-05-03")
end <- as.POSIXct("2015-05-10")

ggplot(plot, aes(PreTime, fill=RCA ), width=0.5) + 
  geom_histogram(binwidth=3600, width=1, position="stack") +
  geom_density(alpha=.2, fill="#FF6666")+
  xlim(start, end)

unplanned_list <- unique(produced_table[produced_table$RCAEngineCategory=="Unplanned" ,]$LogicalContainterId)
