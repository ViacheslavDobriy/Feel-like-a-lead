// Выяснить являются ли три числа сторонами треугольника

int GetNumber()
{
    Console.WriteLine("Введите число :");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number1 = GetNumber();
int number2 = GetNumber();
int number3 = GetNumber();

if(number1+number2>number3 && number2+number3>number1 && number1+number3>number2)
{
    Console.WriteLine("Это может быть треугольником");
}
else 
Console.WriteLine("Это не может быть треугольником");
