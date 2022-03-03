class Person
{
    public String name;

    public Person(String name)
    {
        this.name = name;
    }
}
class Student : Person
{
    public Student(String name):base(name)
    {

    }
    public void Study()
    {
        Console.WriteLine(this.name+" "+"Student is Studying!!");
    }
}

class Teacher : Person
{
    public Teacher(String name):base(name) { }
    public void Explain()
    {
        Console.WriteLine(this.name+" "+"Teacher is Explaining!!");
    }
}

class TestClass
{
    static void Main(String[] args)
    {
        /*Student student1 = new Student("ABC");
        Student student2 = new Student("DEF");

        Teacher teacher1 = new Teacher("GHI");

        student1.Study();
        student2.Study();

        teacher1.Explain();*/

        
         Person[] personarray = new Person[3];
         personarray[0] = new Student("ABC");
         personarray[1] =new Student("DEF");
         personarray[2] = new Teacher("GHI");

       ( (Student) personarray[0]).Study();
       ((Student) personarray[1]).Study();
       ((Teacher) personarray[2]).Explain();
         
         
    }
}