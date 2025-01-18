using System;
class Date
{
	private int Day { get; set; }
	private int Month { get; set; }
	private int Year { get; set; }
	public Date(int day, int month, int year)
	{
		Day = day;
		Month = month;
		Year = year;
	}
	public Date(int day, int month)
	{
		Day = day;
		Month = month;
	}
	public Date(int day)
	{
		Day = day;
	}
	public Date()
	{

	}
	public void SetDate(int day, int month, int year)
	{
		Day = day;
		Month = month;
		Year = year;
	}
	public int GetDay()
	{
		return Day;
	}
	public int GetMonth()
	{
		return Month;
	}
	public int GetYear()
	{
		return Year;
	}
	public string ToString()
	{
		return $"{Day}/{Month}/{Year}";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Date date = new Date(10, 2, 2012);
		System.Console.WriteLine(date.ToString());
	}
}