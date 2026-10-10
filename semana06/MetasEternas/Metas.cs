//Classe pai Metas 

using System;

public abstract class Metas
{
    //Atributos
    protected string _nome;
    protected string _descricao;
    protected int _pontos;

    //Construtor / Getters e Setters
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public string Descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }
    public int Pontos
    {
        get { return _pontos; }
        set { _pontos = value; }
    }
    public Metas(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public abstract void RegistrarEvento();

    public abstract bool EstaConcluida();

    public abstract string ObterDetalhes();

    public abstract string ObterRepresentacao();
}