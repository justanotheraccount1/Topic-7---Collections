namespace Topic_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] a = new int[29];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = generator.Next(1, 101);
                Console.Write($"{a[i]}, ");
            }
        }
    }
}
