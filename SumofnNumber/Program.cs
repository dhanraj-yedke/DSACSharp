using System;
using System.Globalization;
using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {

        //1.sum of n numbers 
        Console.Write("Enter a Number : ");
        
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <=  n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("sum of n numbers : " + sum);

        //2.sqare of n numbers 
        Console.Write("Enter a Number : ");
        int m = Convert.ToInt32(Console.ReadLine());
        int sum2 = 0;
        for (int i = 1; i <= m; i++)
        {
            sum2 += i * i;
        }
        Console.WriteLine("sum of sqare of n numbers : " + sum2);

        //3. Factorial of n numbers 
        Console.Write("Enter a Number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int Fact = 1;
        for(int i = 1; i<= number; i++)
        {
            Fact *= i;
        }
        Console.WriteLine("Factorial of n bumbers : " + Fact);
        // factorial using reverser for loop 
        for(int i = n; i > 1; i--)
        {
            Fact *= i;
        }
        Console.WriteLine("Factoria using reverse loop : " + Fact);

        //Prime number check 
        Console.WriteLine("Enter Number : ");
        int pn = Convert.ToInt32(Console.ReadLine());
        for(int i = 2; i <= pn; i++)
        {
            if (pn % i == 0)
            {
                Console.WriteLine("Not Prime Number");
            }
            else
            {
                Console.WriteLine("Prime Number thisis ");
            }
        }

        // 4. Fibonacci series
        Console.WriteLine("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int last = 0;
        int Prev = 1;
        int next = 0;
        Console.WriteLine(last);
        Console.WriteLine(Prev);
        for(int i = 0; i<num; i++)
        {
            next = last + Prev;
            last = Prev;
            Prev = next;
            Console.WriteLine(next);
        }

        Console.ReadLine();
    }
}