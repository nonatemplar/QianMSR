using System;

public class SampleReducer : Reducer
{

    public override Schema Produces(string[] columns, string[] args, Schema input)
    {

        return new Schema("User_ID:int,Names:string");

    }



    public override IEnumerable<Row> Reduce(RowSet input, Row output, string[] args)
    {

        int user_id = 0;

        StringBuilder sb = new StringBuilder();

        bool first = true;



        foreach (Row row in input.Rows)
        {

            if (first)
            {

                sb.Append(row[1].Value);

                first = false;

                user_id = row[0].Integer;

            }

            else
            {

                sb.Append(",");

                sb.Append(row[1].String);

            }
        }

        output[0].Set(user_id);

        output[1].Set(sb.ToString());

        yield return output;

    }

}
