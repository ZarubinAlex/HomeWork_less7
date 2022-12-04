// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}

int GetNegative(){

    int a=1;
    if(new Random().Next(0,2) == 1) a = -1;
    return a;
}

double[,] GetFillArrayDouble(int m, int n){

    double[,] arr = new double[m,n];
    for (int i=0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * 100, 1) * GetNegative();
        }
    }
    
    return arr;
}


void PrintArray(double[,] arr){

    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
double[,] arr = GetFillArrayDouble(m,n);

PrintArray(arr);
Console.WriteLine();
