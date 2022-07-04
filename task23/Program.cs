//Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void printofnumberincube(int n)
{
    int x = 1;
    while(x <= n)
    {
        int cube = x * x * x;
        Console.Write($"{cube},");
        x++;
    }
     Console.Write($"\b \b");
}
printofnumberincube(5);