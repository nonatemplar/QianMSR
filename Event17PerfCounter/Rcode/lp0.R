install.packages("ff")
install.packages("mixtools")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)
library(reshape2)

#perfCounter= read.table("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/pc_partition_testresult.csv", sep=",", header=T,fill = TRUE )
lp0= read.table("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/perf_LP0_event17_occur_all_2015.csv", sep=",", header=T,fill = TRUE )


colnames(lp0) <- c("TIMESTAMP", "NodeIdentity", "Cluster","DataCenter","HLP_TR_count","HLP_TR_value","HRVP_T61_count",
"HRVP_T61_value","HRVP_TR_count","HRVP_TR_value","HVP_PFI_count","HVP_PFI_value","HVP_MIM_count","HVP_MIM_value",
"HVP_TM_count","HVP_TM_value","HVP_TI_count","HVP_TI_value","HVP_TR_count","HVP_TR_value","HVP_GR_count","HVP_GR_value",
"VSD_WB_count","VSD_WB_value","VSD_RB_count","VSD_RB_value","LD_MOSFS_count","LD_MOSFS_value","LD_MAPPFS_count",
"LD_MAPPFS_value","Memory_PNB_count","Memory_PNB_value","Memory_PPB_count","Memory_PPB_value","Memory_P_count",
"Memory_P_value","Memory_AM_count","Memory_AM_value","NA_RB_count","NA_RB_value","NA_BR_count","NA_BR_value",
"NA_BT_count","NA_BT_value","NA_BS_count","NA_BS_value","NI_MAXBT_count","NA_MAXBT_value","PD_MAPPIT_count",
"PD_MAPPIT_value","PD_ADW_count","PD_ADW_value","PD_MOSIT_count","PD_MOSIT_value","PD_ADR_count","PD_ADR_value",
"Process_TC_count","Process_TC_value","Process_WS_count","Process_WS_value","Process_HC_count","Process_HC_value",
"Processor_PT_count","Processor_PT_value","Processor_DPCT_count","Processor_DPCT_value","Processor_ProT_count",
"Processor_ProT_value","TCPv4_CF_count","TCPv4_CF_value","TCPv4_CE_count","TCPv4_CE_value","Delta", "modDelta", "Event17_Occurrence", "Event17_Time")



lp0 <- as.data.frame(lp0)

lp0$time<-strptime(lp0[,"TIMESTAMP"], "%m/%d/%Y %I:%M:%S %p")
lp0$Event17Time <-strptime(lp0$Event17_Time, "%m/%d/%Y %I:%M:%S %p")
event17s<-lp0[lp0$Delta==0,]
event17s<-lp0[lp0$Delta==0 & lp0$Cluster != "BL3PrdApp10",]


df.m<-melt(lp0, id.var="Delta")

ggplot(lp0,aes(y=TCPv4_CF_value,x=Delta, group=Delta)) + geom_boxplot()

ggplot(event17s, aes(time, fill=Cluster)) + geom_bar(binwidth=60*60*24)

for (i in 1:nrow(event17s)) {
  single_event = lp0[lp0$Event17Time == event17s$Event17Time[i] & lp0$NodeIdentity==event17s$NodeIdentity[i] & lp0$Cluste==event17s$Cluster[i],]
  node<-toString(event17s$NodeIdentity[i])
  node<-gsub("\\.","_",node)
  timestamp<-toString(event17s$TIMESTAMP[i])
  timestamp<-gsub(" ", "_", timestamp)
  timestamp<-gsub("/", "_", timestamp)
  timestamp<-gsub(":", "_", timestamp)
  perf_counters = single_event[, 5:72]
  t<- single_event$Delta/1000/60
  for (j in 1:ncol(perf_counters)) {
    cName<-colnames(perf_counters)[j]
    fig_path=paste("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/SingleEventPlots/",cName,"_",node,"_",timestamp, ".jpg",sep = "", collapse = NULL)
    jpeg(fig_path)
    plot(t, perf_counters[,j], type = "b" ,ylab=cName, xlab="Time (min)", main=cName)
    grid()
    dev.off()
  }
  
}

intv <- c(-6:6)

deltas <- intv*60*5*1000

aggr_pcs <- matrix(NA, ncol = 68, nrow = 0)

