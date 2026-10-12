//Classe filha Corrida - Semana 07 - Monitoramento de Exercícios
using System;

public class Corrida : Atividade
{
    //Atributos específicos da corrida
    private double _distancia; // em km

    //Construtor
    public Corrida(string nome, int duracao, DateTime data, double distancia)
        : base(nome, duracao, data)
    {
        _distancia = distancia;
    }

    //Getters e Setters
    public double Distancia
    {
        get { return _distancia; }
        set { _distancia = value; }
    }

    //Implementação dos métodos abstratos
    public override double ObterDistancia()
    {
        return _distancia;
    }

    public override double ObterVelocidade()
    {
        return (_distancia / (_duracao / 60.0)); // Velocidade = Distância / Tempo (em horas)
    }

    public override double ObterRitmo()
    {
        return (_duracao / _distancia); // Ritmo = Tempo / Distância (minutos por km)
    }
}