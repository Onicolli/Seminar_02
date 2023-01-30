Console.Clear();
int Num = new Random().Next(100,1000);
int s = Num % 10;
int e = Num / 100;
Console.WriteLine($"Из числа {Num} получилось число {e}{s}");
