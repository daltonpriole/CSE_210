//classe filha de Metas 
using System;
class Simples : Metas
{
    //Atributos
    private bool _estaConcluido;

    //Construtor e Getters e Setters
    public Simples(bool estaConcluido, string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
        _estaConcluido = estaConcluido;
    }
    public bool EstaConcluido
    {
        get { return _estaConcluido; }
        set { _estaConcluido = value; }
    }


    // Métodos
    public override void RegistrarEvento()
    {
        _estaConcluido = true;
    }

    public override bool EstaConcluida()
    {
        return _estaConcluido;
    }

    public override string ObterDetalhes()
    {
        return $"Meta Simples: {Nome} - {Descricao} - {Pontos} pontos";
    }

    public override string ObterRepresentacao()
    {
        return _estaConcluido ? "[X] Meta simples concluída" : "[ ] Meta simples pendente";
    }
    
}