for (i in 1:length(deltas)) {
  pcs <- lp0[lp0$Delta == deltas[i],5:72]
  aggr_pcs<-rbind(aggr_pcs, c(colMeans(pcs)))

}
for (j in 1:ncol(aggr_pcs)) {
  cName<-colnames(aggr_pcs)[j]
  fig_path=paste("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/AggrPlot_7Clusters/",cName, ".jpg",sep = "", collapse = NULL)
  jpeg(fig_path)
  plot(t, aggr_pcs[,j], type = "b" ,ylab=cName, xlab="Time (min)", main=cName)
  grid()
  dev.off()
}

cluster_list<-unique(event17s$Cluster)

for(n in 1:length(cluster_list)) {
  dir_path <-paste("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/", cluster_list[n],"/", sep="",collapse = NULL)
  dir.create(file.path(dir_path), showWarnings = F)
  aggr_pcs <- matrix(NA, ncol = 68, nrow = 0)
  
  for (i in 1:length(deltas)) {
    pcs <- lp0[lp0$Delta == deltas[i] & lp0$Cluster == cluster_list[n],5:72]
    aggr_pcs<-rbind(aggr_pcs, c(colMeans(pcs)))
    
  }
  for (j in 1:ncol(aggr_pcs)) {
    cName<-colnames(aggr_pcs)[j]
    fig_path=paste(dir_path,cluster_list[n],"_",cName, ".jpg",sep = "", collapse = NULL)
    jpeg(fig_path)
    plot(t, aggr_pcs[,j], type = "b" ,ylab=cName, xlab="Time (min)", main=cName)
    grid()
    dev.off()
  }
  
}


Processing_pcs <- c("HLP_TR_value", "HRVP_TR_value","Processor_PT_value","Processor_DPCT_value","Processor_ProT_value","Process_WS_value","Process_TC_value","Process_HC_value")

Memory_pcs<- c("Memory_PNB_value","Memory_PPB_value","Memory_P_value","Memory_AM_value")

Network_pcs<- c("NA_RB_count","NA_BR_count","NA_BT_count","NA_BS_count","NA_BS_value")

Storage_pcs<- c("VSD_WB_count","VSD_WB_value","VSD_RB_count","VSD_RB_value")

TCP<-c("TCPv4_CE_value","TCPv4_CF_value")
TCP_legends<-c("TCPv4 Connection Established","TCPv4 Conneciton Failures")

Processing_legends<-c("Hyper-V Hypervisor \nLogical Processor\n % Total Run Time", 
                      "Hyper-V Hypervisor \nRoot Virtual Processor 0 (LP0)\n % Total Run Time", 
                      "% Processor Time", "% DPC Time","%Previleged Time",
                      "Process Working Set", "Process Thread Count", "Process Handle Count")

Logical_Storage<-c("LD_MOSFS_value","LD_MAPPFS_value")

Physical_Storage<-c("PD_MAPPIT_value","PD_MOSIT_value","PD_ADW_value","PD_ADR_value")

PD_legends<-c("MIN APP % Idle Time","MIN OS % Idle Time", "Average Disk sec/write", "Average Disk sec/read")


process<-lp0[, TCP]

aggr_pcs <- matrix(NA, ncol = ncol(process), nrow = 0)
for (i in 1:length(deltas)) {
  pcs <- process[lp0$Delta == deltas[i],]
  aggr_pcs<-rbind(aggr_pcs, c(colMeans(pcs)))
  
}
aggr_pcs <- scale(aggr_pcs)

dev.off()
par(xpd = T, mar = par()$mar + c(0,0,0,14))

for (j in 1:ncol(aggr_pcs)) {
  if (j == 1) {
    plot(t, aggr_pcs[,j], type = "b" ,col=j+1, ylim=c(-3,3),
         ylab="Scaled Values", xlab="Time (min)")
    rect(-5, -3, 0, 3, col=rgb(0, 1, 0, alpha=0.2), lty=2) 
  }else{
    points(t, aggr_pcs[,j], type = "b", col = j+1)
  }
}
grid()
legend(36,3,col = c(2:(ncol(process)+1)), legend=TCP_legends, lty = rep(1, ncol(process)))



#########################################################
##########################################################
##########################################################
###########################################################
aggr_pcs<-as.data.frame(aggr_pcs)
aggr_pcs$delta<-deltas




for (j in 1:ncol(aggr_pcs)) {
  cName<-colnames(aggr_pcs)[j]
  fig_path=paste("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/AggrPlot_7Clusters/",cName, ".jpg",sep = "", collapse = NULL)
  jpeg(fig_path)
  plot(t, aggr_pcs[,j], type = "b" ,ylab=cName, xlab="Time (min)", main=cName)
  grid()
  dev.off()
}



