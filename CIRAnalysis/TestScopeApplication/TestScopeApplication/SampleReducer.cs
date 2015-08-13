
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SampleReducer : Reducer
{

     public override Schema Produces(string[] columns, string[] args, Schema input)

     {

          return new Schema("ContainerId:string,DowntimeCounts:int");  

     }

 

     public override IEnumerable<Row> Reduce(RowSet input, Row output, string[] args)

     {

          int container_id = 0;

          StringBuilder sb = new StringBuilde();

          bool first = true;
    
          Hashtable containerCount=new Hashtable();      

          foreach (Row row in input.Rows)

          {
              if (containerCount.Contains(row[0])) {
                    containerCount[row[0]]++;
              }
              else {
                    containerCount.Add(row[0], 1);
              }

          }
          
          output[0].Set(containerCount.keys());

          output[1].Set(containerCount.Values());

          yield return output;

     }

}
