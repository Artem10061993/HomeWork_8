// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите высоту матрицы = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну матрицы = ");
int n = int.Parse(Console.ReadLine());
int[ , ] array = new int[m,n];
void FillArray(int [ , ] matr )
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
                Console.Write(matr[i,j] + "|");
        }
    Console.WriteLine();
    }
    
}
int current =0;
int change = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(current=j+1; current < array.GetLength(1); current++)
            {
                
                

                    if (array[i,j] < array[i,current])
                    {
                        change = array[i,j];
                        array[i,j] = array[i,current];
                        array[i,current] = change;
                    }
                
            }
        Console.Write(array[i,j] + "|");
        }
    Console.WriteLine();
    }