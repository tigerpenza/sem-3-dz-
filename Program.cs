// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Diaposon(int number)
// {
//     if(number == 1) Console.WriteLine("X - положительный (больше нуля), Y - положительный(больше нуля)");
//     if(number == 2) Console.WriteLine("X - отрицательный (меньше нуля), Y - положительный(больше нуля)");
//     if(number == 3) Console.WriteLine("X - отрицательный (менше нуля), Y - отрицательный(меньше нуля)");
//     if(number == 4) Console.WriteLine("X - положительный (больше нуля), Y - отрицательный(меньше нуля)");
//     if(number < 1 ^^ number > 4) Console.WriteLine("Некоректный ввод");
// }

// Console.Write("Введите число номер четверти: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
// Diaposon(num_1);

//  Задача 3. Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.

// void number(int number)
// {
//     int index = 1;
//     Console.Write($"Ответ будет: ");
//     while(index <= number)
//     {
//         int square = index * index;
//         index ++;
//         Console.Write($"{square}, ");
//     }
// }
// Console.Write("Введите число: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
// number(num_1);

// Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// void programm(int xA, int xB, int yA, int yB)
// {
//     int result_1 = xA  
// }




// while (a)
// {
//     int index = 1;
//     Console.WriteLine(ответ будет)
//     }
//     while (index < number)
//     {
//         int square = index * number;
//         Console.WriteLine(ответ будет)
//     }

//  Console.WriteLine ("введите номер четверти");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// VoidDiaposon(num_1);



// ДЗ! 

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да




















// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23




















// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void number(int number)
{
    int index = 1;
    Console.Write($"Ответ будет: ");
    while(index <= number)
    {
        int kyb = index * index * index;
        index ++;
        Console.Write($"{kyb}, ");
    }
}
Console.Write("Введите число: "); // запрашиваем число
int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
number(num_1);