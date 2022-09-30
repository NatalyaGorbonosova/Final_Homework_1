// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше или равна 3.
void FillArray(String[] array)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i = 0; i < array.Length; i++) array[i] = Console.ReadLine();
}
void PrintArray(String[] array)
{
    for(int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write(array[array.Length - 1]);
}
int CountElement(String[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count+=1;
    }
    return count;
}
void FillNewArray(String[] array, String[] arrayNew)
{
    int k = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            arrayNew[k] = array[i];
            k++;
        }
    }
}
try
{
    Console.WriteLine("Введите размерность массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    String[] collection = new String[N];
    FillArray(collection);
    PrintArray(collection);
    Console.WriteLine();
    int M = CountElement(collection);
    if(M > 0)
    {
        String[] newCollection = new String[M];
        FillNewArray(collection, newCollection);
        PrintArray(newCollection);
    }
    else Console.WriteLine("Таких элементов нет");
}
catch
{
    Console.WriteLine("Что-то пошло не так");
}
