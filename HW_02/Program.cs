Console.Clear();
Console.WriteLine("Введите любое число: ");
int Num = int.Parse(Console.ReadLine());
if (Num > 99) { Console.WriteLine((Num / 100) % 10); }
else { Console.WriteLine("В числе не 3 числа"); }