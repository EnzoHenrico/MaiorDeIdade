int age;

Console.Write("Digite sua idade: ");
age = int.Parse(Console.ReadLine());

if (age < 0)
{
    Console.WriteLine("Idade inválida.");
}
else
{
    if (age >= 18)
    {
        Console.WriteLine("Você já é maior de idade!");
    }
    else
    {
        Console.WriteLine("Você ainda é menor de idade.");
    }
}