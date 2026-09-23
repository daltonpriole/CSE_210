//Classe para cadastrar os videos

using System;
using System.Runtime.Versioning;

public class Video
{
    //1. Atributos
    public string _titulo;
    public string _autor;
    public int _duracao;
    public List<Comentario> _comment;

    //2.Construtor
    public Video()
    {
        _comment = new List<Comentario>();
    }

    //3.Metodo
    public int NumComment()
    {
        return _comment.Count;
    }
}