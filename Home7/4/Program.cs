using System;
class Country
{
    public string name;
    public string capital;
    public int population;
    public string officialLanguage;
    
    public string SetCapital(string capital)
    {
        return this.capital = capital;
    }
    public string GetCapital()
    {
        return capital;
    }
    public int SetPopulation(int population)
    {
        return this.population = population;
    }
    public int GetPopulation()
    {
        return population;
    }
    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }
    public string GetCountryInfo()
    {
        return $"Country Name: {name} \nCapital: {capital} \nPopulation: {population} \nOfficial Language: {officialLanguage}";
    }
    public Country(){
        
    }
	public Country(string name, string capital, int population, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Country country = new Country();
        country.name = "Tajikistan";
        country.capital = "Dushanbe";
        country.population = 9537645;
        country.officialLanguage = "Tajik";
        string info = country.GetCountryInfo();
        Console.WriteLine(info);
    }
}