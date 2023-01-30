Console.Clear();
int n1 = new Random().Next(1, 1000);
int n2 = new Random().Next(1, 1000);

if(n1%n2 == 0) 
{
    Console.WriteLine($"{n1}, {n2} -> кратно");
}
else
{
    int n = n1%n2 ;
    Console.WriteLine ($"{n1}, {n2} -> не кратно, остаток {n}");
}