//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("введите 5-ти значное число:");
//int p = Convert.ToInt32(Console.ReadLine());
//if (p < -99999 || p > 99999) Console.WriteLine("вы ввели неверное число");
//if (p > -9999 && p < 9999) Console.WriteLine("вы ввели неверное число");
//функция проверки на палиндром
void functioncheckingOfpalindrom(int pol)
{
    if (pol % 10 == (pol / 10000) % 10 && pol / 10 % 10 == (pol / 1000) % 10)
        Console.WriteLine($"{pol} Да. Это палиндром");
    else Console.WriteLine($"{pol} Нет. Это не палиндром");
//Console.WriteLine($"{pol % 10}");
//Console.WriteLine($"{pol % 100}");
}
functioncheckingOfpalindrom(13437);

