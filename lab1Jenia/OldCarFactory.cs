using System;
namespace lab1Jenia
{
    public class OldCarFactory : CarFactory
    {
        public OldCarFactory()
        {
        }

        public string CarModel { get => "Old Car"; set => throw new NotImplementedException(); }

        public void CreateCar()
        {
            Console.WriteLine("Car created - {0}", CarModel);
        }

        public void StartEngine()
        {
            Console.WriteLine("Cha cha cha");
        }
    }
}
