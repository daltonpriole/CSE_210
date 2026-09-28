//Classe base ou classe Pai que deve conter nome topico e o metodo Obter Resumo

using System;

//Nome da Classe
public class Tarefa
{
    //1. Atributos Privados
    protected string _nomeEstudante;
    protected string _topico;


    //2. Construtores Publicos
    public string ObterNome()
    {
        return _nomeEstudante;
    }
    public void DefinirNome(string nomeEstudante)
    {
        _nomeEstudante = nomeEstudante;
    }

     public string ObterTopico()
    {
        return _topico;
    }
    public void DefinirTopico(string topico)
    {
        _topico = topico;
    }


    //3. Metodos Publicos
    public string ObterResumo()
    {
        return $"Nome: {_nomeEstudante} Topico: {_topico}";
    }


}