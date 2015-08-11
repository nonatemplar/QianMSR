install.packages("ggplot2")
install.packages("car")
install.packages("e1071")
library(e1071)
library(ggplot2)
library(car)

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/test_VM_DT_Distribution.txt", sep="\t", header=F)

colnames(data) <- c("VMID","TenantID", "Reason", "DTCounts")

sort_data<- data[order(data[,"TenantID"], data[,"VMID"], data[,"Reason"]),]

reduced_data <- matrix(data=NA, nrow=0, ncol=5)

colnames(reduced_data) <-c("VMID","TenantID","CustomerInitiated","Planned","Unplanned")
r=sort_data[1,]



CurrentVM=r["VMID"]
CurrentRow<- rep(NA, 5)
names(CurrentRow) <- c("VMID","TenantID","CustomerInitiated","Planned","Unplanned")
for (i in 1:nrow(sort_data)) {
  r=sort_data[i,]
  Re=r["Reason"]
  if (CurrentVM != sort_data[i,"VMID"] || i==1){
    reduced_data=rbind(reduced_data, CurrentRow)
    CurrentRow<- rep(NA, 5)
    names(CurrentRow) <- c("VMID","TenantID","CustomerInitiated","Planned","Unplanned")
    CurrentRow[1]=CurrentVM
    CurrentRow[2]=r[2]
    
    CurrentRow[Re]=r["DTCounts"]
  }else{
    CurrentRow[Re]=r["DTCounts"]
  }
  
}

CIR <- as.data.frame(data[data[,"Reason"]=="CustomerInitiated",])
Planned <- as.data.frame(data[data[,"Reason"]=="Planned",])
Unplanned <- as.data.frame(data[data[,"Reason"]=="Unplanned",])

Planned_CIR<-merge(CIR, Planned, by="VMID")

Unplanned_CIR <- merge(CIR, Unplanned, by="VMID")

dim(Planned)
table(Planned[,"DTCounts"])

dim(Unplanned)
table(Unplanned[,"DTCounts"])


type=Planned
type[,"VMID"]

sortedCIR <- CIR[order(-CIR[,"DTCounts"]),]

write.table(sortedCIR[1:10,],"E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/Top10_DC_monthly.csv", sep=",",row.names=F, col.names=T,quote=F)

nrow(data[data[,"DTCounts"]==1,])/nrow(data)

nrow(CIR[CIR[,"DTCounts"]==1,])/nrow(CIR)

nrow(Planned[Planned[,"DTCounts"]==0,])/nrow(Planned)

nrow(Unplanned[Unplanned[,"DTCounts"]==0,])/nrow(Unplanned)


max(CIR[, "DTCounts"])

plot_data <- as.data.frame(Unplanned_CIR)

logCIR <- log10(plot_data[,"DTCounts.x"])

logUR <- log10(plot_data[,"DTCounts.y"])

plot_data <-cbind(plot_data, logCIR, logUR)



## Unplanned DC Distribution
input<-logUR
h <- hist(input, breaks =50, col = "lightblue", border = "pink")
numVMs <- c(NA,h$counts)

incNumVMs <- c(0)



for (i in 2:length(numVMs)) {
  incNumVMs[i]= incNumVMs[i-1]+numVMs[i]
}

rateInc <- incNumVMs/incNumVMs[length(incNumVMs)]


par(mfrow = c(2, 1)) 
plot(h$breaks,  log10(numVMs), type="p", pch=19,
     xlim=c(0,4), ylim=c(0,5),
     main="Distribution: How many UR Downtimes per VM",
     xlab="Number of DTs per VM (log 10)", ylab="Number of VMs (log 10)"
)
grid()
plot(h$breaks,  rateInc, type="l", pch=19,
     xlim=c(0,4), ylim=c(0,1),
     main="Percent of DTs",
     xlab="Number of DTs per VM (log 10)", ylab="Incremental Percent of VMs(%)"
)
grid()


##plot Downtime per VM


p_input <- plot_data[plot_data[,"DTCounts.y"]==1,]


h <- hist(log10(p_input[,"DTCounts.x"]), breaks =50, col = "lightblue", border = "pink")

numVMs <- c(NA,h$counts)

incNumVMs <- c(0)



for (i in 2:length(numVMs)) {
  incNumVMs[i]= incNumVMs[i-1]+numVMs[i]
}

rateInc <- incNumVMs/incNumVMs[length(incNumVMs)]


par(mfrow = c(2, 1)) 
plot(h$breaks,  log10(numVMs), type="p", pch=19,
     xlim=c(0,3), ylim=c(0,5),
     main="Distribution: How many CIR Downtimes per VM (UR==1)",
     xlab="Number of DTs per VM (log 10)", ylab="Number of VMs (log 10)"
)
grid()
plot(h$breaks,  rateInc, type="l", pch=19,
     xlim=c(0,3), ylim=c(0,1),
     main="Percent of DTs",
     xlab="Number of DTs per VM (log 10)", ylab="Incremental Percent of VMs(%)"
)
grid()
dev.off()


ggplot(plot_data, aes(x=DTCounts.x, y=DTCounts.y)) +
  geom_point(shape=19)

ggplot(plot_data, aes(x=logCIR, y=logUR)) +
  geom_point(shape=19) +
  scale_size_area() +
  labs(size= "Nitrogen",
       x = "Custom Initated Rebooting (log10)",
       y = "Unplanned rebooting (log10)",
       title = "Comparson between Customer Initiated Rebooting and Unplanned Rebooting")



#max # of DTs

plot_data[which(plot_data[,"DTCounts"]==max(plot_data[,"DTCounts"])),]