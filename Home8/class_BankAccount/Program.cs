using System;
class BankAccaunt
{
	int AccauntId;
	decimal balance;
	string OwnerName;
	bool IsFrozen;
	public BankAccaunt(int Id, string name, decimal balance)
	{
		AccauntId = Id;
		OwnerName = name;
		this.balance = balance;
	}
	public void Deposit(decimal amount)
	{
		if (IsFrozen)
		{
			System.Console.WriteLine("Ваша карта замарожена!");
		}
		else
		{

			balance += amount;
			System.Console.WriteLine($"Баланс: {balance}");
		}
	}
	public void Withdraw(decimal amount)
	{
		if (IsFrozen)
		{
			System.Console.WriteLine("Ваша карта замарожена!");
		}
		else
		{
			if (amount > balance)
			{
				System.Console.WriteLine("Нехватает средств!");
			}
			else
			{
				balance -= amount;
			}
			System.Console.WriteLine($"Баланс: {balance}");
		}
	}
	public void FreezeAccount()
	{
		IsFrozen = true;
	}
	public void UnfreezeAccount()
	{
		IsFrozen = false;
	}
}
class Program
{
	static void Main(string[] args)
	{
		BankAccaunt account = new BankAccaunt(1001, "John Doe", 5000.00m);
		account.Deposit(1000.00m);
		account.Withdraw(200.00m);
		account.FreezeAccount();
		account.Deposit(500.00m);
		account.UnfreezeAccount();
		account.Deposit(500.00m);
	}
}