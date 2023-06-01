// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//  Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число");





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








// ____________________________________________________________________
//______________________________________________________________________
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// // Задача №17. Напишите программу, которая принимает
//  на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if((X>0) && (Y>0))
// {
//     Console.WriteLine("1");
// }
// else if((X<0) && (Y>0))
// {
//     Console.WriteLine("2");
// }
// else if((X<0) && (Y<0))
// {
//     Console.WriteLine("3");
// }
// else 
// {
//     Console.WriteLine("4");
// }


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//__________Вариант1____________________________
// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("X>0, Y>0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X<0, Y>0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("X<0, Y<0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("X>0, Y<0");
// }
// else
// {
//     Console.WriteLine("Ввели некоректное число");
// }


//__________вариант2_________________-

// Задача №17. Напишите программу, которая принимает
//  на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X>0, Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0, Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0, Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0, Y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Ввели некоректное число");
//         break;
//     }

// }


//____________Задача 3__________________
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит
//  расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21 

// d (X2-X1)*(X2-X1)+ (Y2-Y1)2

// Console.WriteLine("Введите число");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// double X2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));

// Console.WriteLine(d);

//____________Задача4__________________________
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while(num>=count)
// {
//     Console.WriteLine(Math.Pow(count,2));
//     count=count+1;
// }



//_________________________________________________



//Console.WriteLine("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num / 10;
// int num2 = num1 % 10;
// Console.WriteLine(num2);




//_______________

// Console.WriteLine("Введите цифру от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num == 6) || (num == 7))
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Рабочий день");

//________________________________________
// }





// Console.WriteLine("Write number: ");
// int num= Convert.ToInt32(Console.ReadLine());

// if (num / 100 == 0)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while(num>1000)
//     {
//         num= num/10;
//     }

//     Console.WriteLine(num%10);
// }





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