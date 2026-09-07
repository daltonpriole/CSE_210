//Classe Curriculo
using System;
using System.Collections.Generic;

public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos;
    public Curriculo()
    {
        _empregos = new List<Emprego>();
    }

    public void ExibirCurriculo()
    {
        foreach (var emprego in _empregos)
        {
            emprego.ExibirDetalhesEmprego();
            Console.WriteLine(); // Adiciona uma linha em branco entre os empregos
        }
    }
}