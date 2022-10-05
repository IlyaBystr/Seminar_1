/*
Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);

if (Num1 > Num2)
{
    Console.WriteLine($"Число {Num1} Больше чем {Num2}");
}
else if (Num1 < Num2)
{
    Console.WriteLine($"Число {Num1} Меньше числа {Num2}");
}
else
{
    Console.WriteLine($"Число {Num1} Равно числу {Num2}");
}
*/
/*
Console.WriteLine("Введите первое число");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int Num3 = int.Parse(Console.ReadLine()!);

if (Num1>Num2){
    if (Num1>Num3){
        Console.WriteLine($"Число {Num1} самое большое");
    }
    else if (Num1<Num3){
        Console.WriteLine($"Число {Num3} самое большое");
    }
}
else{
    if(Num2>Num3){
        Console.WriteLine($"Число {Num2} самое большое");
    }
    else if(Num2<Num3){
        Console.WriteLine($"Число {Num3} самое большое");
    }
}
*/
/*
Console.WriteLine("Введите число");
Double Num1 = double.Parse(Console.ReadLine()!);

if (Num1 % 2 == 0)
{
    Console.WriteLine($"Число {Num1} является чётным");
}
else
{
    Console.WriteLine($"Число {Num1} является не чётным");
}
*/

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int i=0;
while (i<=n){
    if(i%2==0){
        Console.WriteLine($"{i}");
    }
    else{

    }
i++;
}