using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {

            bool calculator = true;
            while (calculator)
            {
                Console.WriteLine("=========Calculator menu=========");
                Console.WriteLine("1. Operations list ");
                Console.WriteLine("2. Redact numbers ");
                Console.WriteLine("3. Calculate ");
                Console.WriteLine("4. Exit ");
                uint choice = 0;
                string[] Operations = { "Summ", "Diff", "Multiplition", "Division" };
                double result;

                choice = uint.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(Operations[i]);
                        }
                        break;
                    case 2: // Will try to to something with this later because im not that smart rn
                        /*Console.WriteLine("Which one? (1 or 2)");
                        int temp = int.Parse(Console.ReadLine());
                        if (temp == 1) a = double.Parse(Console.ReadLine());
                        else b = double.Parse(Console.ReadLine());*/
                        break;
                    case 3:
                        Console.WriteLine("=========Input your equaluation=========");
                        string[] equalition = Console.ReadLine().Split(' ');
                        result = double.Parse(equalition[0]);
                        for (int i = 1; i < equalition.Length; i += 2)
                        {
                            string op = equalition[i];
                            double NextNum = double.Parse(equalition[i + 1]);
                            switch (op)
                            {
                                case "+":
                                    result += NextNum;
                                    break;
                                case "-":
                                    result -= NextNum;
                                    break;
                                case "*":
                                    result *= NextNum;
                                    break;
                                case "/":
                                    result /= NextNum;
                                    break;
                                default:
                                    Console.WriteLine("Unknown operator");
                                    return;
                            }
                            break;
                        }
                        Console.WriteLine("Result: " + result);
                        break;
                    case 4:
                        calculator = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input")
                        break;


                }

            }
        }
    }
}
