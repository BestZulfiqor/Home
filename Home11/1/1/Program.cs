using System;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer("Dell", "Inspiron 15", 2017);
        computer.TurnOn();
        computer.TurnOff();
        Laptop laptop = new Laptop("HP", "Pavilion 15", 2022, 40);
        laptop.TurnOnKeyboardColors();
        laptop.TurnOffKeyboardColors();
        laptop.ChargeBattery();
        SmartPhone smartPhone = new SmartPhone("Samsung", "Galaxy S21", 2023, 80);
        smartPhone.TurnOnFlashlight();
        smartPhone.TurnOffFlashlight();
        smartPhone.ChargeBattery();
    }
}