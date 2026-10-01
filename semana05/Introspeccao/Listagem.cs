//Classe filha de Atividade, terapia digital Listagem
using System;

public class Listagem : Atividades
{
    //1.Atributos Privados/Protected
    private int _contador;
    private List<string> _pergunta;


    //2.Construtor
    public Listagem(string nome, string descricao, int duracao, List<string> perguntas)
        : base(nome, descricao, duracao)
    {
        _pergunta = perguntas;
        _pergunta.Add("Pergunta de listagem 1");
        _contador = 0;
    }


    //3.Métodos Públicos
    public override void Executar()
    {
        Console.WriteLine($"Iniciando a atividade de listagem: {_nome}");
        Console.WriteLine($"Descrição: {_descricao}");
        Console.WriteLine($"Duração: {_duracao} minutos");
    
        // Lógica para iniciar a atividade de listagem
    }
    public void ObterPerguntaRd()
    {
        // Lógica para obter a pergunta de listagem
        string perguntaListagem = "Pergunta de listagem";
        Console.WriteLine($"Pergunta de Listagem: {perguntaListagem}");
        _contador++;
    }
    public List<string> ObterListUser()
    {
        // Lógica para obter a lista de perguntas
        return _pergunta;
    }
}