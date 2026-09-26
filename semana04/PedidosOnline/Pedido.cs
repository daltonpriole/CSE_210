//Classe que unirá as informacoes de uma compra com os dados do cliente e produto

using System;
using System.Collections.Generic;

class Pedido
{
    //1.Atributos Privados
    private Cliente _cliente;
    private List<Produto> _produto;


    //2.Construtores
    public Pedido(Cliente cliente, List<Produto> produtos)
    {
        _cliente = cliente;
        _produto = produtos;
    }

    public Cliente Cliente
    {
        get{ return _cliente; }
        set{ _cliente = value; }
    }

    public List<Produto> Produtos
    {
        get{ return _produto;}
        set{ _produto = value; }
    }


    //3.Metodos Publicos
    public string EtiquetaEndereco()
    {
        return _cliente.Endereco.endCompleto();
    }

    public double CalcTaxaEnvio()
    {
        if (_cliente.MoraEUA())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }
    public string EtiquetaEmbalagem()
    {
        // 1. Criamos um texto vazio para começar a guardar os nomes
        string textoFinal = "";

        // 2. O foreach lê: "Para cada 'p' (um produto) dentro da lista '_produto'"
        foreach (Produto p in _produto)
        {
            // 3. Pegamos o nome do produto atual usando a propriedade 'Nome' que você criou 
            // e somamos (+=) ao nosso texto final, junto com uma quebra de linha (\n)
            textoFinal += $"Produto: {p.Nome}\n";
        }

        // 4. No final de tudo, retornamos o texto completo acumulado
        return textoFinal;
    }

}