install.packages("ff")
install.packages("mixtools")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)

#Function
gmmclassifier <- function (lt, mu1, sig1, mu2, sig2) {
  
  pc1<-pnorm(lt, mean=mu1, sd=sig1, lower.tail=FALSE) 
  
  pc2<-pnorm(lt, mean=mu2, sd=sig2, lower.tail=FALSE) 
  if (pc1 >= pc2) {
    return(1)
  }else{
    return(2)
  }
}

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

#PREDEFINE
mu1=703.338
sig1=1429.83
mu2=0.73845
sig2=0.66536

#Progress

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/freq_ur_cir.txt", sep="\t", header=F,fill = TRUE )


colnames(data) <-c("PreciseTimeStamp","StartTime", "EndTime", "LogicalContainterId",
                   "RoleInstanceName", "TenantName", "RoleInstanceId", "TenantId","NodeId",
                   "ContainerId", "DataCenter", "Cluster", "RoleType", "TransitionSignature",
                   "CADCategory","RCAEngineCategory", "RCALevel1", "RCALevel2", "Duration", "RCA" , "EventList")

produced_table <-as.data.frame(data[,c("PreciseTimeStamp","LogicalContainterId","RoleType","RCAEngineCategory","Duration")])
produced_table$PreTime<-strptime(produced_table[,"PreciseTimeStamp"], "%m/%d/%Y %I:%M:%S %p")

exec_table <- produced_table[produced_table$RoleType == "Regular",]

#VM_list<-length(as.character(unique(exec_table$LogicalContainterId)))

rank <- table(exec_table$LogicalContainterId)

rank = rank[rank>4]
sort(rank, decreasing = T)

VM_list <- names(rank)
res_vm_table <- exec_table[exec_table$RCAEngineCategory=="Unplanned",]

count_ur=c()
count_cir=c()

for (i in 1:length(VM_list)) {
  vm_t<-exec_table[which(as.character(exec_table$LogicalContainterId)==VM_list[i]),]

  count[i]=nrow(vm_t)
  lifetime[i] = as.numeric(vm_t$PreTime[nrow(vm_t)]- vm_t$PreTime[1],units="hours")
  if (gmmclassifier(lifetime[i], mu1,sig1,mu2,sig2)==1) {
    vm_cir <- vm_t[vm_t$RCAEngineCategory=="CustomerInitiated",]
    vm_ur <- vm_t[vm_t$RCAEngineCategory=="Unplanned",]
    if (nrow(vm_cir)>4) {
      rs_vm<-getpoints(vm_cir,1, 0.3)
      res_vm_table <- rbind(res_vm_table,rs_vm)
      count_ur[i]=nrow(vm_ur)
      count_cir[i]=nrow(rs_vm)
    }
  }
  
}

############ Time Slots 
C_overall=c()
C_CI=c()
C_U=c()
C_U_CI=c()


start <- as.POSIXct("2015-05-17")
end <- as.POSIXct("2015-06-15")

interval <- 60


Time_list=seq(from=start, by=interval*60, to=end)

Result<-as.data.frame(Time_list)

Result$C_overall = rep( 0, length(Result$Time_list))
Result$C_CI=rep( 0, length(Result$Time_list))
Result$C_U=rep( 0, length(Result$Time_list))
Result$C_U_CI=rep( 0, length(Result$Time_list))
Result$C_CI_after_U=rep( 0, length(Result$Time_list))

  for (i in 1:length(VM_list)) {
    vm_t<-res_vm_table[which(as.character(res_vm_table$LogicalContainterId)==as.character(VM_list[i])),]
    vm_cir=vm_t[vm_t$RCAEngineCategory=="CustomerInitiated",]
    vm_ur=vm_t[vm_t$RCAEngineCategory=="Unplanned",]
    for (j in 1:length(Time_list)) {
      st<-Time_list[j]
      et<-st+interval*60
      cir_oc=length(which(vm_cir$PreTime>=st & vm_cir$PreTime<et))
      ur_list=which(vm_ur$PreTime>=st & vm_ur$PreTime<et)
      if (length(ur_list) != 0) {
        for (k in 1:length(ur_list)) {
          if (length(which(vm_cir$PreTime > vm_ur[k,]$PreTime & vm_cir$PreTime<= (vm_ur[k,]$PreTime+interval*60))) != 0) {
            Result$C_CI_after_U[j] = Result$C_CI_after_U[j]+1
          }
        }
      }
      ur_oc=length(which(vm_ur$PreTime>=st & vm_ur$PreTime<et))
      
      if (cir_oc >0) {
        Result$C_CI[j] = Result$C_CI[j]+1
      }
      if (ur_oc >0) {
        Result$C_U[j] = Result$C_U[j]+1
      }
      if (cir_oc >0 & ur_oc >0) {
        Result$C_U_CI[j] = Result$C_U_CI[j]+1
      }
      Result$C_overall[j] = Result$C_overall[j]+1
    }
    print(i)
  }

P_CI=sum(Result$C_CI)/sum(Result$C_overall)

P_U=sum(Result$C_U)/sum(Result$C_overall)

P_CI_U=sum(Result$C_U_CI)/sum(Result$C_overall)

P_CI_after_U/P_U

P_CI_after_U=sum(Result$C_CI_after_U)/sum(Result$C_overall)

P_CI_U=sum(Result$C_CI)*sum(Result$C_U) / (sum(Result$C_overall)*sum(Result$C_overall))
                                    


res_comp<- as.data.frame(cbind(VM_list, count_ur, count_cir))

boxplot(count_cir~count_ur, data=res_comp,notch=F, varwidth=F, col="green",
        xlim=c(0,10), ylim=c(0,50),
        xlab="Number of unplanned reboot", ylab="number of customer initiated reboot")


t.test(count_cir[count_ur==3], count_cir[count_ur==2])

hist(count_cir[count_ur>=4], breaks =50, col = "lightblue", border = "pink",
     xlab="Customer Initiated Reboot", ylab="VMs", xlim=c(0,300))



