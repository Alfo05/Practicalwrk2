using System;

namespace Maui
{
    public class ConvertorMain
    {
        public static void Main()
        {
            Converter converter = new Converter();

            int operation = converter.PrintOperations();

            while (operation >= 1 && operation <= converter.GetNumberOperations())
            {
                Console.Clear();
                Console.Write("Insert the number to convert: ");

                string input = Console.ReadLine();

                if (input != null && input != "")
                {
                    string output = converter.PerformConversion(
                        operation,
                        input);

                    converter.PrintConversion(
                        operation,
                        input,
                        output);
                }

                operation = converter.PrintOperations();
            }
        }
    }
}