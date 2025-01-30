using System;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.ViewActivity();

        RegularUser regularUser = new RegularUser();
        regularUser.ViewActivity();

        Influences influences = new Influences();
        influences.ViewActivity();       
    }
}