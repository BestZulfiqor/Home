namespace Library;

public class Tools
{
	public void CountWords(string text)
	{
		string[] words = text.Split(' ', '.', ',', '!', '?');

		Dictionary<string, int> counter = new();
		foreach (var word in words)
		{
			string cleanWord = word.Trim().ToLower();
			if (cleanWord != "")
			{
				if (counter.ContainsKey(cleanWord))
				{
					counter[cleanWord]++;
				}
				else
				{
					counter.Add(cleanWord, 1);
				}
			}

		}
		System.Console.WriteLine("Результат:");
		int number = 1;
		foreach (var item in counter)
		{
			Console.WriteLine($"{number}. {item.Key} - {item.Value} раз(а)");
			number++;
		}
	}
}
