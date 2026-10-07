//Classe filha de Figura 

using System;

class Circulo : Figura
{
    //1.Atributos
    private double _raio;

    //2.Construtor
    public Circulo(string cor, double raio) : base(cor)
    {
        _raio = raio;
    }

    //3.Métodos
    public override double ObterArea()
    {
        return Math.PI * _raio * _raio;
    }
}