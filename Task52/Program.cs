// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}


int[,] GetFillArray(int m, int n){

    int[,] arr = new int[m,n];
    for (int i=0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-10, 11);
        }
    }
    
    return arr;
}


void PrintArray(int[,] arr){

    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void AverageInArray(int[,] arr){

    for (int i = 0; i < arr.GetLength(1); i++){
        
        double average = 0 ;
        for (int j = 0; j < arr.GetLength(0); j++){
            
            average += arr[j,i];
        }
        average = Math.Round(average / arr.GetLength(0),1);
        Console.Write($"{average}\t");
    }
}

Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
int[,] arr = GetFillArray(m,n);

PrintArray(arr);
Console.WriteLine();

AverageInArray(arr);
