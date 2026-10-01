//classe filha de atividade, terapia digital Respiração
using System;

public class Respiracao : Atividades
{
    //1.Atributos Privados/Protected
    

    //2.Construtor
    public Respiracao(string nome, string descricao, int duracao)
        : base(nome, descricao, duracao)
    {
       
    }


    //3.Métodos Públicos
    public override void Executar()
    {
        Console.WriteLine($"Iniciando a atividade de respiração: {_nome}");
        Console.WriteLine($"Descrição: {_descricao}");
        Console.WriteLine($"Duração: {_duracao} minutos");
    
        // Lógica para iniciar a atividade de respiração
    }
}