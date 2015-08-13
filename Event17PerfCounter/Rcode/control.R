library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)
library(reshape2)

#perfCounter= read.table("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/pc_partition_testresult.csv", sep=",", header=T,fill = TRUE )
control= read.table("E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/perf_LP0_control_occur_40000_2015.csv", sep=",", header=T,fill = TRUE )


colnames(control) <- c("TIMESTAMP", "NodeIdentity", "Cluster","DataCenter","HLP_TR_count","HLP_TR_value","HRVP_T61_count",
                   "HRVP_T61_value","HRVP_TR_count","HRVP_TR_value","HVP_PFI_count","HVP_PFI_value","HVP_MIM_count","HVP_MIM_value",
                   "HVP_TM_count","HVP_TM_value","HVP_TI_count","HVP_TI_value","HVP_TR_count","HVP_TR_value","HVP_GR_count","HVP_GR_value",
                   "VSD_WB_count","VSD_WB_value","VSD_RB_count","VSD_RB_value","LD_MOSFS_count","LD_MOSFS_value","LD_MAPPFS_count",
                   "LD_MAPPFS_value","Memory_PNB_count","Memory_PNB_value","Memory_PPB_count","Memory_PPB_value","Memory_P_count",
                   "Memory_P_value","Memory_AM_count","Memory_AM_value","NA_RB_count","NA_RB_value","NA_BR_count","NA_BR_value",
                   "NA_BT_count","NA_BT_value","NA_BS_count","NA_BS_value","NI_MAXBT_count","NA_MAXBT_value","PD_MAPPIT_count",
                   "PD_MAPPIT_value","PD_ADW_count","PD_ADW_value","PD_MOSIT_count","PD_MOSIT_value","PD_ADR_count","PD_ADR_value",
                   "Process_TC_count","Process_TC_value","Process_WS_count","Process_WS_value","Process_HC_count","Process_HC_value",
                   "Processor_PT_count","Processor_PT_value","Processor_DPCT_count","Processor_DPCT_value","Processor_ProT_count",
                   "Processor_ProT_value","TCPv4_CF_count","TCPv4_CF_value","TCPv4_CE_count","TCPv4_CE_value","Delta", "modDelta",  "Centered_Time")



control <- as.data.frame(control)

control$time<-strptime(control[,"TIMESTAMP"], "%m/%d/%Y %I:%M:%S %p")
control$CenteredTime <-strptime(control$Centered_Time, "%m/%d/%Y %I:%M:%S %p")

process<-control[, Processing_pcs]

aggr_pcs <- matrix(NA, ncol = ncol(process), nrow = 0)
for (i in 1:length(deltas)) {
  pcs <- process[control$Delta == deltas[i],]
  aggr_pcs<-rbind(aggr_pcs, c(colMeans(pcs)))
  
}
aggr_pcs <- scale(aggr_pcs)

dev.off()
par(xpd = T, mar = par()$mar + c(0,0,0,14))

for (j in 1:ncol(aggr_pcs)) {
  if (j == 1) {
    plot(t, aggr_pcs[,j], type = "b" ,col=j+1, ylim=c(-3,3), ylab="Scaled Values", xlab="Time (min)")
    #rect(-5, -3, 0, 3, col=rgb(0, 1, 0, alpha=0.2), lty=2) 
  }else{
    points(t, aggr_pcs[,j], type = "b", col = j+1)
  }
}
grid()
legend(36,3,col = c(2:(ncol(process)+1)), legend=Processing_legends, lty = rep(1, ncol(process)))
