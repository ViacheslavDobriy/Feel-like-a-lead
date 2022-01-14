// Показать числа Фибоначчи

int GetNumber()
{
    Console.WriteLine("Сколько чисел из ряда Фибоначе вым показать?");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Fibonache(int number)
{
    if (number==1 || number==2 ) return 1;
    else return Fibonache(number-1)+Fibonache(number-2);
}
void ShowFibonache(int number)
{
    for(int i = 1; i<=number; i++)
    {
        Console.Write($"{Fibonache(i)} ");
    }
}
int Limit = GetNumber();
ShowFibonache(Limit);
