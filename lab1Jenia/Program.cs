using System;
using System.Threading;
namespace lab1Jenia
{
    class Program
    {
        static void Main(string[] args)
        {

            // Factroy Method
            IConsoleInterface @interface = new BlueInterface();
            @interface.Display();
            Console.WriteLine("Blue");
            Thread.Sleep(3000);
            @interface = new RedInterface();
            @interface.Display();
            Console.WriteLine("Red");
            // End Factory Method

            //AbstractFactory
            CarFactory carFactory = new ModernCarFactory();
            carFactory.CreateCar();
            carFactory.StartEngine();

            carFactory = new OldCarFactory();
            carFactory.CreateCar();
            carFactory.StartEngine();
            //AbstractFactory

            //singleton
            Singleton singleton = Singleton.GetSingleton();
            singleton.WriteSignletonStatus();
            //endsingleton

            //garage builder
            GarageBuilder garageBuilder = new GarageBuilder();
            garageBuilder.BuildFloor();
            garageBuilder.BuildWall();
            garageBuilder.BuildEntrance();
            garageBuilder.BuildRoof();
            //end builder


            ModernCarFactory copyFactory = ModernCarFactory.Copy(new ModernCarFactory());

        }
    }
}
