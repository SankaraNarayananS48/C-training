interface IVehiculo
{
    void Drive();
    bool Refuel(int refuelamount);
}
class Car:IVehiculo
{
    int gasolinelevel;
    public Car(int gaslevel)
    {
        this.gasolinelevel = gaslevel;
    }

    public void Drive()
    {
        if (gasolinelevel > 0)
            Console.WriteLine("Car is Driving");
        else
            Console.WriteLine("No sufficient fuel to drive!");
    }

    public bool Refuel(int refuelamount)
    {
        this.gasolinelevel += refuelamount;
        return true;
    }

}

class TestClass
{
    static void Main(String[] args)
    {
        Car car1 = new Car(0);
        Console.WriteLine("Created a Car object with 0 gas level");
        car1.Drive();
        Console.WriteLine("Enter a gas level");
        car1.Refuel(int.Parse(Console.ReadLine()));
        car1.Drive();
    }
}