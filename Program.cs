// Задача 54. Задайте двусмерный массив. Напишите программу, которая
//  упорядочит по убыванию все элементы каждой строки

// System.Console.WriteLine("Введите количество строк");
// int rows = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите количество столбцов");
// int colums = int.Parse(Console.ReadLine());

// int[,] matrix= new int[rows,colums];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//  for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j]+" ");
//         }
//         System.Console.WriteLine();
//     }   
// }

// void SortArray()
// {
//  for (int i = 0; i < matrix.GetLength(0); i++)
//  {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {
//         if(matrix[i,j]>matrix[i,k])
//         {
//         int MaxEll= matrix[i,j];
//         matrix[i,j] = matrix[i,k];
//         matrix[i,k]=MaxEll;
//         }
//         }
//  }   
// }
// }

// GetArray();
// PrintArray();
// SortArray();
// System.Console.WriteLine();
// PrintArray();




// задача 56.Задайте двумерный прямоугольный массив.Напишите программу, которая будет находить строку с наименьшой 
// суммой элементов.

System.Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int colums = int.Parse(Console.ReadLine());

int[,] matrix= new int[rows,colums];
int SumRow = 0;
int Temp =0;
int MaxRow = 1;
void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= new Random().Next(0,10);
        }
    }
}

void PrintArray()
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+" ");
        }
        System.Console.WriteLine();
    }   
}

void FindRows()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow += matrix[i,j];
        }
    System.Console.Write(SumRow +" ");
    if(Temp>SumRow)
    {
        MaxRow = i-1;
    }
    Temp=SumRow;
    System.Console.Write(Temp+" ");
    SumRow =0;
    }
    System.Console.WriteLine("Максимальная сумма элементов в строке:"+ MaxRow);
}

GetArray();
PrintArray();
System.Console.WriteLine();
FindRows();