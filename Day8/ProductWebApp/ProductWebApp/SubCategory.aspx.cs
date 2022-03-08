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
    public partial class SubCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                        
                        cmd.Connection = conn;
                        cmd.CommandText = "delete_subcategory";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@subcatid", int.Parse(TextBox2.Text));
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
                        cmd.CommandText = "insert_subcategoryy";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@catid", int.Parse(TextBox1.Text));
                        cmd.Parameters.AddWithValue("@subcatid", int.Parse(TextBox2.Text));
                        cmd.Parameters.AddWithValue("@name", TextBox3.Text);
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
                        cmd.CommandText = "update_subcategory";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@catid", int.Parse(TextBox1.Text));
                        cmd.Parameters.AddWithValue("@subcatid", int.Parse(TextBox2.Text));
                        cmd.Parameters.AddWithValue("@subcatname", TextBox3.Text);
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
                                cmd.CommandText = "select_subcategory";
                                cmd.CommandType = CommandType.StoredProcedure;

                                da.SelectCommand = cmd;
                                da.Fill(ds, "subcategorytableread");

                                GridView1.DataSource = ds.Tables["subcategorytableread"];
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