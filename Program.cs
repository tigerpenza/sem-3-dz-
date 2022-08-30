


// ДЗ! 

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// void Pal ( int num)
// {
//     int n_1 = num / 10000; 
//     int n_2 = (num / 1000) % 10; 
//     int n_4 = ( num % 100 ) / 10; 
//     int n_5 = ( num % 10); 

//     if ( num > 99999 || num < -99999) Console.WriteLine("Введите 5ти значное число!");
//     {
//         if ( n_1 == n_5)
//             {
//                 if ( n_2 == n_4) Console.WriteLine("Число является палиндромом");
//             }
                
            
//     }
    
// }

// Console.WriteLine("Введите 5ти значное число: ");
// int num_enter = Convert.ToInt32(Console.ReadLine());

// Pal(num_enter);





// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Prost (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double xx = (x2 - x1) * (x2 - x1);
//     double yy = (y2 - y1) * (y2 - y1);
//     double zz = (z2 - z1) * (z2 - z1);

//     return Math.Sqrt ((xx + yy + zz)); 

// }

// Console.WriteLine("Enter coordinates for point 1: ");
// double dot1_x = Convert.ToInt32(Console.ReadLine());
// double dot1_y = Convert.ToInt32(Console.ReadLine());
// double dot1_z = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter coordinates for point 2: ");
// double dot2_x = Convert.ToInt32(Console.ReadLine());
// double dot2_y = Convert.ToInt32(Console.ReadLine());
// double dot2_z = Convert.ToInt32(Console.ReadLine());

// double res = Prost( dot1_x, dot1_y, dot1_z, dot2_x, dot2_y, dot2_z);
// Console.WriteLine(res);








//задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void number(int number)
// {
//     int index = 1;
//     Console.Write($"Ответ будет: ");
//     while(index <= number)
//     {
//         int kyb = index * index * index;
//         index ++;
//         Console.Write($"{kyb}, ");
//     }
// }
// Console.Write("Введите число: "); // запрашиваем число
// int num_1 = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число
// // number(num_1);