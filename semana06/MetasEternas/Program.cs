//Programa principal do projeto MetasEternas
//Desenvolvidas as clase e heranças e polimorfismo conforme instruções
//Como parte de criatividade foi criado uma maneira de pontuação e niveis de desenvolvimento das metas do usuario
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