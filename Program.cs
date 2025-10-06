using System.ComponentModel.DataAnnotations;

namespace Topic_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] a = new int[29];
            int evenCount = 0;
            int max = 0;
            int min = 101;
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = generator.Next(1, 101);
                if ((i + 1) % 2 == 0)
                {
                    a[i] = a[i] * 2;
                }
                Console.Write($"{a[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0;i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(evenCount + " evens");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0;i<a.Length; i++)
            {
                if (a[i] % 5 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine("are all multiples of 5");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    a[i] = a[i] / 2;
                }
                Console.Write($"{a[i]}  ");
                min = a[i];
                if (a[i] < min)
                {

                }
            }

        }
    }
}
