using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Curriculo.");
        Console.WriteLine();

        // Criando instâncias da classe Empregos
        Emprego emprego1 = new Emprego();
        emprego1._empresa = "Microsoft";
        emprego1._cargo = "Engenheiro de Software";
        emprego1._anoInicio = 2020;
        emprego1._anoFim = 2023;

        // Criando uma segunda instância da classe Emprego
        Emprego emprego2 = new Emprego();
        emprego2._empresa = "Apple";
        emprego2._cargo = "Desenvolvedor Web";
        emprego2._anoInicio = 2018;
        emprego2._anoFim = 2020;

        // Criando uma instância da classe Curriculo e adicionando os empregos
        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Dalton";
        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        //Exibindo os detalhes dos empregos
        meuCurriculo.ExibirCurriculo();
        Console.WriteLine(); // Adiciona uma linha em branco
    }
}