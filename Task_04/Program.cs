Console.Clear();
Console.WriteLine("Введите число: ");
int Num = int.Parse (Console.ReadLine()); 

if(Num % 7 == 0 && Num % 23 == 0)
{
    Console.WriteLine($"{Num} -> ДА");
}
else {
    Console.WriteLine($"{Num} -> НЕТ");
}

