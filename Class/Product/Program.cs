using System;
class Product{
	public string Name;
	public decimal Price;
	public decimal OriginalPrice;
	public int StockQuantity;
	public string Category;
	private bool discount;
	private int discountPercent;
	
	public string SetDiscount(int discountPercent){
		OriginalPrice = Price;
		discount = true;
		this.discountPercent = discountPercent;
		Price -= Price * discountPercent / 100;
		return $"Нархи нав ин: {Price}";
	}
	public string AddNewItems(int count){
		if (count >= 0)
		{
			StockQuantity += count;
			return $"Ҳоло дар анбор: {StockQuantity} дона";
		}
		return "Хатои таъминот";
	}
	public string SellItem(int count){
		if (count <= StockQuantity)
		{
			StockQuantity -= count;
			return $"Фурухта шуд! Нарх: {Price * count}";
		}
		return "Дар анбор мол кифоя нест";
	}
	public string CheckAvailability(){
		if (StockQuantity > 20)
		{
			return $"Моли бисёр {StockQuantity} дона";
		}
		else if (StockQuantity >= 5 && StockQuantity <= 20)
		{
			return $"Моли кифоя {StockQuantity} дона";
		}
		return $"Таъминоти фаврӣ лозим! {StockQuantity} дона";
	}
	public string GetPriceTag(){
		if (discount)
		{
			return $"{Name}, Нархи кӯҳна: {OriginalPrice} рубл, Нархи нав: {Price} рубл (Тахфиф!)";
		}
		return $"{Name}, Нарх: {Price} рубл";
	}
	public string CancelDiscount(){
		discount = false;
		return "Тахфиф хомӯш карда шуд";
	}
	public string PromoCode(string code){
		if (code == "12345")
		{
			Price -= Price * 20 / 100;
			discount = true;
			return $"Тахфиф 20%, Нархи нав: {Price}";
		}
		return "Коди таъминоти нодуруст";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Product phone = new Product();
		phone.Name = "Samsung Galaxy S21";
		phone.Price = 1500;
		phone.StockQuantity = 10;
		System.Console.WriteLine(phone.CheckAvailability());
		System.Console.WriteLine(phone.SetDiscount(20));
		System.Console.WriteLine(phone.SellItem(3));
		System.Console.WriteLine(phone.AddNewItems(5));
		System.Console.WriteLine(phone.GetPriceTag());
		System.Console.WriteLine(phone.CancelDiscount());
		System.Console.WriteLine(phone.PromoCode("12345"));
	}
}