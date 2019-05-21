using System;
namespace lab1Jenia
{
    public class Singleton
    {
        private static Singleton singleton;


        public static Singleton GetSingleton()
        {
            if (singleton != null)
                return singleton;
            else
                return new Singleton();
        }

        public void WriteSignletonStatus(){

            Console.WriteLine("im the only one object in program");
        }

    }
}

