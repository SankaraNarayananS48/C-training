using System.Data.SqlClient;
using System.Data;

class LoginApplication
{
    static void Main(String[] args)
    {

        SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        conn.Open();

        String username,password;
        int maxchance = 3,iter = 0,flag=0;

        while(iter <= maxchance)
        {
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();

            cmd.CommandText = "select password from studentlogin where id ='"+username+"'";
            cmd.Connection = conn;
            da1.SelectCommand = cmd;
            da1.Fill(ds1, "studentloginread");


            if (password == ds1.Tables["studentloginread"].Rows[0][0].ToString())
            {
                Console.WriteLine("Welcome " + username + " !");
                flag = 1;
                return;
            }
            else
            {
                Console.WriteLine("Invalid Username and Password Please try again!");
            }

            iter++;

        }
        if (flag == 0)
        {
            Console.WriteLine("Maximum try has reached try again!");
        }
    }
}