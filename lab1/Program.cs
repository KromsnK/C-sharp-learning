using System;

class Lab1
{
    static double Distance(double a1, double a2, double b1, double b2)
    {
        return Math.Sqrt((Math.Pow(b1 - a1, 2)) + (Math.Pow(b2 - a2, 2)));
    }
    static double Area(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static void Main()
    {

        uint grade = 0;
        Console.WriteLine("========Task 1========");
        Console.WriteLine("Enter grade: ");
        grade = Convert.ToUInt32(Console.ReadLine());
        switch (grade)
        {
            case < 5:
                Console.WriteLine("Bad");
                break;
            case < 9:
                Console.WriteLine("Good");
                break;
            case < 11:
                Console.WriteLine("Great");
                break;
            case <= 12:
                Console.WriteLine("Exelent");
                break;
            case > 12:
                do
                {
                    Console.WriteLine("Your grade exeedsthe max grade in system. Please enter your grade again: ");
                    grade = Convert.ToUInt32(Console.ReadLine());
                }
                while (grade > 12);
                break;
        }
        ;
        Console.WriteLine("========Task 2========");
        Console.WriteLine("Enter x1 and y1: ");
        string[] A = Console.ReadLine().Split();
        double x1 = Convert.ToDouble(A[0]);
        double y1 = Convert.ToDouble(A[1]);

        Console.WriteLine("Enter x2 and y2: ");
        string[] B = Console.ReadLine().Split();
        double x2 = Convert.ToDouble(B[0]);
        double y2 = Convert.ToDouble(B[1]);

        Console.WriteLine("Enter x3 and y3: ");
        string[] C = Console.ReadLine().Split();
        double x3 = Convert.ToDouble(C[0]);
        double y3 = Convert.ToDouble(C[1]);

        Console.WriteLine("Distance AB: ");
        double AB = Distance(x1, y1, x2, y2);
        Console.WriteLine(AB);
        Console.WriteLine("Distance BC: ");
        double BC = Distance(x2, y2, x3, y3);
        Console.WriteLine(BC);
        Console.WriteLine("Distance CA: ");
        double CA = Distance(x3, y3, x1, y1);
        Console.WriteLine(CA);
        Console.WriteLine("Area of a triangle: ");
        double area = Area(AB, BC, CA);
        Console.WriteLine(area);
        Console.WriteLine("========Task 3========");
        Console.WriteLine("Enter flag height: ");
        int h = Convert.ToInt32(Console.ReadLine());
        int w = h * 2;
        int red = h / 9;
        int white = h / 5;
        int midHeight = h / 2;
        int midWidth = h / 3;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                bool iswhite = (i >=midHeight-white/2 && i <=midHeight+white/2)||(j>=midWidth-white/2&&j<=midWidth+white/2);
                bool isred = (i >=midHeight-red/2 && i<=midHeight+red/2)||(j>=midWidth-red/2&&j<=midWidth+red/2);
                if (isred)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }else if (iswhite)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
        Console.WriteLine("========Task 4========");
        Console.WriteLine("Enter first date(yy mm dd): ");
        string[] Input1 = Console.ReadLine().Split();
        int year1 = Convert.ToInt32(Input1[0]);
        int month1 = Convert.ToInt32(Input1[1]);
        int day1 = Convert.ToInt32(Input1[2]);
        var Date1 = new DateTime(year1, month1, day1);
        Console.WriteLine("Enter second date(yy mm dd): ");
        string[] Input2 = Console.ReadLine().Split();
        int year2 = Convert.ToInt32(Input2[0]);
        int month2 = Convert.ToInt32(Input2[1]);
        int day2 = Convert.ToInt32(Input2[2]);
        var Date2 = new DateTime(year2, month2, day2); 
       
        Console.WriteLine($"Firts date is {Date1}\n Second date is {Date2}"); 
        if (Date2 < Date1)
        {
            var temp = Date1;
            Date1 = Date2;
            Date2 = temp;
        }
        int diff=(Date2.Year - Date1.Year)*12+(Date2.Month-Date1.Month);
        if (Date2.Day < Date1.Day)
        {
            diff--;
        }
        Console.WriteLine($"Difference in months is {diff}");
        Console.WriteLine("========Task5========");
        int day = 4;

        string dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            _ => "Weekend day" // The underscore '_' is the discard pattern, acting as the default
        };

        Console.WriteLine(dayName);
    }
}
