using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Mototcycle is in drive");

        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This  {GetType().Name} ia a {GetType().BaseType.Name} that is  virtually in drive");

        }
    }
}
