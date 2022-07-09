namespace HelloWorld
{
class Program
{
    public static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход пятизначное число и
        //проверяет, являутся ли оно палиндромом

        Console.WriteLine("Введите пятизначное число: ");
        string? number = Console.ReadLine();
        
        if (number[0] == number[4] || number[1] == number[3])
        {
            Console.WriteLine($" -> да : {number}" );
        }

        else
        {
             Console.WriteLine($" -> нет : {number}" );
        }
            
    }
}
}
