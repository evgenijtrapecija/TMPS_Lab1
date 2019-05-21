using System;
namespace lab1Jenia
{
    public interface CarFactory
    {
        string CarModel { get; set; }
        void CreateCar();
        void StartEngine();
    }
}
