Console.WriteLine("enter the number 1 : ");
if(Console.ReadLine() != null)
{
    int num1 = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("enter a valid number ");
}

Console.WriteLine("enter the operator : ");
string op = Console.ReadLine();

Console.WriteLine("enter the number 2 : ");
if (Console.ReadLine() != null)
{
    int num2 = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("enter a valid number ");
}
;

if (op == "+")
{
    Console.WriteLine($" {num1} + {num2} = {num1+num2}");
}
else  if (op == "-")
{
    Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
}
else if(op == "*")
{
    Console.WriteLine($" {num1} * {num2} = {num1 * num2}");
}
else if (op == "/")
{
    Console.WriteLine($" {num1} / {num2} = {num1 / num2}");
}