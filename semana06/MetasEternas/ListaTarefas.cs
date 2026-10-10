//Classe filha de metas

using System;

class ListaTarefas : Metas
{
    //Atributos
    private int _concluidas;
    private int _total;
    private int _bonus;


    //Construtor e Getters e Setters
    public ListaTarefas(int concluidas, int total, int bonus, string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
        _concluidas = concluidas;
        _total = total;
        _bonus = bonus;
    }


    // Métodos
    public override void RegistrarEvento()
    {
        // Implementação específica para metas eternas
    }

    public override bool EstaConcluida()
    {
        // Implementação específica para metas eternas
        return false; // Exemplo: metas eternas nunca são concluídas
    }

    public override string ObterDetalhes()
    {
        // Implementação específica para metas eternas
        return $"Meta Eterna: {Nome} - {Descricao} - {Pontos} pontos";
    }

    public override string ObterRepresentacao()
    {
        // Implementação específica para metas eternas
        return "[ ] Meta eterna (não concluída)";
    }
       
}