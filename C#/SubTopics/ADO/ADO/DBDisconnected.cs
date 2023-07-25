/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect
{
    internal class DBDisconnected
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public void OpenConn()
        {
            
            string connstr = "Data source=ABI-A\\SQLEXPRESS; Initial catalog = student; integrated security = SSPI";
            conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                Console.WriteLine("Opened");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Connection Not established");
                
            }
            
        }
        
        public void Insert()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            ds.Tables["stud_details"].Columns[0].Unique= true;
            int rno = 32101; string name = "unknown";
            DataRow dr = ds.Tables["stud_details"].NewRow();
            dr[0] = rno;
            dr[1] = name;

            ds.Tables["stud_details"].Rows.Add(dr);

            da.Update(ds, "stud_details");
            conn.Close();
        }

        public void Update(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            foreach (DataRow dr in ds.Tables["stud_details"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString()) == rno) 
                {
                    dr["name"] = "Abi";
                }
            }
            da.Update(ds, "stud_details");
            Console.WriteLine("Updated");
            conn.Close();
            ReadData();

        }

        public void ReadData()
        {
            da = new SqlDataAdapter("select * from stud_details",conn);
            ds = new DataSet();
            da.Fill(ds,"stud_details");
            Console.WriteLine(ds.Tables["stud_details"].Columns[0]);

            foreach(DataRow dr in ds.Tables["stud_details"].Rows)
            {
                Console.WriteLine(dr[0].ToString() +" "+ dr[1].ToString());
            }
            conn.Close();
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTrialConnection
{
    internal class DbDisconnectedArch
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
       

        public void OpenConn()
        {
            //create connection
            conn = new SqlConnection(@"data source=DESKTOP-QCJN09K\SQLEXPRESS;Initial catalog=DbTrial; integrated security=SSPI");
            conn.Open();
            Console.WriteLine("opened");

        }
        public void ReadData()
        {
            da = new SqlDataAdapter("select * from student1", conn);
            ds = new DataSet();
            da.Fill(ds, "s1");

            foreach (DataRow dr in ds.Tables["s1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + dr[1].ToString());
            }
            conn.Close();
        }
        public void InsrtRced(int id, string nm)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            //int id = 2;string nm = "kumar";

            DataRow dr = ds.Tables["s1"].NewRow();

            dr[0] = id;
            dr[1] = nm;

            ds.Tables["s1"].Columns[0].Unique = true;

            ds.Tables["s1"].Rows.Add(dr);

            da.Update(ds, "s1");
            //conn.Close() ;
            Console.WriteLine("inserted");
        }
        public void Updaterec(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            foreach (DataRow dr in ds.Tables["s1"].Rows)
            {
                if (Convert.ToInt32(dr[0].ToString()) == rno)
                {
                    dr["name"] = "chge";
                }
            }
            da.Update(ds, "s1");
            conn.Close();
            Console.WriteLine("updated");
            ReadData();

        }
        public void DeleteRec(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            foreach (DataRow dr in ds.Tables["s1"].Rows)
            {
                if (Int32.Parse(dr[0].ToString()) == rno)
                {
                    dr.Delete();
                    break;
                }
            }
            //Console.WriteLine("deleted");
            da.Update(ds, "s1");
            Console.WriteLine("deleted");
            //ReadData();
            conn.Close();

        }
        public void Insrtable()
        {
            SqlCommand cmd = new SqlCommand("insert into student1 values (100,'raju')", conn);
            if (conn != null)
            {
                int cou = cmd.ExecuteNonQuery();
                Console.WriteLine(cou + "inserted");
            }
        }
    }
}