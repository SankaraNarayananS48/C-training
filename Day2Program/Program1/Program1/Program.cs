class Person {
    public int age;
    public void Greet()
    {
        Console.WriteLine("Hello");
    }

    public void setAge(int age)
    {
        this.age = age;
    }
}
class Student:Person { 
    public void Study()
    {
        Console.WriteLine("I'm studying on the screen");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is:"+this.age+ "years old on the screen");
    }
}

class Professor:Person { 

    public void Explain()
    {
        Console.WriteLine("I'm explaining on the screen");
    }
}
class StudentProfessorTest {
    static void Main(string[] args) { 
        Person person = new Person();
        person.Greet();

        Console.WriteLine("Student Here");
        Student student = new Student();
        student.setAge(12);
        student.Greet();
        student.ShowAge();

        Console.WriteLine("Professor Here");
        Professor professor = new Professor();
        professor.setAge(27);
        professor.Greet();
        professor.Explain();

    }
}