using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    internal class Qstn3 : Base
    {
        string cnnstr;
        public Qstn3(string cnnstr)
        {
            this.Cnnstr = cnnstr;
        }

        public string Cnnstr { get => cnnstr; set => cnnstr = value; }

        public void ReadData()
        {
            OpenConn(Cnnstr);

            SqlCommand cmd = new SqlCommand("Select top 1 product_id , count(product_id) As Count from sales group by product_id  order by product_id desc;", Conn);
            SqlDataReader sdr;
            if (N != 1)
            {
                sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    Console.WriteLine("Table is Empty");
                }
                else
                {
                    Console.WriteLine("Product Id      No Of Purchases");
                    while (sdr.Read())
                    {
                        Console.WriteLine($"{sdr[0]}               {sdr[1]}");
                    }
                }
            }

            CloseConn();


        }
    }
}

