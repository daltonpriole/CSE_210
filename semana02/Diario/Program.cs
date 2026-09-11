using System;

//programa principal - Registro interativo de atividades diárias
//menu do usuario para gerenciar o diario:
//1. Escrever
//2. Exibir
//3. Carregar
//4. Salvar
//5. Sair
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Bem-vindo ao Diario.");
    }
    
}