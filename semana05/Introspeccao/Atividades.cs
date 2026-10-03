//Classe Pai das atividades de terapia digital
using System;
public class Atividades
{
    // Propriedades e métodos comuns a todas as atividades

    //1.Atributos Privados/Protected
    protected string _nome;
    protected string _descricao;
    protected int _duracao; // duração em segundos


    //2.Construtor
    public Atividades()
    {
        _nome = "";
        _descricao = "";
        _duracao = 0;
    }


    //3.Métodos Públicos
    public virtual void Executar()
    {
        
    }
    public void ExibirMsgInicial()
    {
        Console.Clear();
        Console.WriteLine($"=== Bem-vindo à Atividade: {_nome} ===");
        Console.WriteLine($"\n{_descricao}");
        Console.Write("\nPor favor, insira a duração da atividade em segundos: ");
            
        if (int.TryParse(Console.ReadLine(), out int tempo))
        {
            _duracao = tempo;
        }

        Console.Clear();
        Console.WriteLine("Prepare-se para começar...");
        ExibirContagemRegressiva(3);
        Console.WriteLine();
    }
    public void ExibirMsgFinal()
    {
        Console.WriteLine("\nMuito bem! Você concluiu a atividade.");
        ExibirProgresso(3);
        Console.WriteLine($"Você completou a atividade \"{_nome}\" por {_duracao} segundos.");
        ExibirProgresso(4);
    }
    public void ExibirProgresso(int segundos)
    {
         // Exibe uma animação simples de carregamento (spinner) enquanto o tempo passa
            DateTime tempoFinal = DateTime.Now.AddSeconds(segundos);
            int contador = 0;
            string[] animacao = { "|", "/", "-", "\\" };

            while (DateTime.Now < tempoFinal)
            {
                Console.Write(animacao[contador % 4]);
                Thread.Sleep(250);
                Console.Write("\b \b"); // Apaga o caractere anterior
                contador++;
            }
    }
    public void ExibirContagemRegressiva(int segundos)
    {
         for (int i = segundos; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Apaga o número atual na tela para o próximo aparecer no mesmo lugar
            }
    }
}