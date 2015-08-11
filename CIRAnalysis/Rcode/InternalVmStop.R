library(ggplot2)

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/Raw_InternalVmStop.txt", sep="\t", header=F,fill = TRUE )


colnames(data) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                   "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                   "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                   "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")

produced_table <-as.data.frame(data)
produced_table$PreTime<-strptime(produced_table[,"PreciseTimeStamp"], "%m/%d/%Y %I:%M:%S %p")

tenant<-table(unknown$TenantId)
tenant<-tenant[order(tenant, decreasing = T)]

AM3 <- produced_table[produced_table$DataCenter=="AM3",]

AM3$TenantName <- as.character(AM3$TenantName)

AM3_tenant<- table(AM3$TenantName)

AM3_tenant<-AM3_tenant[order(AM3_tenant, decreasing=T)]

ggplot(AM3, aes(x=TenantName, fill=TenantName)) + geom_histogram()

start <- as.POSIXct("2015-06-01")
end <- as.POSIXct("2015-06-02")
date_plot<- produced_table[produced_table$PreTime>start & produced_table$PreTime<end,]

plot<-date_plot[date_plot$RCA=="Unknown.Unknown.ContainerControlActionType=InternalVmStop",]

produced_table[produced_table$TenantId=="004cd841-4be7-4eda-88be-1507c76ba322",]$RoleInstanceName



output<-cbind(names(tenant),tenant)
colnames(output) <-c("Tenant","DT Count")
write.csv(output, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/tenant_list.csv", quote=F, row.names=F)

length(unique(produced_table$LogicalContainterId)) ##How many VMs

produced_table %>% ggvis(~PreTime, ~Duration) %>% layer_points()


sd(produced_table$Duration[produced_table$RCAEngineCategory=="Unknown"])

table(produced_table$RCA)

unknown<-produced_table[produced_table$RCA=="Unknown.Unknown.ContainerControlActionType=InternalVmStop",]

customer<-produced_table[produced_table$RCA=="CustomerInitiated.Unknown.ContainerControlActionType=InternalVmStop",]

length(unique(customer$LogicalContainterId))
sc <- scale_fill_continuous() 
sc$legend <- FALSE 
gp<-ggplot(customer, aes(PreTime,Duration),legend = FALSE) + 
 geom_point(aes(group=RCALevel1, colour=RCALevel2)) 
sc$legend <- FALSE 

gp<-ggplot(plot, aes(PreTime,Duration)) + geom_point(aes(group=RCAEngineCategory, colour=RCAEngineCategory))


ggplot(produced_table, aes(PreTime,fill=DataCenter), width=0.5) + 
  geom_histogram(binwidth = 3600*24*60,position='dodge') +
  xlim(as.POSIXct("2015-06-01"), as.POSIXct("2015-06-16"))

ggplot(produced_table, aes(Cluster, fill=Cluster), width=0.5) + 
  geom_bar(width=1) 


ggplot(unknown, aes(x=Duration, fill=RCA)) + geom_bar(binwidth = 10) 

### Data Center
datacenter<-table(produced_table$DataCenter)
datacenter<-as.data.frame(datacenter)
colnames(datacenter) <- c("Data Center", "Downtime Counts")

write.csv(datacenter, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/DataCenter_list.csv", quote=F, row.names=F)

plot <- produced_table[produced_table$DataCenter=="BL2", ]



ggplot(plot, aes(PreTime, fill=Cluster), width=0.5) + 
  geom_bar(binwidth=3600*24, width=1) 

ggplot(plot, aes(PreTime, fill=DataCenter), width=0.5) + 
  geom_bar(width=1) 

#Cluster
cluster<-table(produced_table$Cluster)
cluster<-as.data.frame(cluster)
colnames(cluster) <- c("Cluster", "Downtime Counts")

write.csv(cluster, "E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/InternalVmStop/Cluster_list.csv", quote=F, row.names=F)

plot <- produced_table[produced_table$Cluster=="BL2PrdApp08", ]



ggplot(plot, aes(PreTime, fill=TenantId), width=0.5) + 
  geom_bar(binwidth=3600*24, width=1) 

ggplot(plot, aes(PreTime, fill=DataCenter), width=0.5) + 
  geom_bar(width=1) 


#Tenant
Tenant<-table(produced_table$TenantId)
Tenant<-as.data.frame(Tenant)
colnames(Tenant) <- c("Tenant", "Downtime Counts")

Tenant<-Tenant[order(Tenant[,2], decreasing=T),]

plot <- produced_table[produced_table$TenantId=="57de4219-0087-49e1-9058-5d5ad570ed54", ]

ggplot(plot, aes(DataCenter, fill=Cluster), width=0.5) + 
  geom_bar(width=1) 

