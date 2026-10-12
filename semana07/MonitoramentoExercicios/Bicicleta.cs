//Classe Filha Bicicleta - Semana 07 - Monitoramento de Exercícios
using System;

public class Bicicleta : Atividade
{
    //Atributos específicos da bicicleta
    private double _velocidade; // em km/h

    //Construtor
    public Bicicleta(string nome, int duracao, DateTime data, double velocidade)
        : base(nome, duracao, data)
    {
        _velocidade = velocidade;
    }

    //Getters e Setters
    public double Velocidade
    {
        get { return _velocidade; }
        set { _velocidade = value; }
    }

    //Implementação dos métodos abstratos
    public override double ObterDistancia()
    {
        return _velocidade * (_duracao / 60.0); // Distância = Velocidade * Tempo (em horas)
    }

    public override double ObterVelocidade()
    {
        return _velocidade;
    }

    public override double ObterRitmo()
    {
        return (_duracao / _velocidade); // Ritmo = Tempo / Distância (minutos por km)
    }
}