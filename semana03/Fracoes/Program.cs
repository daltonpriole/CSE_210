using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Olá, Mundo! Este é o Projeto Fracoes.");

        Fracao f1 = new Fracao();
        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        Fracao f2 = new Fracao(6);
        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        Fracao f3 = new Fracao(1, 4);
        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        Fracao f4 = new Fracao(2, 3);
        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());
    }
}