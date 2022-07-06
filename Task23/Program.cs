// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = 5;
int i  = 0;
while (i < num)
{
    i++;
    System.Console.Write(i * i * i);
    if (i < num)
    {
        System.Console.Write(", ");
    }
}