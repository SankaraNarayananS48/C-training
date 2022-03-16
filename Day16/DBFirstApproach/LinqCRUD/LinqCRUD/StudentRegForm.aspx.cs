using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCRUD
{
    public partial class StudentRegForm : System.Web.UI.Page
    {
        studentEntities1 db = new studentEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentreg table = new studentreg();
            table.rollno = TextBox1.Text;
            table.name = TextBox2.Text;
            table.phoneno = TextBox3.Text;
            db.studentregs.Add(table);
            db.SaveChanges();
            Display();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            studentreg table1 = db.studentregs.FirstOrDefault(record=>record.rollno==TextBox1.Text);
            table1.name = TextBox2.Text;
            table1.phoneno = TextBox3.Text;
            db.SaveChanges();
            Display();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            studentreg table2 = db.studentregs.FirstOrDefault(record => record.rollno == TextBox1.Text);
            db.studentregs.Remove(table2);
            db.SaveChanges();
            Display();
        }
        public void Display()
        {
            GridView1.DataSource = db.studentregs.ToArray();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}