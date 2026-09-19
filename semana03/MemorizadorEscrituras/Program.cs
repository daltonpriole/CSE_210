using System;

//Programa de memorização semana 3
//foi implementado algumas melhorias como: na classe escritura acrescentei um metodo para escolher somente palavra ainda nao ocultadas
//Acrescentado tbem uma classe biblioteca para o usuario poder adicionar escrituras que ele queira decorar 
// e ainda criado um menu para ele escolher qua escritura ele deseja decorar.

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        
        // Adicionando a primeira escritura
        Referencia ref1 = new Referencia("Mateus", 5, 9);
        Escritura esc1 = new Escritura(ref1, "Bem-aventurados os pacificadores, porque serão chamados filhos de Deus.");
        biblioteca.AdicionarEscritura(esc1);

        // Adicionando a segunda escritura para ter escolha
        Referencia ref2 = new Referencia("João", 3, 16);
        Escritura esc2 = new Escritura(ref2, "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito.");
        biblioteca.AdicionarEscritura(esc2);

        // Adicionando a segunda escritura para ter escolha
        Referencia ref3 = new Referencia("Lucas", 19, 10);
        Escritura esc3 = new Escritura(ref3, "Porque o Filho do Homem veio buscar e salvar o que se havia perdido.");
        biblioteca.AdicionarEscritura(esc3);

        Console.Clear();
        biblioteca.ExibirOpcoes(); // Isso vai mostrar: 1. Mateus 5:9 \n 2. João 3:16

        Console.Write("\nDigite o número da escritura que deseja memorizar: ");
        int escolha = int.Parse(Console.ReadLine());

        Escritura escritura = biblioteca.ObterEscritura(escolha);

        Console.Clear();
        
        while (escritura.EstaCompletamenteOculta() == false)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine("Pressione Enter para ocultar palavras aleatórias ou digite 'sair' para encerrar:");
            string input = Console.ReadLine();
            if (input.ToLower() == "sair")
            {
                break;
            }
            escritura.OcultarPalavrasAleatorias(1); // Oculta 1 palavra aleatória
        }

        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());
        Console.WriteLine("Todas as palavras foram ocultadas. Obrigado por usar o Memorizador!");
    }
}