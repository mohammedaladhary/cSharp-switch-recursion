using System;

internal class Program
{
    static int power(int number, int pow)
    {
        int value = number;
        for (int i = 2; i <= pow; i++)
        {
            value = value * number;
        }
        return value;
    }
    static int sum_of_digit(int digit)
    {
        if (digit == 0)
            return 0;

        return (digit % 10 + sum_of_digit(digit / 10));
    }
    static int powerRecursion(int num, int pow)
    {
        if (num == 0)
        {
            return 1;
        }
        else if (pow == 1)
        {
            return num;
        }
        return num * powerRecursion(num, pow - 1);
    }

    static int fibonacci(int numFib)
    {
        int beforeLastTerm = 0;
        int LastTerm = 1;
        int nextTerm = 0;

        for (int i = 2; i <= numFib; i++)
        {
            nextTerm = LastTerm + beforeLastTerm;
            beforeLastTerm = LastTerm;
            LastTerm = nextTerm;
        }
        return nextTerm;
    }

    static int fibonacciSeries(int n)
    {
        if (n == 0 || n == 1) return n;
        return fibonacciSeries(n-1) + fibonacciSeries (n-2);
    }
    private static void Main(string[] args)
    {

        //Console.WriteLine("enter a number:");
        //int num = int.Parse(Console.ReadLine());

        //Console.WriteLine("enter a power:");
        //int pow = int.Parse(Console.ReadLine());
        //System.Console.WriteLine("The result is: "+powerRecursion(num,pow));

        //System.Console.WriteLine(powerRecursion(1, 2));
        //System.Console.WriteLine(powerRecursion(3, 3));
        //Console.WriteLine("-------------------------");
        //System.Console.WriteLine(power(1, 2));
        //System.Console.WriteLine(power(3, 3));
        //Console.WriteLine("-------------------------");

        //System.Console.WriteLine(fibonacci(8));

        Console.WriteLine("enter a number:");
        int num = int.Parse(Console.ReadLine());
        System.Console.WriteLine("The result is: "+sum_of_digit(num));

        //Console.WriteLine("enter a number:");
        //int a = int.Parse(Console.ReadLine());

        //    if (a >= 1 && a <= 7) {

        //    switch (a)
        //    {
        //        case 1:
        //            Console.WriteLine("Today is Sunday.");
        //            break;
        //        case 2:
        //            Console.WriteLine("Today is Monday.");
        //            break;
        //        case 3:
        //            Console.WriteLine("Today is Tuesday.");
        //            break;
        //        case 4:
        //            Console.WriteLine("Today is Wednesday.");
        //            break;
        //        case 5:
        //            Console.WriteLine("Today is Thursday.");
        //            break;
        //        case 6:
        //            Console.WriteLine("Today is Friday.");
        //            break;
        //        case 7:
        //            Console.WriteLine("Today is Saturday.");
        //            break;
        //    }
        //}
        //    else { 
        //    Console.WriteLine("Try Again later"); 
        //}

        Console.WriteLine("enter a character:");
        char vow = Convert.ToChar(Console.ReadLine());

        switch (vow)
        {
            case 'a':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'i':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'o':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'u':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'e':
                Console.WriteLine("The Alphabet is vowel");
                break;
            default:
                Console.WriteLine("The Alphabet is constant");
                break;

        }

        Console.WriteLine("enter a number:");
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("Jan");
                break;
            case 2:
                Console.WriteLine("Feb");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("Jan");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Try Again");
                break;

        }

    }

}