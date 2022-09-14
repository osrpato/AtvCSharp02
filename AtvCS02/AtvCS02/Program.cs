Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome}");
Console.Write("Digite o ano de seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Você tem {age} anos. ");

if (age >= 18)
{
    Console.WriteLine("- Ok, você está, AUTORIZADO!! ");
}

else
{
    Console.WriteLine("- Ouve uma discrepância na idade, NEGADO!!");
}