Console.Clear();
int Num = new Random().Next(10, 100);
int A1 = Num / 10;
int A2 = Num % 10;
int Max = A1;
if (Max < A2) {
    Max = A2;
}
Console.WriteLine($"Максимальное цифра в числе: {Num} -> {Max}");