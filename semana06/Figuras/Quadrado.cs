//Classe filha de Figura 

using System;

class Quadrado : Figura
{
    //1.Atributos
    private double _lado;

    //2.Construtor
    public Quadrado(string cor, double lado) : base(cor)
    {
        _lado = lado;
    }

    //3.Métodos
    public override double ObterArea()
    {
        return _lado * _lado;
    }
}