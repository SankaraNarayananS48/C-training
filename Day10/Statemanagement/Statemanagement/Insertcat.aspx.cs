using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Statemanagement
{
    public partial class Insertcat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Inserting "+Session["catidinsert"].ToString()+" "+Session["catnameinsert"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int catid = int.Parse(Session["catidinsert"].ToString());
            String catname = Session["catnameinsert"].ToString();
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert_category";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", catid);
                        cmd.Parameters.AddWithValue("@name",catname);
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
            Response.Redirect("MainPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }
    }
}