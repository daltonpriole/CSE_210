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
    public override int RegistrarEvento()
    {
        //Logica Registrar eventos para metas eternas
        if (_concluidas < _total)
        {
            _concluidas++;
            if (_concluidas == _total)
            {
                return Pontos + _bonus; // Retorna os pontos da meta de lista de tarefas com bônus
            }
            else
            {
                return Pontos; // Retorna os pontos da meta de lista de tarefas sem bônus
            }
        }
        else
        {
            Console.WriteLine("Esta meta já foi concluída.");
        }
        return 0;
    }

    public override bool EstaConcluida() => _concluidas >= _total;

    public override string ObterDetalhes()
    {
        // Logica Obter detalhes para metas eternas
        string status = EstaConcluida() ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao}) -- Progresso: {_concluidas}/{_total}";
    }

    public override string ObterRepresentacao()
        {
            return $"MetaDeListaDeTarefas|{_nome}|{_descricao}|{_pontos}|{_concluidas}|{_total}|{_bonus}";
        }
       
}