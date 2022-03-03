using System.Data.SqlClient;
using System.Data;

class sqlconnection
{
    static void Main(String[] args)
    {
        SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        conn.Open();

        Console.WriteLine("Press 1 - Insert student details ,2 to Update student details, 3 - Delete student details, 4-Display student record  5-insert mark");
        Console.WriteLine("6-Update mark 7-Delete mark 8-Display mark list 9-Display Complete list 10-Exit");
        while (true)
        {
            Console.WriteLine("Enter your option:");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter rollno:");
                    String id = Console.ReadLine();
                    Console.WriteLine("Enter Name:");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter phoneno:");
                    String phoneno = Console.ReadLine();
                    cmd.CommandText = "insert into studreg values(" + id + ",'" + name + "','" + phoneno + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted successfully into student table!!");
                    break;
                case 2:
                    Console.WriteLine("Enter rollno to update:");
                    String idupdate = Console.ReadLine();
                    Console.WriteLine("Enter Name to update:");
                    String nameupdate = Console.ReadLine();
                    Console.WriteLine("Enter phoneno:");
                    String phonenoupdate = Console.ReadLine();
                    cmd.CommandText = "update studreg set name='" + nameupdate + "',phoneno='"+phonenoupdate+"' where rollno ='" + idupdate + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated   student table successfully!!");
                    break;

                case 3:
                    Console.WriteLine("Enter rollno:");
                    int iddelete = int.Parse(Console.ReadLine());
                    cmd.CommandText = "delete from studreg  where rollno ='" + iddelete + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted successfully in student table!!");
                    break;
                case 4:
                    cmd.CommandText = "select * from studreg;";
                    cmd.Connection = conn;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "studtableread");
                    Console.WriteLine("RollNo    Name      phoneno");
                    for(int i = 0; i < ds.Tables["studtableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["studtableread"].Rows[i][0].ToString()+"   "+ds.Tables["studtableread"].Rows[i][1].ToString()+"   "+ds.Tables["studtableread"].Rows[i][2].ToString());
                        Console.WriteLine(" ");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter rollno:");
                    String markid = Console.ReadLine();
                    Console.WriteLine("Enter mark1:");
                    int m1insert = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter mark2:");
                    int m2insert = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter mark3:");
                    int m3insert = int.Parse(Console.ReadLine());
                    cmd.CommandText = "insert into marktable values(" + markid + ",'" + m1insert + "','" + m2insert + "','" + m3insert + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted successfully into mark table!!");
                    break;
                case 6:
                    Console.WriteLine("Enter rollno:");
                    String markupdate = Console.ReadLine();
                    Console.WriteLine("Enter mark1:");
                    int m1update = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter mark2:");
                    int m2update = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter mark3:");
                    int m3update = int.Parse(Console.ReadLine());
                    cmd.CommandText = "update marktable set mark1='" + m1update + "',mark2='" + m2update + "',mark3='" + m3update + "' where rollno ='" + markupdate + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated successfully into mark table!!");
                    break;
                case 7:
                    Console.WriteLine("Enter rollno to delete marks:");
                    int rolldelete = int.Parse(Console.ReadLine());
                    cmd.CommandText = "delete from marktable  where rollno ='" + rolldelete + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted successfully in marktable !!");
                    break;
                case 8:
                    cmd.CommandText = "select * from marktable;";
                    cmd.Connection = conn;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "studmarktableread");
                    Console.WriteLine("RollNo    Mark1    Mark2  Mark3");
                    for (int i = 0; i < ds.Tables["studmarktableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["studmarktableread"].Rows[i][0].ToString() + "   " + ds.Tables["studmarktableread"].Rows[i][1].ToString() + "   " + ds.Tables["studmarktableread"].Rows[i][2].ToString() + "   " + ds.Tables["studmarktableread"].Rows[i][3].ToString());
                        Console.WriteLine(" ");
                    }
                    break;
                case 9:
                    cmd.CommandText = "select st.rollno,st.name,mk.mark1,mk.mark2,mk.mark3 from studreg st JOIN marktable  mk on st.rollno = mk.rollno;";
                    cmd.Connection = conn;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "fullstudtableread");
                    Console.WriteLine("RollNo    Name    Mark1  Mark2   Mark3");
                    for (int i = 0; i < ds.Tables["fullstudtableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["fullstudtableread"].Rows[i][0].ToString() + 
                            "   " + ds.Tables["fullstudtableread"].Rows[i][1].ToString() +
                            "   " + ds.Tables["fullstudtableread"].Rows[i][2].ToString() +
                            "   " + ds.Tables["fullstudtableread"].Rows[i][3].ToString() +
                            "   " + ds.Tables["fullstudtableread"].Rows[i][4].ToString());
                        Console.WriteLine(" ");
                    }
                    break;
                case 10:
                    cmd.CommandText = "select st.rollno,st.name,ISNULL(mk.mark1,0),ISNULL(mk.mark2,0),ISNULL(mk.mark3,0) from studreg st LEFT JOIN marktable  mk on st.rollno = mk.rollno;";
                    cmd.Connection = conn;
                    da.SelectCommand = cmd;
                    int total = 0;
                    da.Fill(ds, "fullleftstudtableread");
                    Console.WriteLine("RollNo    Name         Mark1    Mark2     Mark3     Total");
                  /* for (int i = 0; i < ds.Tables["fullleftstudtableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["fullleftstudtableread"].Rows[i][0].ToString() +
                          "   " + ds.Tables["fullleftstudtableread"].Rows[i][1].ToString() +
                           "   ");
                        if (int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][2].ToString())>=0 && int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][2].ToString())<=100)
                             Console.Write(ds.Tables["fullleftstudtableread"].Rows[i][2].ToString());
                        else
                            Console.Write("0" + " ");
                        Console.Write(" ");
                        if (int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][3].ToString()) >= 0 && int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][3].ToString()) <= 100)
                            Console.Write(ds.Tables["fullleftstudtableread"].Rows[i][3].ToString());
                        else
                            Console.Write("0" + " ");
                        Console.Write(" ");
                        if (int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][4].ToString()) >= 0 && int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][4].ToString()) <= 100)
                            Console.Write(ds.Tables["fullleftstudtableread"].Rows[i][4].ToString());
                        else
                            Console.Write("0" + " ");
                        Console.WriteLine(" ");
                        try
                        {
                            int m1 = int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][2].ToString());
                            Console.Write(m1+" ");
                            total += m1;
                        }
                        catch 
                        {
                            Console.Write("0" + " ");
                        }
                        try
                        {
                            int m2 = int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][3].ToString());
                            Console.Write(m2+" ");
                            total += m2;
                        }
                        catch
                        {
                            Console.Write("0" + " ");
                        }
                        try
                        {
                            int m3 = int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][4].ToString());
                            Console.Write(m3+" ");
                            total += m3;
                        }
                        catch
                        {
                            Console.Write("0" + " ");
                        }
                        Console.Write(" "+total);
                        Console.WriteLine(" ");*/
                        for (int i = 0; i < ds.Tables["fullleftstudtableread"].Rows.Count; i++)
                        {
                            Console.Write(ds.Tables["fullleftstudtableread"].Rows[i][0].ToString() +
                                "        " + ds.Tables["fullleftstudtableread"].Rows[i][1].ToString() +
                                "        " + ds.Tables["fullleftstudtableread"].Rows[i][2].ToString() +
                                "        " + ds.Tables["fullleftstudtableread"].Rows[i][3].ToString() +
                                "        " + ds.Tables["fullleftstudtableread"].Rows[i][4].ToString());
                            total = int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][2].ToString()) + int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][3].ToString()) + int.Parse(ds.Tables["fullleftstudtableread"].Rows[i][4].ToString());
                            Console.Write("      "+total);
                            total = 0;
                            Console.WriteLine(" ");
                        }
                        
                    
                    break;
                case 11:
                    cmd.CommandText = "select st.rollno,st.name,mk.mark1,mk.mark2,mk.mark3 from studreg st JOIN marktable  mk on st.rollno = mk.rollno;";
                    cmd.Connection = conn;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "fulltotalstudtableread");
                    Console.WriteLine("RollNo    Name    Mark1  Mark2   Mark3  Total");
                    for (int i = 0; i < ds.Tables["fulltotalstudtableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["fulltotalstudtableread"].Rows[i][0].ToString() + 
                            "   " + ds.Tables["fulltotalstudtableread"].Rows[i][1].ToString() + 
                            "   " + ds.Tables["fulltotalstudtableread"].Rows[i][2].ToString() +
                            "   " + ds.Tables["fulltotalstudtableread"].Rows[i][3].ToString() +
                            "   " + ds.Tables["fulltotalstudtableread"].Rows[i][4].ToString());
                         total = int.Parse(ds.Tables["fulltotalstudtableread"].Rows[i][2].ToString()) + int.Parse(ds.Tables["fulltotalstudtableread"].Rows[i][3].ToString()) + int.Parse(ds.Tables["fulltotalstudtableread"].Rows[i][4].ToString());
                        //Console.Write(" "+total);
                        Console.WriteLine(" ");
                    }
                    break;
                case 12:
                    conn.Close();
                    Console.WriteLine("Bye!!");
                    return;
            }
        }


    }
}