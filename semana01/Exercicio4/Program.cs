using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Digite um numero para nossa lista ou 0 pra finalizar a lista: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers_list.Add(number);
            }
        }
        if (number == 0)
        {
            Console.WriteLine();
            Console.WriteLine("A lista de números é: " + string.Join(", ", numbers_list));
            //Agora vamos calcular a soma dos números da lista
            Console.WriteLine();
            int total_sum = numbers_list.Sum();
            Console.WriteLine("A soma dos números da lista é: " + total_sum);
            // Agora vamos calcular a média dos números da lista
            double average = numbers_list.Count > 0 ? (double)total_sum / numbers_list.Count : 0;
            Console.WriteLine("A média dos números da lista é: " + average);
            //Agora vamos encontrar o maior número da lista
            if (numbers_list.Count > 0)
            {
                int max_number = numbers_list.Max();
                Console.WriteLine("O maior número da lista é: " + max_number);
            }
            else
            {
                Console.WriteLine("A lista está vazia, não há números para encontrar o maior.");
            }
            //Agora vamos encontrar o menor número positivo da lista
            var positive_numbers = numbers_list.Where(n => n > 0);
            if (positive_numbers.Any())
            {
                int min_positive_number = positive_numbers.Min();
                Console.WriteLine("O menor número positivo da lista é: " + min_positive_number);
            }
            else
            {
                Console.WriteLine("Não há números positivos na lista.");
            }
            Console.WriteLine();
            //Agora vamos reordenar a lista em ordem crescente
            var sorted_list = numbers_list.OrderBy(n => n);
            Console.WriteLine("A lista de números Reordenada é: " + string.Join(", ", sorted_list));
            //Agora vamos calcular a quantidade de números na lista
            Console.WriteLine("A quantidade de números na lista é: " + numbers_list.Count);
        }
    }
}