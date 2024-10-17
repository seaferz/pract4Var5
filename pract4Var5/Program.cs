//ввод данных
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

//вычисление остатка
int k = n % 6;

double y;

//вычисление значение в зависимости от значения к
switch (k)
{
    case 0: //к=0
        y = 1;
        Console.WriteLine($"y = {y}");
        break;
    case 1: //к=1
        y = a + b;
        Console.WriteLine($"y = {y}");
        break;
    //к = 2 или 3
    case 2: 
    case 3:
        y = a * a + b * b;
        Console.WriteLine($"y = {y}");
        break;
    case 4: //к = 4
        y = a * Math.Sin(b);
        Console.WriteLine($"y = {y}");
        break;
    case 5: //к = 5
        y = a * Math.Log((Math.Abs(b)));
        Console.WriteLine($"y = {y}");
        break;
}