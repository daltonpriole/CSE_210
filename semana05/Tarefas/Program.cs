using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Este é o Projeto Tarefas. Play_Semana5");
        Console.WriteLine();

         // Cria um objeto "Tarefa" base
        Tarefa t1 = new Tarefa("Samuel Bennett", "Multiplicação");
        Console.WriteLine(t1.ObterResumo());

        // Agora cria os tarefas das classes derivadas
        TarefaMatematica t2 = new TarefaMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());

        TarefaRedacao t3 = new TarefaRedacao("Mary Waters", "História Européia", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacaoRedacao());
    }
}