using System.Data.SqlClient;

namespace ADO_Assessment
{
    internal class Qstn1 : Base
    {
        string cnnstr;
        public Qstn1(string cnnstr) 
        {
            this.Cnnstr = cnnstr;
        }

        public string Cnnstr { get => cnnstr; set => cnnstr = value; }

        public void ReadData()
        {
            OpenConn(Cnnstr);

            SqlCommand cmd = new SqlCommand("Select S.member_id,sum(m.cost) from sales S join menu M ON S.product_id = M.product_id group by member_id", Conn);
            SqlDataReader sdr;
            if (N != 1) { 
                sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    Console.WriteLine("Table is Empty");
                }
                else
                {
                    Console.WriteLine("Member_Id    Total Cost Spent");
                    while (sdr.Read())
                    {
                    Console.WriteLine($"  {sdr[0]}           {sdr[1]}");
                    }
                }

                CloseConn();
            }
            else
            {
                Console.WriteLine("Needs Connection to read data");
            }

            


        }

        
    }

}