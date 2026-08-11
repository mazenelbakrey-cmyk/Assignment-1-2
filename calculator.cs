Console.WriteLine("Enter number 1:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the operator:");
string op = Console.ReadLine();

Console.WriteLine("Enter number 2:");
int num2 = int.Parse(Console.ReadLine());

switch (op)
{
    case "+":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;

    case "-":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;

    case "*":
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;

    case "/":
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;

    default:
        Console.WriteLine("Invalid operator");
        break;
}
