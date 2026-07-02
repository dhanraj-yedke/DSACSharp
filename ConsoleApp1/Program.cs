using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Color : ");
        string Color = Console.ReadLine();

        if (Color == "Red")
        {
            Console.WriteLine("STOP..!!");
        }
        if (Color == "Yellow")
        {
            Console.WriteLine("GO SLOW...!!");
        }
        if (Color == "Green")
        {
            Console.WriteLine("GO...!!");
        }
       else 
        {
            Console.WriteLine("Dont Break Signle...!!");
        }
        Console.ReadLine();
    }
}
