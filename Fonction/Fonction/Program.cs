using System;
using System.Collections.Generic;
public class MainProgram
{

    public static float Add(float x, float y)
    {
        return x + y;
    }

    public static float Subtract(float x, float y)
    {
        return x - y;
    }

    public static float Multiply(float x, float y)
    {
        return x * y;
    }

    public static float Divide(float x, float y)
    {
        return x / y;
    }

    public static float Modulo(float x, float y)
    {
        return x % y;
    }

    public static void Main(string[] commandLineArguments)
    {
        while (true)
        {
            Console.WriteLine("enter quit to quit or c to continue: ");
            string operateur = Console.ReadLine();

            if (operateur == "quit")
            {
                break;
            }

            Console.WriteLine("first operand : ");
            float.TryParse(Console.ReadLine(), out float number1);
            Console.WriteLine("second operand : ");
            float.TryParse(Console.ReadLine(), out float number2);


            Console.WriteLine("which operation you choose : ");
            operateur = Console.ReadLine();

            if (operateur != "Add" && operateur != "Subtract" && operateur != "Multiply" && operateur != "Divide" && operateur != "Modulo")
            {
                Console.WriteLine("Unknown operation " + operateur + " : ");
                Console.WriteLine("first operand : ");
                float.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("second operand : ");
                float.TryParse(Console.ReadLine(), out number2);

                Console.WriteLine("which operation you choose : ");
                operateur = Console.ReadLine();

            }
            else
            {
                if (operateur == "Add")
                {
                    Console.WriteLine(Add(number1, number2));
                }

                if (operateur == "Subtract")
                {
                    Console.WriteLine(Subtract(number1, number2));
                }

                if (operateur == "Multiply")
                {
                    Console.WriteLine(Multiply(number1, number2));
                }

                if (operateur == "Divide")
                {
                    if (number2 == 0) {
                        Console.WriteLine("division par 0 ! ");
                    }
                    else
                    {
                        Console.WriteLine(Divide(number1, number2));
                    }
                    
                }

                if (operateur == "Modulo")
                {
                    Console.WriteLine(Modulo(number1, number2));
                }

            }


        }
    }

    
}
