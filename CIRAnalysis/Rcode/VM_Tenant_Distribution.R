install.packages("ggplot2")
install.packages("car")
install.packages("e1071")
library(e1071)
library(ggplot2)
library(car)

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/test_VMDistribution.txt", sep="\t", header=F)

colnames(data) <- c("TenantID", "DTCounts", "VMCounts")

logVMC <- log10(plot_data[,"VMCounts"])


plot_data <- as.data.frame(data)

#Distribution of VMs per tenant owns:

h <- hist(logVMC, breaks =500, col = "lightblue", border = "pink")
numTenant <- c(NA,h$counts)

incNumTenant <- c(0)

rateInc <- incNumTenant/incNumTenant[length(incNumTenant)]

for (i in 2:length(numTenant)) {
  incNumTenant[i]= incNumTenant[i-1]+numTenant[i]
}
par(mfrow = c(2, 1)) 
plot(h$breaks,  log10(numTenant), type="p", pch=19,
     xlim=c(0,6), ylim=c(0,8),
     main="Distribution: How many VMs per tenant",
     xlab="Number of VMs per tenant (log10)", ylab="Number of Tenants (log10)"
     )
grid()
plot(h$breaks,  rateInc, type="l", pch=19,
     xlim=c(0,6), ylim=c(0,1),
     main="Percent of Tenants",
     xlab="Number of VMs per tenant (log10)", ylab="Incremental Percent of Tenants(%)"
     )
grid()
dev.off()



#max # of VMs

plot_data[which(plot_data[,"VMCounts"]==max(plot_data[,"VMCounts"])),]