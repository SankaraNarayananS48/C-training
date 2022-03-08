using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SQLOperations
{
    public partial class SQLForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=sqlweb;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert_userr";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@phoneno", TextBox3.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
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
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=sqlweb;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "update_user";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@phoneno", TextBox3.Text);
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
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=sqlweb;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "delete_user";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                        
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
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=sqlweb;Integrated Security=True"))
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
                                cmd.CommandText = "select_user";
                                cmd.CommandType = CommandType.StoredProcedure;
                                da.SelectCommand = cmd;
                                da.Fill(ds, "usertableread");
                                GridView1.DataSource = ds.Tables["usertableread"];
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}