install.packages("ggplot2")
install.packages("car")
install.packages("e1071")
library(e1071)
library(ggplot2)
library(car)

data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/test_CustomerUnplanned.txt", sep="\t", header=F)

colnames(data) <- c("TenantID", "CustomerInitiated", "Unplanned")

cus<-data[,"CustomerInitiated"]

logUnplanned <- log10(data[,"Unplanned"])
logCustom <- log10(data[,"CustomerInitiated"])
names(logUnplanned) <- c("logUnplanned")

names(logCustom) <- c("logCustom")

data <- cbind(data,logUnplanned, logCustom)

plot_data = as.data.frame(data)

plot_data = as.data.frame(data[which(plot_data[,"logUnplanned"]>0),])

plot_data = as.data.frame(plot_data [which(plot_data[,"logCustom"]<20 & plot_data[,"logCustom"]>0),])

colnames(data)


## Raw Data Plot

ggplot(plot_data, aes(x=CustomerInitiated, y=Unplanned)) +
  geom_point(shape=19)

## Log Plot

ggplot(plot_data, aes(x=logCustom, y=logUnplanned)) +
  geom_point(shape=19) +
  scale_size_area() +
  labs(size= "Nitrogen",
       x = "Custom Initated Rebooting (log10)",
       y = "Unplanned rebooting (log10)",
       title = "Comparson between Customer Initiated Rebooting and Unplanned Rebooting")


## Linear Model
formular <- logPlanned ~ logCustom

model <- lm(formular,data=plot_data)



#plot(model)

grid <- with(plot_data, expand.grid(
  logCustom = seq(min(logCustom), max(logCustom), length = 20)
))

grid$logPlanned <- stats::predict(model, newdata=grid)

ggplot(plot_data, aes(x=logCustom, y=logPlanned)) +
  geom_point(shape=19) + 
  geom_line(data=grid)

#VM Distribution

#DownTime Distribution

hist(plot_data[,"logUnplanned"], breaks =200, col = "lightblue", border = "pink")
##-- For non-equidistant breaks, counts should NOT be graphed unscaled:



# Analysis

correlation = cor(plot_data[,"logPlanned"], plot_data[,"logCustom"], method="pearson")
summary(model)

summary(anova(model))




















## Planned Reboot
data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/test_CustomerPlanned.txt", sep="\t", header=F)

colnames(data) <- c("TenantID", "CustomerInitiated", "Planned")

cus<-data[,"CustomerInitiated"]

logPlanned <- log10(data[,"Planned"])
logCustom <- log10(data[,"CustomerInitiated"])
names(logPlanned) <- c("logPlanned")

names(logCustom) <- c("logCustom")

data <- cbind(data,logPlanned, logCustom)

plot_data = as.data.frame(data)

plot_data = as.data.frame(data[which(plot_data[,"logPlanned"]>0),])

plot_data = as.data.frame(plot_data [which(plot_data[,"logCustom"]<20 & plot_data[,"logCustom"]>0),])

colnames(data)


## Raw Data Plot

ggplot(plot_data, aes(x=CustomerInitiated, y=Planned)) +
  geom_point(shape=19)

## Log Plot

ggplot(plot_data, aes(x=logCustom, y=logPlanned)) +
  geom_point(shape=19) +
  scale_size_area() +
  labs(size= "Nitrogen",
       x = "Custom Initated Rebooting (log10)",
       y = "Planned rebooting (log10)",
       title = "Comparson between Customer Initiated Rebooting and Planned Rebooting")

