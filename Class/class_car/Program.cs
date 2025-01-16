using System;
class Car{
	public string? model;
	public string? color;
	public int speed;
	public int  year;
	public string? country;
	public int price;
	public string GetInfo(){
		return $"Model: {model} \nColor: {color} \nSpeed: {speed} \nPublished year: {year} \nCountry: {country} \nPrice: {price}";
	}
	public string Drive_miles(double miles){
		return $"Miles: {miles}";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Car car = new Car();
		car.model = "Mercedes";
		car.color = "Black";
		car.year = 2021;
		car.speed = 320;
		car.country = "Germany";
		car.price = 320000;
		string info = car.GetInfo();
		System.Console.WriteLine(info);
		string drive_miles = car.Drive_miles(120);
		System.Console.WriteLine(drive_miles);
	}
}