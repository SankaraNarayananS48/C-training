using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Statemanagement
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome "+Session["Username"].ToString());
            if (!IsPostBack)
            tabledisplay();
        }

        public void tabledisplay()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            conn.Open();
                            cmd.CommandText = "select_category";
                            cmd.Connection = conn;
                            da.SelectCommand = cmd;
                            da.Fill(ds, "cattable");
                            conn.Close();
                            GridView1.DataSource = ds.Tables["cattable"];
                            GridView1.DataBind();
                            conn.Close();
                        }
                    }
                }
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            tabledisplay();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            tabledisplay();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gw = GridView1.Rows[e.RowIndex];
            TextBox catnamebox,catidbox;
            catnamebox = (TextBox)gw.FindControl("catnametbox");
            catidbox = (TextBox)gw.FindControl("catidtbox");
            Response.Write(catidbox.Text);
            Response.Write(catnamebox.Text);
            Session["catidupdate"] = catidbox.Text;
            Session["catnameupdate"] = catnamebox.Text;
            Response.Redirect("Updatecat.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String catid = TextBox1.Text;
            String catname = TextBox2.Text;
            Session["catidinsert"] = catid;
            Session["catnameinsert"] = catname;
            Response.Redirect("Insertcat.aspx");
            //Insert
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow gw = GridView1.Rows[e.RowIndex];
            Label catidlabel;
            catidlabel = (Label)gw.FindControl("catidlabel");
            Session["catiddelete"] = catidlabel.Text;
            Response.Redirect("Deletecat.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }
    }
}