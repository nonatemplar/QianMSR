library(e1071)
library(ggplot2)
library(car)
library(MASS)


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

period=range(produced_table[,"STime"])

VM_list <- as.character(unique(produced_table[,"LogicalContainterId"]))


VM_index=c()
VM_names=c()

VM_scores=c()


#Unit= 60  ##Meausure Unit (min=60, hour=3600, day=86400)
for (i in 1:length(VM_list)){
  VM_table <- produced_table[produced_table[,"LogicalContainterId"]==VM_list[i],]
  period=range(VM_table[,"STime"])
  diff_time=as.numeric(period[2]-period[1],units = "days")
  #dim(VM_table)
  if (diff_time<=10){next}

  
  start_index= which(VM_table[,"RCAEngineCategory"]=="Unplanned")
  

  
  obj_score=c()
  for (j in 1:length(start_index)) {
    cia_table=VM_table[start_index[j]:nrow(VM_table),]
    cia_table=cia_table[cia_table[,"RCAEngineCategory"]=="CustomerInitiated",]
    if (nrow(cia_table)<2){
      obj_score[j]=0
    }else{
      unplanned_time= VM_table[start_index[j], "STime"]
      
      dist=abs(as.numeric(cia_table[,"STime"]- unplanned_time,units = "hours"))
      obj_score[j]=sum(exp(-dist))/length(dist)
    }
    
  }
  VM_index=c(VM_index,i)
  VM_names=c(VM_names,VM_list[i])
  VM_scores=c(VM_scores,mean(obj_score))
}

VM_results=as.data.frame(cbind(VM_index,VM_names,VM_scores))
nui=as.character(VM_results[VM_results[,"VM_scores"]==max(VM_scores),"VM_names"])

rt<- produced_table[produced_table[,"LogicalContainterId"]==nui,]
dim(rt)
#CIR <-rt[rt[,"RCAEngineCategory"]=="CustomerInitiated",]
#Unplanned <-rt[rt[,"RCAEngineCategory"]=="Unplanned",]

ggplot(aes(x = PreTime, y = Duration, colour=RCAEngineCategory), data = rt) + 
  geom_point(size=3) + 
  labs(xlab = "Time", ylab="Downtime Duration") +ylim(c(0,max(rt$Duration)))

as.numeric(rt$ETime[1]-rt$STime[1])

################# Unplanned effect score
#### Obj(t_c)= 1/n * sum(exp(-|t_c-t_u|))

start_index= which(time_table[,"RCAEngineCategory"]=="Unplanned")

Unit= 86400  ##Meausure Unit (min=60, hour=3600, day=86400)


for (i in 1:length(start_index)) {
  cia_table=time_table[start_index[i]:nrow(time_table),]
  cia_table=cia_table[cia_table[,"RCAEngineCategory"]=="CustomerInitiated",]
  unplanned_time= cia_table[start_index[i], "StartTime"]
  
  dist=abs(as.numeric(cia_table[,"StartTime"]- unplanned_time))/Unit
  obj_score=sum(exp(-dist))/length(dist)
  
  
  obj_scores=Obj(cia_table, unplanned_time)
  
}





