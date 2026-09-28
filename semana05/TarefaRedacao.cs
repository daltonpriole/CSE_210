//Classe Filha ou derivada  da classe Tarefa

using System;

public class TarefaRedacao : Tarefa
{
    //1.Atributos
    private string _titulo;


    //2.Construtores
    public string ObterTitulo()
    {
        return _titulo;
    }
    public void DefinirTitulo(string titulo)
    {
        _titulo = titulo;
    }


    //3.Metodos
    public string ObterInformacoesRedacao()
    {
        return $"{_nomeEstudante} - {_topico} Titulo:{_titulo}, por {_nomeEstudante}";
    }


}