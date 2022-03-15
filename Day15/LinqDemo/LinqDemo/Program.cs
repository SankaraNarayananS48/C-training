using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            studentregDataContext db = new studentregDataContext();

            Console.WriteLine("Welcome to Student Registration Console app");
            Console.WriteLine("1-Insert 2-Update 3-Delete 4-Display 5-Exit");
            while (true)
            {
                Console.WriteLine("Enter your Choice:");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        studentreg studtable = new studentreg();
                        Console.WriteLine("Insert Student Record");
                        Console.WriteLine("Enter student id");
                        studtable.rollno = Console.ReadLine();
                        Console.WriteLine("Enter student name");
                        studtable.name = Console.ReadLine();
                        Console.WriteLine("Enter student phoneno");
                        studtable.phoneno = Console.ReadLine();
                        db.studentregs.InsertOnSubmit(studtable);
                        db.SubmitChanges();
                        break;
                    case 2:

                        Console.WriteLine("Update Student Record");
                        Console.WriteLine("Enter student id");
                        studentreg studtable1 = db.studentregs.SingleOrDefault(record => record.rollno == Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        studtable1.name = Console.ReadLine();
                        Console.WriteLine("Enter student phoneno");
                        studtable1.phoneno = Console.ReadLine();
                        db.SubmitChanges();
                        break;
                    case 3:
                        studentreg studtable2 = new studentreg();
                        Console.WriteLine("Delete Student Record");
                        Console.WriteLine("Enter student id");
                        studentreg studtable3 = db.studentregs.SingleOrDefault(record => record.rollno == Console.ReadLine());
                        db.studentregs.DeleteOnSubmit(studtable3);
                        db.SubmitChanges();
                        break;
                    case 4:
                        var result=db.studentregs.ToList();
                        Console.WriteLine("Displaying Student records");
                        foreach(var record in result)
                        {
                            Console.WriteLine(record.rollno+" "+record.name+" "+record.phoneno);
                        }

                        break;
                    case 5:return;
                }

            }
        }
    }
}
