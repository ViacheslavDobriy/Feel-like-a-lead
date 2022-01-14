// Написать программу копирования массива

int GetSizeArray()
{
    Console.WriteLine("Введите количество чисел, которое вы хотите ввести с клавиатуры : ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArray(int[] Array)
{
    for(int i = 0 ; i < Array.Length ; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    } 
}
void ShowLine(int[] Array)
{
    for(int i = 0 ; i <Array.Length; i++)
    Console.Write($"{Array[i]} ");
    Console.WriteLine();
}
int[] CreateArray(int[] Array)
{
    int[] NewArray = new int[Array.Length];
    for(int i = 0; i < Array.Length; i++)
    {
        NewArray[i]=Array[i];
    }
    return NewArray;
}
int number = GetSizeArray();
int[] OldArray = new int[number];
FillArray(OldArray);
ShowLine(OldArray);
int[] NewArray = CreateArray(OldArray);
Console.WriteLine("____________________________");
ShowLine(NewArray);
