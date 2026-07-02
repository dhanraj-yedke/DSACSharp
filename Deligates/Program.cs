using System;

//we must decalre delegate out of the class
public delegate void FunctionDelegate(string Message);

class Program
{
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
    public static void Main(string[] args)
    {
        //we can create object of delegate 
        //here we have to pass method as paramater in delegate 
        FunctionDelegate del = new FunctionDelegate(Hello);
        del("This is Delegate Method");

        Console.ReadLine();
    }
}