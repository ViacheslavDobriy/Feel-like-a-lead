// Определить сколько чисел больше 0 введено с клавиатуры

int GetSizeArray()
{
    Console.WriteLine("Введите число чисел, которое вы хотите ввести с клавиатуры : ");
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
}
int checkArray(int[] Array)
{
    int result = 0;
    for(int i = 0; i<Array.Length; i++)
    {
        if(Array[i]>0)
            result++;
    }
    return result;
}
int Size = GetSizeArray();
int[] LineOfNumber = new int[Size];
FillArray(LineOfNumber);
ShowLine(LineOfNumber);
int count = checkArray(LineOfNumber);                          //переменная , которая считает количество чисел больше нуля в массиве
Console.WriteLine();
Console.WriteLine($"В данном массиве всего {count} чисел больше 0");