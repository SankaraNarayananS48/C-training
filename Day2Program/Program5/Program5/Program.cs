abstract class Animal
{
    String name;
    public abstract void Eat();
    public void setName(String name)
    {
        this.name = name;
    }
    public String getName() 
    { 
        return name; 
    }
}
class Dog : Animal
{
    public override void Eat() {
        Console.WriteLine("Dog is eating!!");
    }

}
class TestClass
{
    static void Main(String[] args)
    {
        Dog dog1 = new Dog();
        Console.WriteLine("Created a dog object!");
        Console.WriteLine("Enter a dog name");
        dog1.setName(Console.ReadLine());
        Console.WriteLine("Your dog name is"+" "+dog1.getName());
        dog1.Eat();
    }
}