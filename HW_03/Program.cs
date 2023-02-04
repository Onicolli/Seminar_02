Console.Clear();
Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine()!);
if ((Num > 7) || (Num < 1)) {
    Console.WriteLine("Введите число от 1 - 7");
}
if (Num > 5) {
    Console.WriteLine("Да");
}
if (Num <= 5) {
    Console.WriteLine("Нет");
}

