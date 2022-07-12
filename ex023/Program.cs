namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                PrintPow(i);
            }            
        }
        public static void PrintPow(int n)
        {
            Console.WriteLine(n*n*n);
        }
    }
}