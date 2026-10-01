//Classe Pai das atividades de terapia digital
using System;
public class Atividades
{
    // Propriedades e métodos comuns a todas as atividades

    //1.Atributos Privados/Protected
    protected string _nome;
    protected string _descricao;
    protected int _duracao; // duração em minutos


    //2.Construtor
    public Atividades(string nome, string descricao, int duracao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = duracao;
    }


    //3.Métodos Públicos
    public virtual void Executar()
    {
        
    }
    public void ExibirMsgInicial()
    {
        Console.WriteLine($"Bem-vindo à atividade: {_nome}");
        Console.WriteLine($"Mensagem: {_descricao}");
    }
    public void ExibirMsgFinal()
    {
        Console.WriteLine($"Parabéns! Você concluiu a atividade: {_nome}");
        Console.WriteLine($"Mensagem: {_descricao}");
    }
    public void ExibirProgresso(int segundos)
    {
        Console.WriteLine($"Progresso: {segundos} segundos concluído.");
    }
    public void ExibirContagemRegressiva(int segundos)
    {
        Console.WriteLine($"Contagem regressiva: {segundos} segundos restantes.");
    }
}