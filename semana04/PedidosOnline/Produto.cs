//Classe que contem as informacoes do prduto

using System;

class Produto
{
    //1.Atributos Privados
    private string _nome;
    private int _id;
    private double _preco;
    private int _qtde;

    //2.Construtores
    public Produto (string nome, int id, double preco, int qtde)
    {
        _nome = nome;
        _id = id;
        _preco = preco;
        _qtde = qtde;
    }
    public double Preco
    { 
        get
        {
            return _preco;
        }
        set
        {
            if (value < 0)
            {
                _preco = 0;
            }
            else
            {
                _preco = value;
            }
        }
    }
    public int Qtde
    { 
        get
        {
            return _qtde;
        }
        set
        {
            if (value < 0)
            {
                _qtde = 0;
            }
            else
            {
                _qtde = value;
            }
        }
    }
    public string Nome 
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }


    //3.Metodos Publicos
    public double CalcValorTotal()
    {
        return _preco * _qtde;
    }
    
}