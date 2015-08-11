install.packages("ff")
install.packages("mixtools")
install.packages("mclust")

library(e1071)
library(ggplot2)
library(car)
library(MASS)
library(ff)
library(mixtools)
library(mclust)


data= read.table.ffdf(file="E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/VM_DT_lifetime_iaas.txt", sep="\t", header=F,fill = TRUE )

colnames(data) <-c("LogicalContainterId","InitTime","LastTime")

produced_table <-as.data.frame(data)

time_format <- "%m/%d/%Y %I:%M:%S %p"

produced_table$ITime<-strptime(produced_table[,"InitTime"], "%m/%d/%Y %I:%M:%S %p")
produced_table$LTime<-strptime(produced_table[,"LastTime"], "%m/%d/%Y %I:%M:%S %p")

produced_table$Duration <-as.numeric(produced_table$LTime-produced_table$ITime, units="hours")

Dur= produced_table$Duration[which(!is.na(produced_table$Duration))]

#sample(Dur, n, replace = FALSE, prob = NULL)


##Gaussian Mixtual Model

gmmmodel <- normalmixEM(Dur, k=2, lambda=c(0.9,0.1), mu=c(1, 6000),
                        mean.constr = NULL, sd.constr = NULL,
                        epsilon = 1e-08, maxit = 1000, maxrestarts=20, 
                        verb = FALSE, fast=FALSE, ECM = FALSE,
                        arbmean = TRUE, arbvar = TRUE)

gmmmodel$lambda
gmmmodel$mu
gmmmodel$sigma

##Logistic regression


plot_dur <- produced_table$Duration[produced_table$Duration>=48]


produced_table$Duration[is.na(produced_table$Duration)]

p<-ggplot(produced_table, aes(produced_table$Duration)) + geom_histogram()

h <- hist(plot_dur,  breaks =200, col = "lightblue", border = "pink",
          #xlim=c(0,1000), ylim=c(0,90000),
          xlab="DT history (Hrs)", ylab="Amount of VMs",
          main="VM Downtime history")

num <- c(NA,h$counts)

incNum <- c(0)

for (i in 2:length(num)) {
  incNum[i]= incNum[i-1]+num[i]
}
rateInc <- incNum/incNum[length(incNum)]
rateNum<-num/incNum[length(incNum)]

##Fitting

fit<-lm(log(rateNum)~h$breaks)

summary(fit)

##plotting

xl=c(0,6500)


par(mfrow = c(2, 1)) 
plot(h$breaks,  rateNum, type="h", lwd=1.5, col="pink",
     xlim=xl,
     #ylim=c(0,20000),
     main="Distribution: VM DT Lifetime",
     xlab="Duration (hrs)", ylab="Amount of VMs"
)
points(h$breaks,  rateNum, type="l", lwd=1.5, col="blue")
grid()
plot(h$breaks,  rateInc, type="l", pch=19,
     xlim=xl,
     ylim=c(0,1),
     main="Percent of Tenants",
     xlab="Duration (hrs)", ylab="Incremental Percent of Tenants(%)"
)
grid()
dev.off()