using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    internal class Base
    {
        SqlConnection conn;
        int n = 0;

        public SqlConnection Conn { get => conn; set => conn = value; }
        public int N { get => n; set => n = value; }

        public void OpenConn(string cnnstr)
        {
            Conn = new SqlConnection(cnnstr);
            try
            {
                Conn.Open();
                Console.WriteLine("Connection opened");
            }
            catch (SqlException ex)
            {
                N = 1;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Connection Not Established");
            }
        }

        public void CloseConn()
        {
            Conn.Close();
            Console.WriteLine("Connection closed");
        }

        public void CreateTable()
        {
            SqlCommand cmd = new SqlCommand("Create table menu (product_id nvarchar(10) primary key,product_name nvarchar(15) not null,cost money not null);", conn);
            SqlCommand cmd1 = new SqlCommand("create table members (member_id nvarchar(10) primary key,name nvarchar(40),address nvarchar(40));", conn);
            SqlCommand cmd2 = new SqlCommand("create table sales (sales_id nvarchar(10) primary key,member_id nvarchar(10), product_id nvarchar(10) FOREIGN KEY(member_id) REFERENCES members(member_id),FOREIGN KEY(product_id) REFERENCES menu(product_id))", conn);
        }
        public void InsertData()
        {
            SqlCommand cmd = new SqlCommand("insert into Members Values('MB01','Sathyan','krishnagiri');", conn);
            SqlCommand cmd1 = new SqlCommand("insert into Menu values('PD01','Sushi',20.0000);", conn);
            SqlCommand cmd2 = new SqlCommand("insert into Sales Values('S01','MB01','PD01','2021-01-02');", conn);
        }
    }
}
