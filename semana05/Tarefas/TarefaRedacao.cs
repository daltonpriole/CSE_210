//Classe Filha ou derivada  da classe Tarefa

using System;

public class TarefaRedacao : Tarefa
{
    //1.Atributos
    private string _titulo;


    //2.Construtores
     public TarefaRedacao(string nomeEstudante, string topico, string titulo)
        : base(nomeEstudante, topico)
    {
        // Aqui definimos quaisquer variáveis específicas da classe TarefaDeRedacao
        _titulo = titulo;
    }
    public string ObterTitulo()
    {
        return _titulo;
    }
    public void DefinirTitulo(string titulo)
    {
        _titulo = titulo;
    }


    //3.Metodos
    public string ObterInformacaoRedacao()
    {
        return $"{_nomeEstudante} - {_topico} Titulo:{_titulo}, por {_nomeEstudante}";
    }


}