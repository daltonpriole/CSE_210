//Classe Emprego 
using System;

public class Emprego
{
    public string _empresa; 
    public string _cargo;  
    public int _anoInicio;
    public int _anoFim;
     
    public void ExibirDetalhesEmprego()
    {
        Console.WriteLine($"Empresa: {_empresa}");
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Ano de Início: {_anoInicio}");
        Console.WriteLine($"Ano de Fim: {_anoFim}");
    }
}