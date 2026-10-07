//Exercicio Semana 06 - Polimorfismo

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Este é o Projeto Figuras(Polimorfismo).");
        Console.WriteLine();
        //Instanciando objetos com lista
        List<Figura> figuras = new List<Figura>();
        //adicionando objetos à lista
        figuras.Add(new Circulo("Vermelho", 5.0));
        figuras.Add(new Retangulo("Azul", 4.0, 6.0));
        figuras.Add(new Quadrado("Verde", 3.0));

        //Exibindo informações
        foreach (Figura figura in figuras)
        {
            Console.WriteLine($"{figura.GetType().Name}: Cor = {figura.obterCor()}, Área = {figura.ObterArea():F2}");
        }
    }
       
}