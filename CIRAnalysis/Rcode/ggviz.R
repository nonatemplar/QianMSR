install.packages("ggvis")
isntall.packages("dplyr")

library(ggvis)
library(dplyr)

head(mtcars)
mtcars %>% ggvis(~wt, ~mpg) %>% layer_points()
mtcars %>% 
  ggvis(~wt, ~mpg) %>%
  layer_points() %>%
  layer_smooths()

mtcars %>% 
  ggvis(~wt, ~mpg) %>%
  layer_points() %>%
  layer_model_predictions(model = "lm", se = TRUE)

mtcars %>% 
  ggvis(~wt, ~mpg) %>% 
  layer_points(fill = ~factor(hp))

cust= read.table("E:/AzureComputeInsights/ComputeInsight/CIRproject/TestResults/VM_RCA_RoleType_Counts_Duration.txt", sep="\t", header=F,fill = TRUE )

colnames(cust) <- c("RCA", "RoleType", "Count", "Duration")

RCA<-as.data.frame(cust)

RCA_cust<-RCA[grep(pattern="^CustomerInitiated", RCA$RCA),]

mtcars %>% ggvis(~mpg, ~wt, size = ~cyl, fill = ~cyl) %>% layer_points() %>%
  add_legend(c("size", "fill"))


RCA_cust <- RCA_cust[order(-RCA_cust$Count),]

RCA_cust_select <- RCA_cust[RCA_cust$Count>500, ]

RCA_cust_select$index <- c(1:length(RCA_cust_select$RCA))

RCA_cust_select$PrDuration <- RCA_cust_select$Duration/max(RCA_cust_select$Duration)

RCA_cust_select$PrCounts <- RCA_cust_select$Count/max(RCA_cust_select$Count)

RCA_cust_select %>% ggvis(~index, ~PrCounts) %>% layer_points(size= ~PrCounts, fill= ~RoleType) %>%
  layer_lines(~index, ~PrDuration) %>%
  add_legend("fill",title= "RoleType",) %>%
  hide_legend("size")

RCA_cust_select %>% ggvis( ~Duration,~Count, fill= ~RoleType) %>% layer_points() %>%
  layer_lines(~)

