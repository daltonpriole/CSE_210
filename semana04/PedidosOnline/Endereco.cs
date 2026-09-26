// Classe endereço responsavel em guardar a localizaçao

using System;
using System.Reflection.Metadata.Ecma335;

class Endereco
{
    //1. Atributos Privados
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    //2. Construtores
    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }
        // 3. Propriedades Públicas (O Encapsulamento)
    public string Rua
    {
        get { return _rua; }
        set { _rua = value; }
    }

    public string Cidade
    {
        get { return _cidade; }
        set { _cidade = value; }
    }
    public string Estado
    {
        get{ return _cidade; }
        set{ _cidade = value; }
    }
    public string Pais
    {
        get{ return _pais; }
        set{ _pais = value;}
    }


    //3. Metodos Publicos
    public bool verfEUA()
    {
        if (_pais == "EUA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string endCompleto()
    {
        return  $"Rua: {_rua}\n"+
                $"Cidade: {_cidade}\n"+
                $"Estado: {_estado}\n"+
                $"País: {_pais}";
    }

}