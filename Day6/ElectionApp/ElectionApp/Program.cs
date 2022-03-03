using System.Data.SqlClient;
using System.Data;

class ElectionApp
{
    static void Main(String[] args)
    {
        SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=votedatabase;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        conn.Open();

       
        Console.WriteLine("Welcome to Voting App!");
        Console.WriteLine(" ");
        Console.WriteLine("1-Insert Party");
        Console.WriteLine("2-Update Party");
        Console.WriteLine("3-Delete Party");
        Console.WriteLine("4-Insert City");
        Console.WriteLine("5-Update City");
        Console.WriteLine("6-Delete City");
        Console.WriteLine("7-Insert Nomination List");
        Console.WriteLine("8-Update Nomination List");
        Console.WriteLine("9-Delete Nomination List");
        Console.WriteLine("10-Printing Party List");
        Console.WriteLine("11-Printing City List");
        Console.WriteLine("12-Printing Nomination List");
        Console.WriteLine("13-Vote");
        Console.WriteLine("14-Report");
        Console.WriteLine("30-Exit");
        Console.WriteLine(" ");

 
        while (true)
        {
            Console.WriteLine("Enter your option:");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter party id:");
                    int partyidinsert = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party name:");
                    String partynameinsert = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert_party";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", partyidinsert);
                    cmd.Parameters.AddWithValue("@name", partynameinsert);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Console.WriteLine("Inserted successfully in party table!!");
                    Console.WriteLine(" ");
                    break;

                case 2:
                    Console.WriteLine("Enter party id to update:");
                    int partyidupdate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party name:");
                    String partynameupdate = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "update_party";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", partyidupdate);
                    cmd.Parameters.AddWithValue("@name", partynameupdate);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Console.WriteLine("Updated successfully in party table!!");
                    Console.WriteLine(" ");
                    break;

                case 3:
                    Console.WriteLine("Enter party id to delete:");
                    int partyiddelete = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party name:");
                    String partynamedelete = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete_party";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", partyiddelete);
                    cmd.Parameters.AddWithValue("@name", partynamedelete);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 4:
                    Console.WriteLine("Enter city id:");
                    int cityidinsert = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter city name:");
                    String citynameinsert = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert_city";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", cityidinsert);
                    cmd.Parameters.AddWithValue("@name", citynameinsert);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted successfully in city table!!");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 5:
                    Console.WriteLine("Enter city id to update:");
                    int cityidupdate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter city name:");
                    String citynameupdate = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "update_city";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", cityidupdate);
                    cmd.Parameters.AddWithValue("@name", citynameupdate);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated successfully in city table!!");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 6:
                    Console.WriteLine("Enter city id to delete:");
                    int cityiddelete = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter city name:");
                    String citynamedelete = Console.ReadLine();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete_city";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", cityiddelete);
                    cmd.Parameters.AddWithValue("@name", citynamedelete);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted successfully in city table!!");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 30:
                    Console.WriteLine("Thank You Bye!"); 
                    return;

                case 7:
                    Console.WriteLine("Welcome to Nomination List Insertion!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter city id:");
                    int cityidinsertnominate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party id:");
                    int partyidinsertnominate = int.Parse(Console.ReadLine());
                    cmd.Connection = conn;
                    cmd.CommandText = "insert_nominationlistt";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cityid", cityidinsertnominate);
                    cmd.Parameters.AddWithValue("@partyid", partyidinsertnominate);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted successfully in nominationlist table!!");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 8:
                    Console.WriteLine("Welcome to Nomination List Updation!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter city id to update:");
                    int cityidupdatenominate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party id:");
                    int partyidupdatenominate = int.Parse(Console.ReadLine());
                    cmd.Connection = conn;
                    cmd.CommandText = "update_nominationlist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cityid", cityidupdatenominate);
                    cmd.Parameters.AddWithValue("@partyid", partyidupdatenominate);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated successfully in nominationlist table!!");
                    Console.WriteLine(" ");
                    cmd.Parameters.Clear();
                    break;

                case 9:
                    Console.WriteLine("Welcome to Nomination List Deletion!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter citty id to delete:");
                    int cityiddeletenominate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter party id:");
                    int partyiddeletenominate = int.Parse(Console.ReadLine());
                    cmd.Connection = conn;
                    cmd.CommandText = "delete_nominationlist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cityid", cityiddeletenominate);
                    cmd.Parameters.AddWithValue("@partyid", partyiddeletenominate);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted successfully in nominationlist table!!");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    break;

                case 10:
                    Console.WriteLine("Printing Political Party List");
                    Console.WriteLine(" ");
                    cmd.Connection = conn;
                    cmd.CommandText = "select_party";
                    cmd.CommandType= CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "partytableread");
                    Console.WriteLine("Partyid  PartyName");
                    Console.WriteLine(" ");
                    for (int i = 0; i < ds.Tables["partytableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["partytableread"].Rows[i][0].ToString() +
                            " " + ds.Tables["partytableread"].Rows[i][1].ToString());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 11:
                    Console.WriteLine("Printing City List");
                    Console.WriteLine(" ");
                    cmd.Connection = conn;
                    cmd.CommandText = "select_city";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "citytableread");
                    Console.WriteLine("Cityid  CityName");
                    Console.WriteLine(" ");
                    for (int i = 0; i < ds.Tables["citytableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["citytableread"].Rows[i][0].ToString() +
                            " " + ds.Tables["citytableread"].Rows[i][1].ToString());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 12:
                    Console.WriteLine("Printing Nomination List");
                    Console.WriteLine(" ");
                    cmd.Connection = conn;
                    cmd.CommandText = "select_nominationlist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "nominationtableread");
                    Console.WriteLine("Cityid  Partyid");
                    for (int i = 0; i < ds.Tables["nominationtableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["nominationtableread"].Rows[i][0].ToString() +
                            " " + ds.Tables["nominationtableread"].Rows[i][1].ToString());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 13:
                    Console.WriteLine("Welcome to Vote:");
                    Console.WriteLine("Printing City List");
                    Console.WriteLine(" ");
                    int count=0;
                    cmd.Connection = conn;
                    cmd.CommandText = "select_city";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "citytableread");
                    Console.WriteLine("Cityid  CityName");
                    for (int i = 0; i < ds.Tables["citytableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["citytableread"].Rows[i][0].ToString() +
                            " " + ds.Tables["citytableread"].Rows[i][1].ToString());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Please Enter your City id:");
                    int cityid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your City's Nominated Parties:");
                    Console.WriteLine(" ");
                    cmd.CommandText = "select_nominatedparty";
                    cmd.Parameters.AddWithValue("@cityid", cityid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "selectedtableread");
                    cmd.Parameters.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("Partyid PartyName");
                    Console.WriteLine(" ");
                    
                    
                    
                    for (int i = 0; i < ds.Tables["selectedtableread"].Rows.Count; i++)
                    {
                        int partyid=int.Parse(ds.Tables["selectedtableread"].Rows[i][0].ToString());
                        cmd.CommandText = "select_partynamee";
                        cmd.Parameters.AddWithValue("@partyid", partyid);
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        da.Fill(ds, "selectedpartytableread");
                        String partyname = ds.Tables["selectedpartytableread"].Rows[i][0].ToString();
                        cmd.Parameters.Clear();
                        Console.WriteLine(partyid +" "+partyname);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter Partyid to vote:");
                    int votedpartyid = int.Parse(Console.ReadLine());
                    cmd.Connection = conn;
                    cmd.CommandText = "get_votecounnt";
                    cmd.Parameters.AddWithValue("@cityid", cityid);
                    cmd.Parameters.AddWithValue("@partyid", votedpartyid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "counttableread");
                    cmd.Parameters.Clear();
                    try
                    {
                        
                        count = int.Parse(ds.Tables["counttableread"].Rows[0][0].ToString());
                        count++;
                        Console.WriteLine(" voted");
                        cmd.Connection = conn;
                        cmd.CommandText = "update_vote";
                        
                    }
                    catch
                    {
                        count = 1;
                        
                        cmd.CommandText = "insert_vote";
                        
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cityid", cityid);
                    cmd.Parameters.AddWithValue("@partyid", votedpartyid);
                    cmd.Parameters.AddWithValue("@countofvote", count);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    Console.WriteLine("Voted successfully!!");
                    Console.WriteLine(" ");
                    return;
                case 14:
                    Console.WriteLine("Printing Report");
                    cmd.Connection = conn;
                    cmd.CommandText = "finalreport";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(ds, "reporttableread");
                    Console.WriteLine("CityName            PartyName      VoteCount");
                    for (int i = 0; i < ds.Tables["reporttableread"].Rows.Count; i++)
                    {
                        Console.Write(ds.Tables["reporttableread"].Rows[i][0].ToString() +
                            "            " + ds.Tables["reporttableread"].Rows[i][1].ToString()+
                            "        " + ds.Tables["reporttableread"].Rows[i][2].ToString());
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    break;

            }
            //return;
        }
    }
}