node_list<- unique(lp0$NodeIdentity)

intv <- c(-5:5)

time <- intv*60*5*1000

plot_lp0=lp0[lp0$NodeIdentity==node_list[14],c("NA_BR_value","NA_BT_value","NA_BS_value","NA_MAXBT_value", "Delta")]

df <- melt(plot_lp0 , id.vars='Delta', variable.name = "Variables")

ggplot(df, aes(Delta/1000/60,value)) + geom_line(aes(colour = Variables)) 


ggplot(lp0, aes(x=Delta/1000/60, y=HRVP_TR_count, colour = NodeIdentity)) + geom_line()

nodes <- lp0$NodeIdentity[!is.na(lp0$Event17_ocurr)]
time <- lp0$time[!is.na(lp0$Event17_ocurr)]

length(table(lp0$NodeIdentity))

all<-unique(lp0$NodeIdentity)

node_list<- c(nodes, all[15], all[24])

plot_lp0 <- lp0[ lp0$NodeIdentity =="10.237.46.80",]



ggplot(plot_lp0, aes(x = time, y= LP0_Value)) + geom_line() +geom_vline(xintercept = as.numeric(time[1]), colour= "red")

colnames(perfCounter) <- c("TIMESTAMP",
                           "NodeIdentity",
                           "Cluster","
                           DataCenter","
                           HLP_TR_count","
                           HLP_TR_value","
                           HRVP_T61_count","
                           HRVP_T61_value","
                           HRVP_TR_count","
                           HRVP_TR_value","
                           HVP_PFI_count","
                           HVP_PFI_value","
                           HVP_MIM_count","
                           HVP_MIM_value","
                           HVP_TM_count","
                           HVP_TM_value","
                           HVP_TI_count","
                           HVP_TI_value","
                           HVP_TR_count","
                           HVP_TR_value","
                           HVP_GR_count","
                           HVP_GR_value","
                           VSD_WB_count","
                           VSD_WB_value","
                           VSD_RB_count","
                           VSD_RB_value","
                           LD_MOSFS_count","
                           LD_MOSFS_value","
                           LD_MAPPFS_count","
                           LD_MAPPFS_value","
                           Memory_PNB_count","
                           Memory_PNB_value","
                           Memory_PPB_count","
                           Memory_PPB_value","
                           Memory_P_count","
                           Memory_P_value","
                           Memory_AM_count","
                           Memory_AM_value","
                           NA_RB_count","
                           NA_RB_value","
                           NA_BR_count","
                           NA_BR_value","
                           NA_BT_count","
                           NA_BT_value","
                           NA_BS_count","
                           NA_BS_value","
                           NI_MAXBT_count","
                           NA_MAXBT_value","
                           PD_MAPPIT_count","
                           PD_MAPPIT_value","
                           PD_ADW_count","
                           PD_ADW_value","
                           PD_MOSIT_count","
                           PD_MOSIT_value","
                           PD_ADR_count","
                           PD_ADR_value","
                           Process_TC_count","
                           Process_TC_value","
                           Process_WS_count","
                           Process_WS_value","
                           Process_HC_count","
                           Process_HC_value","
                           Processor_PT_count","
                           Processor_PT_value","
                           Processor_DPCT_count","
                           Processor_DPCT_value","
                           Processor_ProT_count","
                           Processor_ProT_value","
                           TCPv4_CF_count","
                           TCPv4_CF_value","
                           TCPv4_CE_count","
                           TCPv4_CE_value","Event17_ocurr", "Delta", "modDelta")

p<- as.data.frame(perfCounter)

data<-p[1:100,5:72]

qplot(x=Var1, y=Var2, data=melt(cor(data, use="p")), fill=value, geom="tile") +
  scale_fill_gradient2(limits=c(-1, 1)) + theme(axis.text.x=element_text(angle=90))


q=melt(crr, na.rm=T)

qplot(data=q,aes(x=variables, y=value), fill=value, geom="tile") +
   scale_fill_gradient2(limits=c(-1, 1))


crr<- cor(p[,5:72])

View(crr)

crr <- as.data.frame(crr)





qplot(crr, geom='density')


heatmap(crr, na.rm=F)


subs <- as.data.frame(subs)