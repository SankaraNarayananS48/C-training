using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication53
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AFEFCQAI\\SQLEXPRESS;Initial Catalog=extra;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    conn.Open();
                    cmd.CommandText = "insert into login values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // TextBox2.Text = DropDownList1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AFEFCQAI\\SQLEXPRESS;Initial Catalog=extra;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    conn.Open();
                    cmd.CommandText = "update  login set password='" + TextBox2.Text + "'where id='" + TextBox1.Text + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void disp()
        {

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AFEFCQAI\\SQLEXPRESS;Initial Catalog=extra;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataSet ds = new DataSet())
                        {
                            conn.Open();
                            cmd.CommandText = "select * from login";
                            cmd.Connection = conn;
                            da.SelectCommand = cmd;
                            da.Fill(ds, "temp");
                            conn.Close();

                            //for(int i =0;i<ds.Tables["temp"].Rows.Count;i++)
                            //{
                            //    DropDownList1.Items.Add(ds.Tables["temp"].Rows[i]["name"].ToString());
                            //}

                            GridView1.DataSource = ds.Tables["temp"];
                            GridView1.DataBind();


                        }
                    }
                }
                }
            }
        protected void Button3_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            disp();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            disp();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gw = GridView1.Rows[e.RowIndex];
            TextBox t1, t2, t3;
            t1=(TextBox)gw.FindControl("txt1");
            t2=(TextBox)gw.FindControl("txt2");
            t3=(TextBox)gw.FindControl("txt3");
            //update db code 

            GridView1.EditIndex = -1;
            disp();



        }
    }
}