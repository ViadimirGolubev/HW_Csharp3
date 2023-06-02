//Console.WriteLine("Hello, World!");
//  Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



    
        Console.WriteLine("Введите число");

        string numZnaki = Console.ReadLine();

        int numChislo = numZnaki.Length;

        while (numChislo == 5);
        {
            if (numZnaki[0] == numZnaki[4] && numZnaki[1] == numZnaki[3]);
            {
                Console.WriteLine($"{numZnaki} - Палиндром");
            } else {
                Console.WriteLine($"{numZnaki} -  Не палиндром");
            }
        }
        return;
        
        Console.WriteLine($"{numZnaki} -  Введите пятизначное число");
        

// -------------------------------------Задача 21-------------------------------------------------------
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату х первого числа");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y первого числа");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z первого числа");
// int Z1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите координату х второго числа");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y второго числа");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z второго числа");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));

// Console.WriteLine(d);



// -----------------------------------Задача 23------------------------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while(num>=count)
// {
//     Console.Write($"{Math.Pow(count,3)}, ");
//     count=count+1;
// }