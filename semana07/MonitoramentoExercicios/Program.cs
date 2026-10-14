using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Este é o Projeto MonitoramentoExercicios.");
        Console.WriteLine("Semana 07 - Monitoramento de Exercícios");
        Console.WriteLine("=========================================");
        Console.WriteLine();
        // Criando instâncias das atividades
        Atividade corrida = new Corrida("João", 30, DateTime.Now, 5.0); // 5 km em 30 minutos
        Atividade bicicleta = new Bicicleta("Maria", 45, DateTime.Now, 20.0); // 20 km em 45 minutos
        Atividade natacao = new Natacao("Pedro", 60, DateTime.Now, 10.0); // 10 voltas em 60 minutos

        // Exibindo resumos das atividades
        Console.WriteLine("\nResumo das atividades:");
        Console.WriteLine($"Corrida: {corrida.ExibirResumo()}");
        Console.WriteLine($"Bicicleta: {bicicleta.ExibirResumo()}");
        Console.WriteLine($"Natação: {natacao.ExibirResumo()}");
        
    }
}