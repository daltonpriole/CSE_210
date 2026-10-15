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
   
    // Métodos
    public override int RegistrarEvento()
    {   
        if (!_estaConcluido)
        {
            _estaConcluido = true;
            return Pontos; // Retorna os pontos da meta simples
        }
        else
        {
            Console.WriteLine("Esta meta já foi concluída.");
            return 0; // Retorna 0 se a meta já estiver concluída
        }
    }

    public override bool EstaConcluida()
    {
        if (Pontos != 0)
            return _estaConcluido = false;
        else
            return _estaConcluido = true;
    }

    public override string ObterDetalhes()
    {
        string status = _estaConcluido ? "[X]" : "[ ]";
        return $"{status} Meta Simples: {Nome} - ({Descricao})";
    }

    public override string ObterRepresentacao()
    {
        return $"MetaSimples|{_nome}|{_descricao}|{_pontos}|{_estaConcluido}";
    }
    
}