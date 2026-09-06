using System;

class Program
{
    // Esse programa solicita a nota do aluno de 0 a 100 e devolve a nota conceitual de A até F
    // Realizado o adicional de sinais + se o segundo digito for maior ou igual a 7 e - se o segundo digito for menor ou igual a 3
    // Acrescetado a condição de aprovado ou nao.
    static void Main(string[] args)
    {
        int nota;
        string sinal = "";
        string conceito = "";
        Console.Write("Digite a nota do aluno (0-100): ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 90)
            conceito = "A";
        else if (nota >= 80)
            conceito = "B";
        else if (nota >= 70)
            conceito = "C";
        else if (nota >= 60)
            conceito = "D";
        else
            conceito = "F";

        if (nota % 10 >= 7)
            sinal = "+";
        else if (nota % 10 <= 3)
            sinal = "-";

        Console.WriteLine($"Sua nota é {conceito}{sinal}");
        
        if (nota >= 70)
        {
            Console.WriteLine("Você passou!");
        }
        else
        {
            Console.WriteLine("Mais sorte da próxima vez!");
        }
    }
}