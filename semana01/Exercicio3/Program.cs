using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int counter = 0;
        int guess = -1;
        string continue_game = "s";

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
        do
        {
            int number = random.Next(1, 101);
            guess = -1;
            counter = 0;
            while (guess != number)
            {
                Console.Write("Qual é o seu palpite entre 1 e 100: ");
                guess = int.Parse(Console.ReadLine());
                counter++;
                if (guess < number)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
            }
            Console.WriteLine($"Parabéns! Você acertou o número {number} em {counter} tentativas!");

            Console.WriteLine();
            Console.Write("Deseja jogar novamente? (s/n): ");
            continue_game = Console.ReadLine();
        } while (continue_game == "s");
    Console.WriteLine();
    Console.WriteLine("Obrigado por jogar! Fim do jogo!");
    }
}