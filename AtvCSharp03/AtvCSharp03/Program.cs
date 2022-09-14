int num1 = 0; int num2 = 0;

Console.WriteLine(" Calculadora em --> C#\r");

Console.WriteLine("digite um número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite outro número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("escolha uma opção da lista a seguir:");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write("escolha um ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"seu resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"seu resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"seu resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"seu resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.Write("pressione qualquer tecla para fechar o terminal...");
Console.ReadKey();