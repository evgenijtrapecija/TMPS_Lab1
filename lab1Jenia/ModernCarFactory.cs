using System;
namespace lab1Jenia
{
    public class ModernCarFactory : CarFactory
    {
        public ModernCarFactory()
        {
        }


        public static ModernCarFactory Copy (ModernCarFactory carFactory){
            ModernCarFactory factory = new ModernCarFactory();
            factory.CarModel = carFactory.CarModel;


            return factory;
        }

        private string _name = "New car";

        public string CarModel {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void CreateCar()
        {
            Console.WriteLine("Car created - {0}", CarModel);
        }

        public void StartEngine()
        {
            Console.WriteLine("Wruuuuum");
        }
    }
}
