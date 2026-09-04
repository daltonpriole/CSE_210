using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu primeiro nome? ");
        string firstName = Console.ReadLine();

        Console.Write("Qual é o seu Sobrenome? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Seu Nome é {lastName}, {firstName} {lastName}!");
    }
}