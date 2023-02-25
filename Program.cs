// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2) Console.WriteLine("{0} больше {1}",number1,number2);
// else Console.WriteLine("{1} больше {0}",number1,number2);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int result = number1;

// if (number2 > result) result = number2;
// if (number3 > result) result = number3;
// Console.WriteLine("Максимальное число - {0}",result);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Число {0} четное",number);
else Console.WriteLine("Число {0} не четное",number);