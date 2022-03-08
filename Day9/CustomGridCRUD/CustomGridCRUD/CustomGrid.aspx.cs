using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CustomGridCRUD
{
    public partial class CustomGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            tabledisplay();
        }
        public void tabledisplay()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=student;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            conn.Open();
                            cmd.CommandText = "select_studreg";
                            cmd.Connection = conn;
                            da.SelectCommand = cmd;
                            da.Fill(ds, "studregtable");
                            conn.Close();
                            GridView1.DataSource = ds.Tables["studregtable"];
                            GridView1.DataBind();
                            conn.Close();
                        }
                    }
                }
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gw = GridView1.Rows[e.RowIndex];
            TextBox roll, name, phone;
            roll = (TextBox)gw.FindControl("rollnotbox");
            name = (TextBox)gw.FindControl("nametbox");
            phone = (TextBox)gw.FindControl("phonenotbox");
            Response.Write(roll.Text);
            Response.Write(name.Text);
            Response.Write(phone.Text);
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=student;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "update_studreg";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@rollno", roll.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@phoneno", phone.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        GridView1.EditIndex = -1;
                        tabledisplay();
                    }
                    catch(Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            tabledisplay();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            tabledisplay();
        }

       /* protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            

        }*/

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=student;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        GridViewRow gw = GridView1.Rows[e.RowIndex];
                        Label rollno;
                        rollno = (Label)gw.FindControl("rollnolabel");
                        Response.Write(rollno.Text);
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "delete_studreg";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@rollno", rollno.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        tabledisplay();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
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