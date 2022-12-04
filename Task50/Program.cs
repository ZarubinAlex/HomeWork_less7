// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}


int[,] GetFillArray(int m, int n){

    int[,] arr = new int[m,n];
    for (int i=0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-100, 101);
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

void FindInArray(int[,] arr, int findNumber){

    int key = 0 ;
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            
            if(arr[i, j] == findNumber){
                Console.WriteLine($"Координаты числа: {i+1}, {j+1}");
                key = 1;
            }
        }
    }

    if(key == 0) Console.WriteLine("Такого числа нет");
}

Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
int[,] arr = GetFillArray(m,n);

PrintArray(arr);
Console.WriteLine();
int findNumber = InputInt("Число");
FindInArray(arr, findNumber);
Console.WriteLine();




