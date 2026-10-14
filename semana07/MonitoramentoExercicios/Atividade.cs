//Classe pai tarefa Semana 07 - Monitoramento de Exercícios
using System;

public abstract class Atividade
{
    //Atributos
    protected string _nome;
    protected int _duracao; //em minutos
    protected DateTime _data;

    //Construtor / Getters e Setters
    public Atividade(string nome, int duracao, DateTime data)
    {
        _nome = nome;
        _duracao = duracao;
        _data = data;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public int Duracao
    {
        get { return _duracao; }
        set { _duracao = value; }
    }

    public DateTime Data
    {
        get { return _data; }
        set { _data = value; }
    }

    //Método abstrato para exibir resumo da atividade
    //dia mes ano Atividade (duracao): Distância x km, Velocidade: x km/h, Ritmo: x min por km
     public string ExibirResumo()
    {
        return _data.ToString("dd/MM/yyyy") + " " + _nome + " (" + _duracao + " min): " + ObterDistancia() + " km, " + ObterVelocidade() + " km/h, " + ObterRitmo() + " min/km";
    }

    public abstract double ObterDistancia();
    public abstract double ObterVelocidade();
    public abstract double ObterRitmo();

}