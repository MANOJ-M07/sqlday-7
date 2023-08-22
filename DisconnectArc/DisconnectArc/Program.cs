/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectArc
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataSet ds;
        static string conString = "server=LAPTOP-DLI2FL88;database=Day7Db;trusted_Connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand("select * from Customer", con);
                adapter = new SqlDataAdapter(cmd);
                con.Open();
                ds = new DataSet();
                adapter.Fill(ds);
                con.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine("ID:" + ds.Tables[0].Rows[i]["Id"]);
                    Console.WriteLine("Name:" + ds.Tables[0].Rows[i]["Name"]);
                    Console.WriteLine("ODLimit:" + ds.Tables[0].Rows[i]["ODLimit"]);
                    Console.WriteLine("StartDate:" + ds.Tables[0].Rows[i]["SStartDate"]);
                    Console.WriteLine("EndDate:" + ds.Tables[0].Rows[i]["SEndDate"]);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program!!!");
                Console.ReadKey();  
            }
        }
    }
}*/

//DataReader example

/*using System;
using System.Data.SqlClient;

namespace DisconnectArc
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string conString = "server=LAPTOP-DLI2FL88;database=Day7Db;trusted_Connection=true;";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand("select * from Customer", con);
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("ID:" + reader["Id"]);
                    Console.WriteLine("Name:" + reader["Name"]);
                    Console.WriteLine("ODLimit:" + reader["ODLimit"]);
                    Console.WriteLine("StartDate:" + reader["SStartDate"]);
                    Console.WriteLine("EndDate:" + reader["SEndDate"]);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (con != null && con.State == System.Data.ConnectionState.Open)
                    con.Close();

                Console.WriteLine("End of program!!!");
                Console.ReadKey();
            }
        }
    }
}*/

//insert example
/*using System;
using System.Data.SqlClient;
using System.Data;

namespace conAppDisconectedArch
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string conString = "server=LAPTOP-DLI2FL88 ;database=Day7Db; trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "insert into Customer " + "(Id,Name,ODLimit,SStartDate ,SEndDate) values(@id,@name,@odlimit,@sd ,@ed)";
                cmd.Connection = con;
                Console.WriteLine("enter Id");
                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Name");
                cmd.Parameters.AddWithValue("@Name", Console.ReadLine());
                Console.WriteLine("Enter ODLimit");
                cmd.Parameters.AddWithValue("ODLimit", double.Parse(Console.ReadLine()));
                Console.WriteLine("Enter StartDate");
                cmd.Parameters.AddWithValue("@sd", DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Enter EndDate");
                cmd.Parameters.AddWithValue("@ed", DateTime.Parse(Console.ReadLine()));
                cmd.ExecuteNonQuery();
                Console.WriteLine("Added!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!!!");
                Console.ReadKey();
            }
        }
    }
}*/

//using System;
//using System.Data.SqlClient;
//using System.Data;

//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);
//                con.Open();
//                ds = new DataSet();
//                adapter.Fill(ds);
//                con.Close();

//                for(int i =0; i< ds.Tables[0].Rows.Count; i++)
//                {
//                    Console.WriteLine("ID:" + ds.Tables[0].Rows[i]["ID"]);
//                    Console.WriteLine("Name:" + ds.Tables[0].Rows[i]["Name"]);
//                    Console.WriteLine("ODLimit:" + ds.Tables[0].Rows[i]["ODLimit"]);
//                    Console.WriteLine("StartDate:" + ds.Tables[0].Rows[i]["SStartDate"]);
//                    Console.WriteLine("EndDate:" + ds.Tables[0].Rows[i]["SEndDate"]);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!!"+ ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program!!!");
//                Console.ReadKey();
//            }
//        }
//    }
//}


//with data reader

//using System;
//using System.Data.SqlClient;
//using System.Data;

//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                con.Open();
//                SqlDataReader reader = cmd.ExecuteReader();

//               while(reader.Read())
//                {
//                    Console.WriteLine("ID:" +reader["ID"]);
//                    Console.WriteLine("Name:" + reader["Name"]);
//                    Console.WriteLine("ODLimit:" + reader["ODLimit"]);
//                    Console.WriteLine("StartDate:" + reader["SStartDate"]);
//                    Console.WriteLine("EndDate:" + reader["SEndDate"]);
//                }
//               reader.Close();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!!" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.WriteLine("End of Program!!!");
//                Console.ReadKey();
//            }
//        }
//    }
//}




