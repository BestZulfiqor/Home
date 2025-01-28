using System;

namespace Infrastructure
{
    public class Transport
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public Transport(string brand, string model, int capacity)
        {
            this.Brand = brand;
            this.Model = model;
            this.Capacity = capacity;
        }
        public void Info()
        {
            System.Console.WriteLine($"This is a basic transport \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}\n");
        }
    }
}