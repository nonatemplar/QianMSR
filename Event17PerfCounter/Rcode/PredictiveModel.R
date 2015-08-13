install.packages('e1071')
install.packages('ROCR')

library(rpart)
library(ROCR)

#lp0.select <- lp0[lp0$Delta == -1800000 | lp0$Delta == -1500000|lp0$Delta == -1200000|lp0$Delta == -900000|lp0$Delta == -600000|lp0$Delta == -300000,]

lp0.select <- lp0[lp0$Delta == -1800000 | lp0$Delta == -1500000|lp0$Delta == -1200000|lp0$Delta == -900000,]

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

#write.table(new_event17s, "E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/new_event17s.csv", sep=",", col.names=F,row.names=F)


#control.select <- control[control$Delta == -1800000 | control$Delta == -1500000|control$Delta == -1200000|control$Delta == -900000|control$Delta == -600000|control$Delta == -300000,]
control.select <- control[control$Delta == -1800000 | control$Delta == -1500000|control$Delta == -1200000|control$Delta == -900000,]

controlCenter_list<-control[control$Delta==0,c("CenteredTime", "NodeIdentity", "Cluster","DataCenter")]


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

#write.table(new_control, "E:/AzureComputeInsights/ComputeInsight/Event17perfCounter/Results/new_control_40000.csv", sep=",", col.names=F,row.names=F)


processor = c(1:36, 94:118)

storage = c(37:52, 79:94)

memory = c(53:68)

network = c(69:78, 119:136)


evensamp=sample(nrow(new_event17s),size=ceiling(nrow(new_event17s)/10))
consamp=sample(nrow(new_control),size=ceiling(nrow(new_control)/100))

event17involve <- new_event17s[evensamp,]

controlinvolve <- new_control[consamp,]






set <- rbind(event17involve, controlinvolve)

#identities <- rbind(event17_ids[evensamp,],control_ids[consamp,])


labels <- as.factor(c(rep(1, nrow(event17involve)), rep(2, nrow(controlinvolve))))

dtset<-as.data.frame(set)

dtset$labels <-labels

s <- sample(length(labels))

piece <- ceiling(length(labels)/10)

pred <-c()

prob <-c()

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
  prob<-c(prob,predict(dt, newdata=test_set)[,2])
  pred<-c(pred, predict(dt, newdata=test_set,type="class"))
  
  acc<-c(acc, 
         sum(diag(table(predict(dt, newdata=test_set, type="class"),test_set$labels)))/length(predict(dt, newdata=test_set, type="class")))
  
  
}



acc=sum(diag(table(pred,real)))/length(pred)

tl<-table(pred,real)

prec = tl[1,1]/(tl[2,1]+tl[1,1])
rec = tl[1,1]/(tl[1,1]+tl[1,2])

fscore = 2*(prec*rec)/(prec+rec)

acc
prec
rec
fscore

x = c(1,2,3)


pr<-prediction(prob,real)

perf1<-performance(pr,"prec","rec")

p1_x=perf1@x.values[[1]]
p1_y=perf1@y.values[[1]]
p10_x=perf10@x.values[[1]]
p10_y=perf10@y.values[[1]]
p100_x=perf100@x.values[[1]]
p100_y=perf100@y.values[[1]]




plot(p1_x,p1_y,type="l", col="green", xlab="Precision", ylab="Recall", ylim=c(0,1),xlim=c(0,1))
points(p10_x,p10_y,type="l", col="blue")
points(p100_x,p100_y,type="l", col="red")
grid()
legend("bottomright",legend=c("1to1", "1to10","1to100"), lty=c(1,1,1), col=c("green", "blue","red"))

pr<-prediction(prob[,2],real)
perf<-performance(pr,"tpr","fpr")
plot(perf)

thres<-seq(0.01,0.99, by=0.01)

prec_rec<-matrix(NA, ncol=2,nrow=0)
for (j in 1:length(thres)) {
  test_pred<-c()
  for (i in 1:nrow(prob)) {
    test_pred =c(test_pred, if (prob[i,1]<thres[j]) 2 else 1)
    
  }
  
  
  tl=table(test_pred,real)
  #trupos = if(exists(tl["1","1"]))
  prec = tl[1,1]/(tl[2,1]+tl[1,1])
  rec = tl[1,1]/(tl[1,1]+tl[1,2])
  prec_rec=rbind(prec_rec,c(prec,rec))
}

formula = labels~.
dt <- rpart(formula, data= dtset, method="class")

printcp(dt)
plotcp(dt)

plot(dt, uniform=TRUE, 
     main="Classification Tree for Prediction")
text(dt, use.n=TRUE, all=TRUE, cex=.8)

#write.table(control, "E:/AzureComputeInsights/ComputeInsight/Control.csv", sep=",", col.names=T, row.names=F, quote=F)
