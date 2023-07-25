using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    internal class Qstn2 : Base
    {
        string cnnstr;
        public Qstn2(string cnnstr)
        {
            this.Cnnstr = cnnstr;
        }

        public string Cnnstr { get => cnnstr; set => cnnstr = value; }

        public void ReadData()
        {
            OpenConn(Cnnstr);

            SqlCommand cmd = new SqlCommand("Select member_id , count(distinct(date)) from sales group by member_id;", Conn);
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
                    Console.WriteLine("Member Id      No of Visited Days");
                    while (sdr.Read())
                    {
                        Console.WriteLine($"{sdr[0]}                 {sdr[1]}");
                    }
                }
            }

            CloseConn();


        }
    }
}
