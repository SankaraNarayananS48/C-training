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
    public partial class LoginForm : System.Web.UI.Page
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
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            try
                            {
                                conn.Open();
                                cmd.Connection = conn;
                                cmd.CommandText = "select_pass";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                                da.SelectCommand = cmd;
                                da.Fill(ds, "passtableread");
                                if (ds.Tables["passtableread"].Rows[0][0].ToString() == TextBox2.Text)
                                {
                                    Response.Redirect("Display.aspx");
                                }
                                
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