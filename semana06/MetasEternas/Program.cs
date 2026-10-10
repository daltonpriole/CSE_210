using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Este é o Projeto MetasEternas.");
        Console.WriteLine();
        GerenciadorMetas gerenciador = new GerenciadorMetas();
        gerenciador.Iniciar();

    }
}