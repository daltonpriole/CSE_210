//Classe filha de metas

using System;

class Eterna : Metas
{
    //Atributos


    //Construtor e Getters e Setters
    public Eterna(string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
        
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