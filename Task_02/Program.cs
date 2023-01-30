Console.Clear();
int Num = new Random().Next(100,1000);
int s = Num;
int e = Num;
s = Num % 10;
e = Num / 100;

Console.WriteLine($"Из числа {Num} получилось число {e}{s}");
