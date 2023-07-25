using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    internal class Qstn5 : Base
    {
        string cnnstr;
        public Qstn5(string cnnstr)
        {
            this.Cnnstr = cnnstr;
        }

        public string Cnnstr { get => cnnstr; set => cnnstr = value; }

        public void ReadData()
        {
            OpenConn(Cnnstr);

            SqlCommand cmd = new SqlCommand("Select S.member_id , sum(cost)*10 As Points  from sales S join menu M on S.product_id = M.product_id group by S.member_id;", Conn);
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
                    Console.WriteLine("Member Id         Points");
                    while (sdr.Read())
                    {
                        Console.WriteLine($"{sdr[0]}              {sdr[1]}");
                    }
                }
            }

            CloseConn();


        }
    }
}
