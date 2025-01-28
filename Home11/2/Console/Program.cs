using System;
using System.Diagnostics;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Transport transport = new Transport("Mercedes", "Benz", 4);
        transport.Info();
        
        Car car = new Car("BMW", "X5", 4, 4);
        car.Info();
        
        CargoCar cargoCar = new CargoCar("Gazel", "Naz-AA", 2, 6, 20);
        cargoCar.Info();
        
        PassengerCar passengerCar = new PassengerCar("Mercedes", "Sprinter", 20, 4, 25);
        passengerCar.AddClient();
        passengerCar.AddClient();
        
        Airplane airplane = new Airplane("Aeroclassics", "100Aero", 100, 1);
        airplane.Info();
        
        PassengerPlane passengerPlane = new PassengerPlane("Aeroclassics", "100Aero", 100, 1, 90, 2200.5);
        passengerPlane.Info();
        
        CargoPlane cargoPlane = new CargoPlane("AeroCargo", "100Cargo", 5, 1, 20);
        cargoPlane.AddCargo(10);
        cargoPlane.Info();

        Train train = new Train("Traino", "Tr45",200, 12);
        train.Info();

        CargoTrain cargoTrain = new CargoTrain("Traino", "TrCargo",5, 20, 50);
        cargoTrain.Info();
        cargoTrain.AddCargo(5);

        PassengerTrain passengerTrain = new PassengerTrain("Train", "TrPassenger",200, 20, 150, 1.50);
        passengerTrain.BuyTicket(100);
        passengerTrain.Info();
    }
}