//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

void Rastoyanie(int[] A, int[] B)

{
    double ras = Math.Pow((Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2)), 0.5);
    ras = Math.Round(ras, 2);
    Console.WriteLine($"Расстояние от A ({A[0]}, {A[1]}, {A[2]}) до B({B[0]}, {B[1]}, {B[2]}) равно {ras}");
}

Console.Clear();
int[] A1 = { 3, 6, 8 };
int[] B1 = { 2, 1, -7 };
Rastoyanie(A1, B1);

Console.WriteLine();

int[] A2 = { 7, -5, 0 };
int[] B2 = { 1, -1, 9 };
Rastoyanie(A2, B2);