//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                con.Open();
//                cmd = new SqlCommand();
//                cmd.CommandText = "insert into Customer " + "(Id,Name,ODLimit,SStartDate ,SEndDate) values(@id,@name,@odlimit, @sd ,@ed)";
//                cmd.Connection = con;
//                Console.WriteLine("enter Id");
//                cmd.Parameters.AddWithValue("@id",int.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Name");
//                cmd.Parameters.AddWithValue("@Name",Console.ReadLine());
//                Console.WriteLine("Enter ODLimit");
//                cmd.Parameters.AddWithValue("ODLimit", double.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter StartDate");
//                cmd.Parameters.AddWithValue("@sd",DateTime.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter EndDate");
//                cmd.Parameters.AddWithValue("@ed", DateTime.Parse(Console.ReadLine()));
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Added!!!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error!!!" + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("End of Program!!!");
//                Console.ReadKey();
//            }
//        }
//    }
//}


//inserted
//using System;
//using System.Data.SqlClient;
//using System.Data;

//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);  //fetch the data from the table

//                con.Open();

//                ds = new DataSet();   //collection of tables  
//                adapter.Fill(ds, "Customer");

//                DataTable dt = ds.Tables["Customer"];
//                DataRow dr = dt.NewRow();

//                Console.WriteLine("Enter Id");
//                dr["Id"] = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Name");
//                dr["Name"] = Console.ReadLine();
//                Console.WriteLine("Enter OD Limit");
//                dr["ODLimit"] = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Subscription Start Date");
//                dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Subscription End Date");
//                dr["SEndDate"] = DateTime.Parse(Console.ReadLine());

//                dt.Rows.Add(dr);
//                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                adapter.Update(ds, "Customer");
//                Console.WriteLine("Inserted!!!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

//indexing
//using System;
//using System.Data.SqlClient;
//using System.Data;

//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);  //fetch the data from the table

//                con.Open();

//                ds = new DataSet();   //collection of tables  
//                adapter.Fill(ds);

//                DataTable dt = ds.Tables[0];
//                DataRow dr = dt.NewRow();

//                Console.WriteLine("Enter Id");
//                dr["Id"] = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Name");
//                dr["Name"] = Console.ReadLine();
//                Console.WriteLine("Enter OD Limit");
//                dr["ODLimit"] = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Subscription Start Date");
//                dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Subscription End Date");
//                dr["SEndDate"] = DateTime.Parse(Console.ReadLine());

//                dt.Rows.Add(dr);
//                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                adapter.Update(ds);
//                Console.WriteLine("Inserted!!!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

//delete

//using System;
//using System.Data.SqlClient;
//using System.Data;


//namespace conAppDisconectedArch
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataAdapter adapter;
//        static DataSet ds;
//        static string conString = "server= LAPTOP-EA5C4MP1;database=Day7Db; trusted_connection = true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(conString);
//                cmd = new SqlCommand("select * from Customer", con);
//                adapter = new SqlDataAdapter(cmd);  //fetch the data from the table
//                con.Open();
//                ds = new DataSet();   //collection of tables  
//                adapter.Fill(ds);
//                DataTable dt = ds.Tables[0];
//                Console.WriteLine("Enter customer Id to delete Customer");
//                int cid = int.Parse(Console.ReadLine());
//                DataRow dr = null;
//                for (int i = 0; i < dt.Rows.Count; i++)
//                {
//                    if ((int)dt.Rows[i]["Id"] == cid)
//                    {
//                        dr = dt.Rows[i];
//                        break;
//                    }
//                }
//                if (dr != null)
//                {
//                    dr.Delete();
//                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
//                    adapter.Update(ds);
//                    Console.WriteLine("Record Deleted!!!");
//                }
//                else
//                {
//                    Console.WriteLine("No such Record exist!!!");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.WriteLine("End of Program!!!");
//                Console.ReadKey();
//            }
//        }
//    }
//}


//update

using System;
using System.Data.SqlClient;
using System.Data;


namespace conAppDisconectedArch
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static DataSet ds;
        static string conString = "server=LAPTOP-DLI2FL88;database=Day7Db; trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conString);
                cmd = new SqlCommand("select * from Customer", con);
                adapter = new SqlDataAdapter(cmd);  //fetch the data from the table
                con.Open();
                ds = new DataSet();   //collection of tables  
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                Console.WriteLine("Enter Customer Id to Update Customer");
                int cid = int.Parse(Console.ReadLine());
                DataRow dr = null;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((int)dt.Rows[i]["Id"] == cid)
                    {
                        dr = dt.Rows[i];
                        break;
                    }
                }
                if (dr != null)
                {
                    Console.WriteLine("Enter New Name");
                    dr["Name"] = Console.ReadLine();
                    Console.WriteLine("Enter OD Limit");
                    dr["ODLimit"] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Subscription Start Date");
                    dr["SStartDate"] = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Subscription End Date");
                    dr["SEndDate"] = DateTime.Parse(Console.ReadLine());
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    Console.WriteLine("Record Updated!!!");
                }
                else
                {
                    Console.WriteLine("No such Record exist!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!!!");
                Console.ReadKey();
            }
        }
    }
}