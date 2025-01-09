string Method(string s)
    {
        for (int i = s.Length - 1, l = 0; i > 0; i--, l++)
        {
            if (s[i] != s[l])
            {
                return "Палиндром: Нет";
            }
        }
        return "Палиндром: Да";
    }
string s = Console.ReadLine();
Console.WriteLine(Method(s));