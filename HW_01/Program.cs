Console.Clear();
int Num = new Random().Next(100, 1000);
Console.WriteLine(Num);
int Mid = Num / 10;
Mid = Mid % 10;
Console.WriteLine($"Среднея цифра {Mid} числа {Num}");
