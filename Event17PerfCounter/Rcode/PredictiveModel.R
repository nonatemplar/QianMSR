install.packages('e1071')
install.packages('ROCR')

library(rpart)
library(ROCR)

lp0.select <- lp0[lp0$Delta == -1800000 | lp0$Delta == -1500000|lp0$Delta == -1200000|lp0$Delta == -900000|lp0$Delta == -600000|lp0$Delta == -300000,]

event17s<-lp0[lp0$Delta==0,]


new_event17s <- matrix(NA, nrow=0, ncol=68*2)
event17_ids<-matrix(NA,nrow=0,ncol=4)

for (i in 1: nrow(event17s)) {
  single_event = lp0.select[lp0.select$Event17Time == event17s$Event17Time[i] & lp0.select$NodeIdentity==event17s$NodeIdentity[i] & lp0.select$Cluster==event17s$Cluster[i],5:72]
  event17_ids<-rbind(event17_ids, event17s[i, 1:4])
  new_row = c()
  for (j in 1:ncol(single_event)) {
    cols <- single_event[, j]
    new_row <-c(new_row, mean(cols), sd(cols))
  }
  new_event17s <-rbind(new_event17s,new_row)
}

control.select <- control[control$Delta == -1800000 | control$Delta == -1500000|control$Delta == -1200000|control$Delta == -900000|control$Delta == -600000|control$Delta == -300000,]

controlCenter_list<-control[control$Delta==0,]


new_control <- matrix(NA, nrow=0, ncol=68*2)

control_ids<-matrix(NA,nrow=0,ncol=4)
for (i in 1: nrow(controlCenter_list)) {
  single_event = control.select[control.select$CenteredTime == controlCenter_list$CenteredTime[i] & control.select$NodeIdentity==controlCenter_list$NodeIdentity[i] & control.select$Cluster==controlCenter_list$Cluster[i],5:72]
  control_ids<-rbind(control_ids,controlCenter_list[i,1:4])
  new_row = c()
  for (j in 1:ncol(single_event)) {
    cols <- single_event[, j]
    new_row <-c(new_row, mean(cols), sd(cols))
  }
  new_control <-rbind(new_control,new_row)
}

set <- rbind(new_event17s, new_control)

identities <- rbind(event17_ids,control_ids)


labels <- as.factor(c(rep(1, nrow(new_event17s)), rep(2, nrow(new_control))))

dtset<-as.data.frame(set)

dtset$labels <-labels

s <- sample(length(labels))

piece <- ceiling(length(labels)/10)

pred <-c()

real <-c()

acc <- c()

map_ids <- matrix(NA, ncol=4,nrow=0)

for (i in 1:10) {
  selected <-c()
  if (i != 10) {
    selected<-s[(piece*(i-1)+1):(piece*i)]
  }else{
      selected<-s[(piece*(i-1)+1):length(s)]
  }
  test_set <- dtset[selected,]
  map_ids<-rbind(map_ids, identities[selected, ])
  training_set<-dtset[-selected,]

  formula = labels~.
  dt <- rpart(formula, data=training_set,method="class")
  real <-c(real, test_set$labels)
  
  pred<-c(pred, predict(dt, newdata=test_set, type="class"))
  
  acc<-c(acc, 
         sum(diag(table(predict(dt, newdata=test_set, type="class"),test_set$labels)))/length(predict(dt, newdata=test_set, type="class")))
  
  
}

sum(diag(table(pred,real)))/length(pred)

pr<-prediction(pred,real)

perf<-performance(pr,"tpr","fpr")

plot(perf)
grid()

table(pred,real)


formula = labels~.
dt <- rpart(formula, data= dtset, method="class")

printcp(dt)
plotcp(dt)

plot(dt, uniform=TRUE, 
     main="Classification Tree for Prediction")
text(dt, use.n=TRUE, all=TRUE, cex=.8)

#write.table(control, "E:/AzureComputeInsights/ComputeInsight/Control.csv", sep=",", col.names=T, row.names=F, quote=F)
