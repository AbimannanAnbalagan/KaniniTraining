using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    internal class Qstn4 : Base
    {
        string cnnstr;
        public Qstn4(string cnnstr)
        {
            this.Cnnstr = cnnstr;
        }

        public string Cnnstr { get => cnnstr; set => cnnstr = value; }

        public void ReadData()
        {
            OpenConn(Cnnstr);

            SqlCommand cmd = new SqlCommand("Select S.member_id , count(S.product_id) As No_of_products, SUM(M.cost) As Amount from Sales S join Menu M ON S.product_id = M.product_id group by member_id;", Conn);
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
                    Console.WriteLine("Member Id       Count of Product       Total Cost");
                    while (sdr.Read())
                    {
                        Console.WriteLine($"{sdr[0]}                 {sdr[1]}                  {sdr[2]}");
                    }
                }
            }

            CloseConn();


        }
    }
}
