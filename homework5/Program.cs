using System;

class Program
{ 
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"All number in the range: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("All number in the range in revers order: ");
            for (int i = end; i >= start; --i)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("All number in the range multiples of 7: ");
            for (int i = start; i <= end; ++i)
            {
                if (i % 7 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantity numbers in the range multiples of 5: ");
            int quantity = 0;
            for (int i = start; i <= end; i++)
            {

                if (i % 5 == 0)
                {
                    quantity += 1;

                }
            }
            Console.Write($"{quantity} ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


}