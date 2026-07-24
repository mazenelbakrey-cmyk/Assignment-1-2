Console.WriteLine("Enter the number : ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number : ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"num1 = {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"num2 = {num2}");
}
else Console.WriteLine("num1 = num2");

