using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataBaseConnectivityTry
    {

        private static string connectionString = "Data Source=5CG9410FHX;Initial Catalog=model;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //public static void Main(string[] args)
        //{
        //    //Delete(7);
        //    //Insert(4, "ramesh", "ECE", 22, DateTime.Now, "ramesh@gmail.com", 1231);
        //    CallFunction();
        //}

        public static void CallFunction()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "select * from getnamebyid(@id);";


            using(SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@id", "101"));
                using (SqlDataReader dataReader=cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);

                    Console.WriteLine(dt.Rows[0][0]);
                }
                
            }

            conn.Close();
        }
        public static void Delete(int id) {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = $"delete from dbo.Student where id={id}";

            SqlCommand cmd = conn.CreateCommand(); 
            cmd.CommandText = query;

            int count=cmd.ExecuteNonQuery();
            Console.WriteLine(count);

            conn.Close();
        }

        public static void Insert(int id,string name,string deptartment,int age,DateTime date,string email,int aadhar) {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //Console.WriteLine(date);
        
            string query = $"insert into dbo.Student values({id},'{name}','{deptartment}',{age},'{date:yyyy-MM-dd HH:mm:ss}','{email}',{aadhar})";

            try {
                SqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = query;

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1).Trim() + " " + reader.GetString(2).Trim() + " " + reader.GetInt32(3) + " " + reader.GetDateTime(4).ToString().Trim() + " " + reader.GetString(5).Trim() + " " + reader.GetInt32(6));
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            

            conn.Close();
        }
        public static  void Read()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "select * from dbo.Student";
            SqlCommand sqlCommand = conn.CreateCommand();
            sqlCommand.CommandText = query;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0)+" "+reader.GetString(1).Trim() + " " + reader.GetString(2).Trim()+" "+reader.GetInt32(3)+" "+reader.GetDateTime(4).ToString().Trim()+" "+reader.GetString(5).Trim()+" "+reader.GetInt32(6));
            }
            conn.Close();
        }

       

    }
}
