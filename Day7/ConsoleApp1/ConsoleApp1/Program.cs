using System.Data.SqlClient;
using System.Data;
class Product
{
    static int[] ascendingordersort(int[] arr)
    {
       int temp = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }
    static int[] removeduplicate(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int iter = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {

            if (arr[i] != arr[i + 1])
            {
                temp[iter++] = arr[i];
            }
        }

        temp[iter++] = arr[arr.Length - 1];

        
        return temp;
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Product App!");
        Console.WriteLine(" ");
        Console.WriteLine("1-Insert Category");
        Console.WriteLine("2-Insert Sub-Category");
        Console.WriteLine("3-Insert Product");
        Console.WriteLine("4-Update Category");
        Console.WriteLine("5-Update SubCategory");
        Console.WriteLine("6-Update Product");
        Console.WriteLine("7-Delete Category");
        Console.WriteLine("8-Delete SubCategory");
        Console.WriteLine("9-Delete Product");
        Console.WriteLine("10-Printing Category List");
        Console.WriteLine("11-Printing SubCategory List");
        Console.WriteLine("12-Printing Product List");
        Console.WriteLine("13-Report");
        Console.WriteLine(" ");

        while (true)
        {
            Console.WriteLine("Enter your option:");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    using(SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter category id:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter category name:");
                                String catnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "insert_category";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", catidinsert);
                                cmd.Parameters.AddWithValue("@name", catnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Inserted successfully in category table!!");
                                Console.WriteLine(" ");
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
                    
                    break;
                case 2:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter category id:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory id:");
                                int subcatidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory name:");
                                String subcatnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "insert_subcategoryy";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catidinsert);
                                cmd.Parameters.AddWithValue("@subcatid", subcatidinsert);
                                cmd.Parameters.AddWithValue("@name", subcatnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Inserted successfully in subcategory table!!");
                                Console.WriteLine(" ");
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

                    break;
                case 3:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter category id:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory id:");
                                int subcatidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product id:");
                                int productidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product name:");
                                String prodnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "insert_product";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catidinsert);
                                cmd.Parameters.AddWithValue("@subcat", subcatidinsert);
                                cmd.Parameters.AddWithValue("@prodid", productidinsert);
                                cmd.Parameters.AddWithValue("@prodname", prodnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Inserted successfully in product table!!");
                                Console.WriteLine(" ");
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

                    break;
                case 4:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter category id to update:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter category name to update:");
                                String catnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "update_category";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catidinsert);
                                cmd.Parameters.AddWithValue("@catname", catnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Updated successfully in category table!!");
                                Console.WriteLine(" ");
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

                    break;
                case 5:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Updating With SubCategory id");
                                Console.WriteLine("Enter category id:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory id:");
                                int subcatidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory name:");
                                String subcatnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "update_subcategory";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catidinsert);
                                cmd.Parameters.AddWithValue("@subcatid", subcatidinsert);
                                cmd.Parameters.AddWithValue("@subcatname", subcatnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Updated successfully in subcategory table!!");
                                Console.WriteLine(" ");
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

                    break;
                case 6:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Updating with product id:");
                                Console.WriteLine("Enter category id:");
                                int catidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter subcategory id:");
                                int subcatidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product id:");
                                int productidinsert = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product name:");
                                String prodnameinsert = Console.ReadLine();
                                cmd.Connection = conn;
                                cmd.CommandText = "update_product";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catidinsert);
                                cmd.Parameters.AddWithValue("@subcatid", subcatidinsert);
                                cmd.Parameters.AddWithValue("@prodid", productidinsert);
                                cmd.Parameters.AddWithValue("@prodname", prodnameinsert);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Updated successfully in product table!!");
                                Console.WriteLine(" ");
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

                    break;
                case 7:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter category id to delete:");
                                int catiddelete = int.Parse(Console.ReadLine());
                                cmd.Connection = conn;
                                cmd.CommandText = "delete_category";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@catid", catiddelete);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Deleted successfully in category table!!");
                                Console.WriteLine(" ");
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
                    break;
                case 8:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter subcategory id to delete:");
                                int subcatiddelete = int.Parse(Console.ReadLine());
                                cmd.Connection = conn;
                                cmd.CommandText = "delete_subcategory";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@subcatid", subcatiddelete);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Deleted successfully in subcategory table!!");
                                Console.WriteLine(" ");
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
                    break;
                case 9:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            try
                            {
                                conn.Open();
                                Console.WriteLine("Enter product id to delete:");
                                int prodiddelete = int.Parse(Console.ReadLine());
                                cmd.Connection = conn;
                                cmd.CommandText = "delete_product";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@prodid", prodiddelete);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                Console.WriteLine("Deleted successfully in product table!!");
                                Console.WriteLine(" ");
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
                    break;
                case 10:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            { 
                                DataSet ds = new DataSet();
                                try
                                {
                                    conn.Open();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "select_category";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    Console.WriteLine("Printing Category table!!");
                                    Console.WriteLine(" ");
                                    da.SelectCommand = cmd;
                                    da.Fill(ds, "categorytableread");
                                    Console.WriteLine("Categoryid  CategoryName");
                                    Console.WriteLine(" ");
                                    for (int i = 0; i < ds.Tables["Categorytableread"].Rows.Count; i++)
                                    {
                                        Console.Write(ds.Tables["Categorytableread"].Rows[i][0].ToString() +
                                            " " + ds.Tables["Categorytableread"].Rows[i][1].ToString());
                                        Console.WriteLine(" ");
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
                    break;
                case 11:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                DataSet ds = new DataSet();
                                try
                                {
                                    conn.Open();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "select_subcategory";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    Console.WriteLine("Printing SubCategory table!!");
                                    Console.WriteLine(" ");
                                    da.SelectCommand = cmd;
                                    da.Fill(ds, "subcategorytableread");
                                    Console.WriteLine("Categoryid  SubCategoryid  SubCategoryName");
                                    Console.WriteLine(" ");
                                    for (int i = 0; i < ds.Tables["SubCategorytableread"].Rows.Count; i++)
                                    {
                                        Console.Write(ds.Tables["SubCategorytableread"].Rows[i][0].ToString() +
                                            " " + ds.Tables["SubCategorytableread"].Rows[i][1].ToString()+
                                            " " + ds.Tables["SubCategorytableread"].Rows[i][2].ToString());
                                        Console.WriteLine(" ");
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
                    break;
                case 12:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                DataSet ds = new DataSet();
                                try
                                {
                                    conn.Open();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "select_product";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    Console.WriteLine("Printing Product table!!");
                                    Console.WriteLine(" ");
                                    da.SelectCommand = cmd;
                                    da.Fill(ds, "producttableread");
                                    Console.WriteLine("Categoryid  SubCategoryid Productid ProductName");
                                    Console.WriteLine(" ");
                                    for (int i = 0; i < ds.Tables["producttableread"].Rows.Count; i++)
                                    {
                                        Console.Write(ds.Tables["producttableread"].Rows[i][0].ToString() +
                                            " " + ds.Tables["producttableread"].Rows[i][1].ToString() +
                                            " " + ds.Tables["producttableread"].Rows[i][2].ToString() +
                                            " " + ds.Tables["producttableread"].Rows[i][3].ToString());
                                         Console.WriteLine(" ");
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
                    break;
                case 13:
                    using (SqlConnection conn = new SqlConnection("Data Source=XCT1087;Initial Catalog=productdatabase;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter())
                            {
                                DataSet ds = new DataSet();
                                try
                                {
                                    int reportiter = 0;
                                    conn.Open();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "select_product";
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    da.SelectCommand = cmd;
                                    da.Fill(ds, "producttablesortread");
                                    int[] catid = new int[ds.Tables["producttablesortread"].Rows.Count];
                                    int[] subcatid = new int[ds.Tables["producttablesortread"].Rows.Count];
                                    int[] prodid = new int[ds.Tables["producttablesortread"].Rows.Count];
                                    String[] prodname = new String[ds.Tables["producttablesortread"].Rows.Count];
                                    for (int j = 0; j < ds.Tables["producttablesortread"].Columns.Count; j++)
                                    {
                                        for(int i = 0; i < ds.Tables["producttablesortread"].Rows.Count; i++)
                                        {

                                            if (j == 0)
                                            {
                                                catid[i] = int.Parse(ds.Tables["producttablesortread"].Rows[i][j].ToString());
                                            }
                                            else if (j == 1)
                                            {
                                                subcatid[i] = int.Parse(ds.Tables["producttablesortread"].Rows[i][j].ToString());
                                            }
                                            else if (j == 2)
                                            {
                                                prodid[i] = int.Parse(ds.Tables["producttablesortread"].Rows[i][j].ToString());
                                            }
                                            else if (j == 3)
                                            {
                                                prodname[i] = ds.Tables["producttablesortread"].Rows[i][j].ToString();
                                            }
                                        }

                                    }
                                    catid = ascendingordersort(catid);
                                    subcatid = ascendingordersort(subcatid);
                                    prodid = ascendingordersort(prodid);


                                    catid = removeduplicate(catid);
                                    subcatid = removeduplicate(subcatid);
                                    prodid = removeduplicate(prodid);

                                    /*for(int i = 0; i < catid.Length; i++) { Console.Write(catid[i]+" "); }
                                    Console.WriteLine(" ");
                                    for (int j = 0; j < subcatid.Length; j++) { Console.Write(subcatid[j] + " "); }
                                    Console.WriteLine(" ");
                                    for (int k = 0; k < prodid.Length; k++) { Console.Write(prodid[k] + " "); }*/

                                    Console.Write("Printing Report");
                                    Console.WriteLine(" ");
                                    for(int i = 0; i < catid.Length; i++)
                                    {
        
                                        for(int j = 0; j < subcatid.Length; j++)
                                        {
                                            
                                            for (int k=0;k<prodid.Length; k++)
                                            {
                                                
                                                for (int l=0; l<ds.Tables["producttablesortread"].Rows.Count; l++)
                                                {
                                                    int tabcatid = int.Parse(ds.Tables["producttablesortread"].Rows[l][0].ToString());
                                                    int tabsubcatid = int.Parse(ds.Tables["producttablesortread"].Rows[l][1].ToString());
                                                    int tabprodid = int.Parse(ds.Tables["producttablesortread"].Rows[l][2].ToString());
                                                    String tabprodname = ds.Tables["producttablesortread"].Rows[l][3].ToString();
                                                    if (tabcatid == catid[i] && tabsubcatid == subcatid[j] && tabprodid == prodid[k])
                                                    {
                                                        Console.WriteLine(catid[i] + " " + subcatid[j] + " " + prodid[k]+ " " + tabprodname);
                                                        cmd.CommandText = "finalreport";
                                                        cmd.CommandType = CommandType.StoredProcedure;
                                                        cmd.Parameters.AddWithValue("@catid", catid[i]);
                                                        cmd.Parameters.AddWithValue("@subcatid", subcatid[j]);
                                                        da.SelectCommand = cmd;
                                                        da.Fill(ds, "reporttablesortread");
                                                        cmd.Parameters.Clear();
                                                        //ds.Tables["producttablesortread"].Rows[i][j].ToString();
                                                       /* Console.WriteLine(ds.Tables["reporttablesortread"].Rows[reportiter][0].ToString() 
                                                            + " "+ ds.Tables["reporttablesortread"].Rows[reportiter][1].ToString()
                                                            + " "+prodid[k]+" "+tabprodname);
                                                        reportiter++;*/
                                                        break;
                                                        
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int m = 0; m < ds.Tables["reporttablesortread"].Rows.Count; m++)
                                    {
                                        Console.Write(ds.Tables["reporttablesortread"].Rows[m][0].ToString()
                                                            + " " + ds.Tables["reporttablesortread"].Rows[m][1].ToString());
                                        Console.WriteLine(" ");
                                    }

                                }
                                catch(Exception ex)
                                {
                                    
                                    Console.WriteLine(ex);
                                }
                                finally
                                {
                                    
                                    conn.Close();
                                }
                            }
                        }
                    }
                    break;


                
                case 30:
                    Console.WriteLine("Thank You Bye!");
                    return;


            }
        }
    }
}
