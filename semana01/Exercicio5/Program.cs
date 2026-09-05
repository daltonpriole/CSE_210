using System;

// Tarefa de Funções - Exercício 5 em C#
class Program
{
    static void Main(string[] args)
    {
        static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao programa de boas-vindas!");
        }
        ExibirBoasVindas();

        static void PerguntarNomeUsuario()
        {
            Console.Write("Por favor, digite seu nome: ");
            string nome = Console.ReadLine();
        }
        PerguntarNomeUsuario();

        static int PerguntarNumeroFavorito(int numeroFavorito)
        {
            Console.Write("Digite seu número favorito: ");
            numeroFavorito = Convert.ToInt32(Console.ReadLine());
            return numeroFavorito;
        }
        
        static void ElevarAoQuadrado(int numero)
        {
            int resultado = numero * numero;
            Console.WriteLine($"O número {numero} elevado ao quadrado é: {resultado}");
        }

        static void ExibirResultado()
        {
            //Chama a funcao PerguntarNumeroFavorito do usuário e chama a função para ElevarAoQuadrado
            
            int numeroFavorito = PerguntarNumeroFavorito(0);
            ElevarAoQuadrado(numeroFavorito);
        }
        ExibirResultado();

    }
} 