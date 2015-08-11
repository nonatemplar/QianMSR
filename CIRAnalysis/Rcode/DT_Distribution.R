install.packages("ggplot2")
install.packages("car")
install.packages("e1071")
library(e1071)
library(ggplot2)
library(car)
library(MASS)


data= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/test_VM_DT_Distribution.txt", sep="\t", header=F)

colnames(data) <- c("VMID","TenantID", "Reason", "DTCounts")

sort_data<- data[order(data[,"TenantID"], data[,"VMID"], data[,"Reason"]),]

CIR <- as.data.frame(data[data[,"Reason"]=="CustomerInitiated",])

Planned <- as.data.frame(data[data[,"Reason"]=="Planned",])

Unplanned <- as.data.frame(data[data[,"Reason"]=="Unplanned",])



Planned_CIR<-merge(CIR, Planned, by="VMID")

Unplanned_CIR <- merge(CIR, Unplanned, by="VMID")

sort_unplanned_CIR <- Unplanned_CIR[order(Unplanned_CIR[,"DTCounts"])]

plot_data <- as.data.frame(Unplanned_CIR)
sort_plot_data <- plot_data[order(-plot_data[,"DTCounts.y"],-plot_data[,"DTCounts.x"]),]

logCIR <- log10(plot_data[,"DTCounts.x"])

logUR <- log10(plot_data[,"DTCounts.y"])

plot_data <-cbind(plot_data, logCIR, logUR)

p_input <-plot_data

p_input <- plot_data[plot_data[,"DTCounts.y"]==1,]

View(p_input[order(-p_input[,"DTCounts.x"]),])

p_input <- p_input[p_input[,"DTCounts.x"]==10 , ]

CIR_counts <- p_input[,"DTCounts.x"]
CIR_factor <- factor(CIR_counts, levels=c(min(CIR_counts):max(CIR_counts)))

bins <- table(CIR_factor)

VMs <- factor(bins, levels=c(min(bins):max(bins)))
DTs <- as.factor(as.numeric(names(bins)))

test_x=as.factor(as.numeric(seq(min(CIR_counts),max(CIR_counts), by=1)))

distribution <- as.data.frame(cbind(VMs,DTs))

formula <- VMs~DTs

model <-glm(formula, data=distribution, family = "quasipoisson")

distribution$fitted <- model$fitted.values
ggplot(distribution, aes(x = DTs, y = fitted)) +
  geom_point(aes(y = VMs), alpha=.5, position=position_jitter(h=.2)) +
  geom_line(size = 1) +
  ggtitle("Poisson regression when UR==1") +
  labs(x = "Number of DTs per VM", y = "Number of VMs") +
  ylim(c(0,50))

anova(model)

summary(model)


predict(model, test_x,type="response", se.fit=TRUE)

parms <- fitdistr(bins, "poisson")

parms

plot (DTs,VMs)
h <- hist(p_input[,"DTCounts.x"], width =1, col = "lightblue", border = "pink")