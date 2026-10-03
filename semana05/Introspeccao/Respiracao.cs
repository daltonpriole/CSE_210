//classe filha de atividade, terapia digital Respiração
using System;

public class Respiracao : Atividades
{
    //1.Atributos Privados/Protected
    

    //2.Construtor
    public Respiracao() : base()
    {
        _nome = "Respiração";
        _descricao = "Atividade de respiração para relaxamento e foco.";
    }


    //3.Métodos Públicos
    public override void Executar()
        {
            DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

            while (DateTime.Now < tempoFinal)
            {
                Console.Write("\nInspire...");
                // Passamos 'true' para indicar que o ritmo vai desacelerar (começa rápido, termina lento)
                ContagemRespiracaoDinamica(4, desacelerar: true);
                Console.WriteLine();

                if (DateTime.Now >= tempoFinal) break;

                Console.Write("Agora expire...");
                ContagemRespiracaoDinamica(4, desacelerar: true);
                Console.WriteLine();
            }
        }
    private void ContagemRespiracaoDinamica(int segundos, bool desacelerar)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);

            // Tempo base padrão para um segundo é 1000ms
            int tempoEsperaMs = 1000;

            if (desacelerar)
            {
                // Ajusta o tempo de espera para criar um efeito de desaceleração
                tempoEsperaMs = (segundos - i + 1) * (4000 / (segundos * (segundos + 1) / 2));
                    
                // Ajuste empírico simples para manter a média próxima de 1 segundo por ciclo:
                if (i == 4) tempoEsperaMs = 500;
                else if (i == 3) tempoEsperaMs = 800;
                else if (i == 2) tempoEsperaMs = 1200;
                else if (i == 1) tempoEsperaMs = 1500;
            }

                Thread.Sleep(tempoEsperaMs);
                Console.Write("\b \b"); // Apaga o número atual
            }
        }
}