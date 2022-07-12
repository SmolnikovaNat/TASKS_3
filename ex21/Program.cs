namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход координаты двух точек
            //и находит расстояние между ними в 3D пространстве
            //A(3,6,8)  B(2,1,-7) -> 15.84
            //A(7,-5,0) B(1,-1,9) -> 11.53
            Console.WriteLine("Введите коортинаты точки а; ");
            Console.WriteLine("Введите коортинаты точки b; ");
            int xa = Convert.ToInt32(Console.ReadLine());
            int ya = Convert.ToInt32(Console.ReadLine());
            int za = Convert.ToInt32(Console.ReadLine());
            int xb = Convert.ToInt32(Console.ReadLine());
            int yb = Convert.ToInt32(Console.ReadLine());
            int zb = Convert.ToInt32(Console.ReadLine());
            int length = (xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za);
            double distance = Math.Sqrt(length);
            Console.Write(distance);
            
        }
    }
}                  
