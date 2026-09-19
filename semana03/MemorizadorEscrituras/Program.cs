using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Este é o Projeto MemorizadorEscrituras.");

        // Criar uma referência
        Referencia referencia = new Referencia("Mateus", 5, 9);
        // Criar uma escritura
        Escritura escritura = new Escritura(referencia, "Bem-aventurados os mansos, porque herdarão a terra.");

        while (escritura.EstaCompletamenteOculta() == false)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine("Pressione Enter para ocultar palavras aleatórias ou digite 'sair' para encerrar:");
            string input = Console.ReadLine();
            if (input.ToLower() == "sair")
            {
                break;
            }
            escritura.OcultarPalavrasAleatorias(2); // Oculta 2 palavras aleatórias
        }
        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());
        Console.WriteLine("Todas as palavras foram ocultadas. Obrigado por usar o Memorizador!");
    }
}