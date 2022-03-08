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
    public partial class Report : System.Web.UI.Page
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
                                cmd.CommandText = "final";
                                cmd.CommandType = CommandType.StoredProcedure;

                                da.SelectCommand = cmd;
                                da.Fill(ds, "reporttableread");

                                GridView1.DataSource = ds.Tables["reporttableread"];
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