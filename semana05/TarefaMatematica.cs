//Classe Filha ou derivada da classe Tarefa

using System;

public class TarefaMatematica : Tarefa
{
    //1.Atributos 
    private string _capitulo;
    private string _problemas;


    //2.Construtores Publicos
     public string ObterCapitulo()
    {
        return _capitulo;
    }
    public void DefinirNome(string capitulo)
    {
        _capitulo = capitulo;
    }

     public string ObterProblemas()
    {
        return _problemas;
    }
    public void DefinirProblemas(string problemas)
    {
        _problemas = problemas;
    }


    //3.Metodos Publicos
    public string ObterListaDeTarefas()
    {
        return $"{_nomeEstudante} - {_topico} Capitulo:{_capitulo} Problemas: {_problemas}";
    }


}