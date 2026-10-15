//Classe filha de metas

using System;

class Eterna : Metas
{
    //Atributos
    private int _realizadas;

    //Construtor e Getters e Setters
    public Eterna(string nome, string descricao, int pontos, int realizadas) : base(nome, descricao, pontos)
    {
        _realizadas = realizadas;
    }

    // Métodos
    public override int RegistrarEvento()
    {
        //Contabilizar para metas eternas
        _realizadas++;
        return Pontos;
    }

    public override bool EstaConcluida()
    {
        //Conclusao para metas eternas
        return false; // Exemplo: metas eternas nunca são concluídas
    }

    public override string ObterDetalhes()
    {
        // Implementação específica para metas eternas
        return $"[ ] Meta Eterna: {Nome} - ({Descricao}) - {Pontos} pontos";
    }

    public override string ObterRepresentacao()
    {
        //Representacao para metas eternas
       return $"MetaEterna|{_nome}|{_descricao}|{_pontos}|{_realizadas}";
    }

}