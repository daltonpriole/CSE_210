//classe filha natação - Semana 07 - Monitoramento de Exercícios
using System;

public class Natacao : Atividade
{
    //Atributos específicos da natação
    private double _nVoltas; // unidade voltas na piscina

    //Construtor
    public Natacao(string nome, int duracao, DateTime data, double nVoltas)
        : base(nome, duracao, data)
    {
        _nVoltas = nVoltas;
    }

    //Getters e Setters
    public double NVoltas
    {
        get { return _nVoltas; }
        set { _nVoltas = value; }
    }

    //Implementação dos métodos abstratos
    public override double ObterDistancia()
    {
        return _nVoltas * 50.0 / 1000.0; // Convertendo voltas para km (assumindo 50m por volta)
    }

    public override double ObterVelocidade()
    {
        return (ObterDistancia() / (_duracao / 60.0)); // Velocidade = Distância / Tempo (em horas)
    }

    public override double ObterRitmo()
    {
        return (_duracao / ObterDistancia()); // Ritmo = Tempo / Distância (minutos por km)
    }
}