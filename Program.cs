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
    private static void Main(string[] args)
    {

        Console.WriteLine("enter a number:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("enter a power:");
        int pow = int.Parse(Console.ReadLine());
        System.Console.WriteLine("The result is: "+powerRecursion(num,pow));

        System.Console.WriteLine(powerRecursion(1, 2));
        System.Console.WriteLine(powerRecursion(3, 3));
        Console.WriteLine("-------------------------");
        System.Console.WriteLine(power(1, 2));
        System.Console.WriteLine(power(3, 3));


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

    }

}