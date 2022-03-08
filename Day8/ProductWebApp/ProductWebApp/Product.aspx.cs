using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProductWebApp
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();

                        cmd.Connection = conn;
                        cmd.CommandText = "insert_product";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@catid", int.Parse(TextBox1.Text));
                        cmd.Parameters.AddWithValue("@subcat",int.Parse( TextBox2.Text));
                        cmd.Parameters.AddWithValue("@prodid",int.Parse( TextBox3.Text));
                        cmd.Parameters.AddWithValue("@prodname", TextBox4.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        
                        cmd.Connection = conn;
                        cmd.CommandText = "update_product";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@catid", int.Parse(TextBox1.Text));
                        cmd.Parameters.AddWithValue("@subcatid", int.Parse(TextBox2.Text));
                        cmd.Parameters.AddWithValue("@prodid", int.Parse(TextBox3.Text));
                        cmd.Parameters.AddWithValue("@prodname", TextBox4.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Enter product id to delete:");
                        int prodiddelete = int.Parse(Console.ReadLine());
                        cmd.Connection = conn;
                        cmd.CommandText = "delete_product";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prodid", int.Parse(TextBox1.Text));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        Console.WriteLine("Deleted successfully in product table!!");
                        Console.WriteLine(" ");
                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {

                            try
                            {
                                conn.Open();
                                cmd.Connection = conn;
                                cmd.CommandText = "select_product";
                                cmd.CommandType = CommandType.StoredProcedure;

                                da.SelectCommand = cmd;
                                da.Fill(ds, "categorytableread");

                                GridView1.DataSource = ds.Tables["categorytableread"];
                                GridView1.DataBind();
                            }
                            catch
                            {

                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}