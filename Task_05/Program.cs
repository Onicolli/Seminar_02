Console.Clear();
Console.WriteLine("Enter 1st number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number: ");
int b = int.Parse(Console.ReadLine());
if (a*a == b || b*b == a)
{
    Console.WriteLine($"{a},{b} -> да");
}
else
{
    Console.WriteLine($"{a},{b} -> нет");
}