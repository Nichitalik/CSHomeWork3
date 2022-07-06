// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] A = new int[3]{3, 6, 8};
int[] B = new int[3]{2, 1, -7};

double answer = Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2);
answer = Math.Pow(answer, 0.5);
answer = answer - (answer % 0.01);
System.Console.WriteLine(answer);
