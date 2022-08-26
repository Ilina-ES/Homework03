public class Homework03
{
    public static void Main(string[] args)
    {
    /* Задача 19. 
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да*/
    Palindrome();
        
    /*Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
    между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53*/
    DistanceBetweenPoints();

    /*Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125*/
    CubesTable();
    }

    static void Palindrome()
    /* Задача 19. 
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом.*/

        {
            Console.Write("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 9999 && number <= 99999) //Проверим, является ли число пятизначным
            {            
                if ((number/10000 == number % 10) && ((number/1000) % 10 == (number/10) % 10))
                //сравним 1-ое значение 5-ти значного числа с 5-м и 2-ое значение с 4-ым
                
                  {
                    Console.WriteLine($"Число {number} является палиндромом");
                }

                else
                    {
                        Console.WriteLine($"Число {number} не является палиндромом");
                    }
            }
            
            else 
            {
                Console.WriteLine("Введено не корректное число");
            }
            
        }


    static void DistanceBetweenPoints()
    /*Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
    между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53*/

    {
        Console.Write("Введите X1: ");
        int x1 = int.Parse(Console.ReadLine());
            
        Console.Write("Введите Y1: ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Введите Z1: ");
        int z1 = int.Parse(Console.ReadLine());
           
        Console.Write("Введите X2: ");
        int x2 = int.Parse(Console.ReadLine());
            
        Console.Write("Введите Y2: ");
        int y2 = int.Parse(Console.ReadLine());

        Console.Write("Введите Z2: ");
        int z2 = int.Parse(Console.ReadLine());

        double result = Math.Sqrt (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        Console.WriteLine($"Расстояние между двумя точками {result:f2}"); 
    }

    static void CubesTable()
    /*Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125*/

    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.Write($"{i * i * i} ");
        }
    }
}
