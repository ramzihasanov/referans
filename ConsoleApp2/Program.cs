namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car=new Cars();
            car.Brand = "Mercedes";
            car.Model = "S Class";
            car.CurrentFuel = 20;
            car.FuelFor1km = 1;
            car.Millage = 245;
            car.Drive();



        }
    }
}