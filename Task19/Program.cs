// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[5];
if (num < 100000 && num > 9999)
{
    int i = 0;
    while (i < 5)
    {
        arr[i] = num % 10;
        i++;
        num/=10;
    }


    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
else
{
    System.Console.WriteLine("Введено неправильное число");
}
