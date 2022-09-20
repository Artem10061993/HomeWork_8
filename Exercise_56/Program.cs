// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
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
FillArray(array);
PrintArray(array);
Console.WriteLine();
int SumNumbrs=0;
int[] arr = new int[m];
for(int i = 0;  i < array.GetLength(0); i++)
    {
        SumNumbrs=0;
        for(int j = 0; j < array.GetLength(1); j++)
            {
            SumNumbrs = array[i,j]+SumNumbrs;
            arr[i]=SumNumbrs;
            }

    }
int result = arr[0];
int i_min =0;
for(int i = 0;  i < arr.Length; i++)
{
    if(arr[i]<result)
    {
        result=arr[i];
        i_min = i;
    }
}
Console.WriteLine($"Наименьшая сумма ="+result+", находящейся в строке № " + (i_min+1));