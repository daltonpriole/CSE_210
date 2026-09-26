//Classe que comtem os dados do cliente

using System;
using System.Collections.Generic;
using System.Dynamic;

class Cliente
{
    //1.Atributos Privados
    private string _nome;
    private Endereco _endereco;

    //2.Construtores
    public Cliente(string nomeInicial, Endereco enderecoInicial)
    {
        _nome = nomeInicial;
        _endereco = enderecoInicial;
    }
    public string Nome 
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public Endereco Endereco // Tipo Endereco, letra maiúscula
    {
        get { return _endereco; }
        set { _endereco = value; } // Atributo recebe o value
    }


    //3.Metodos Publicos
    public bool MoraEUA()
    {
        return _endereco.verfEUA(); // Chama o método da classe Endereco
    }
}