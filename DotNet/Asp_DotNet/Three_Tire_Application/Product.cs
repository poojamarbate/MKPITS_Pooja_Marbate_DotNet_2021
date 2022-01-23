using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace Three_Tire_Application
{
    public class Product
    {
        public int Proid { get; set; }
        public string Proname { get; set; }
        public decimal ProPrice { get; set; }
        public SqlConnection con;
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter da;
        
        public DataSet GetProduct()
        {
            
            Myconnection m = new Myconnection();
            con = m.GetConnection();
            comm = new SqlCommand("Select ID,Productname,Price from Grocery_Product");
            comm.Connection = con;
            ds = new DataSet();

            
            da = new SqlDataAdapter(comm);
            da.Fill(ds);
            return ds;

        }
        public int AddProduct()
        {
            Myconnection m = new Myconnection();
            con = m.GetConnection();
            comm = new SqlCommand();
            comm.CommandText= "insert into Grocery_Product(Productname,Price)values(@Productname,@Price)";
            SqlParameter p1 = new SqlParameter("@Productname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@Price", SqlDbType.Decimal);
            p1.Value = Proname;
            p2.Value = ProPrice;
            comm.Parameters.Add(p1);
            comm.Parameters.Add(p2);
            comm.Connection = con;
            con.Open();
            int result = comm.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public DataSet GetProducts()
        {
            Myconnection m = new Myconnection();
            con = m.GetConnection();
            da = new SqlDataAdapter("select ID,Productname from Grocery_Product",con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int UpdateProduct(int id)
        {
            Myconnection m = new Myconnection();
            con = m.GetConnection();
            comm = new SqlCommand();
            comm.CommandText = "Update Grocery_Product set Productname=@Productname,Price=@Price where ID=@Id";
            SqlParameter p1 = new SqlParameter("@Productname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@Price", SqlDbType.Decimal);
            SqlParameter p3 = new SqlParameter("@Id", SqlDbType.Int);
            p1.Value = Proname;
            p2.Value = ProPrice;
            p3.Value = id;
            comm.Parameters.Add(p1);
            comm.Parameters.Add(p2);
            comm.Parameters.Add(p3);
            comm.Connection = con;
            con.Open();
            int result = comm.ExecuteNonQuery();//use to execute query
            con.Close();
            return result;
        }

    }
}