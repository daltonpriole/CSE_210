using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Produtos usando o construtor da sua classe Produto.
        Produto p1 = new Produto("Teclado", 232, 38.50, 5);
        Produto p2 = new Produto("Notebook", 255, 3685.99, 2);
        Produto p3 = new Produto("mouse", 233, 26.90, 10);
        Produto p4 = new Produto("Monitor", 231, 685.90, 4);

        // Criar o primeiro cliente (ex: morando nos EUA para testar o frete barato)
        Endereco end1 = new Endereco("123 Main St", "Miami", "FL", "EUA");
        Cliente cliente1 = new Cliente("John Doe", end1);

        // Criar o segundo cliente (ex: morando no Brasil para testar o frete caro)
        Endereco end2 = new Endereco("Av. Paulista, 1000", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Maria Silva", end2);

        // Lista de produtos do Pedido 1 (Adicione 2 ou 3 produtos aqui)
        List<Produto> listaPedido1 = new List<Produto>();
        listaPedido1.Add(p1);
        listaPedido1.Add(p2);

        // Lista de produtos do Pedido 2 (Adicione os outros produtos aqui)
        List<Produto> listaPedido2 = new List<Produto>();
        listaPedido2.Add(p3);
        listaPedido2.Add(p4);

        // Criar os dois pedidos passando o cliente e a respectiva lista
        Pedido pedido1 = new Pedido(cliente1, listaPedido1);
        Pedido pedido2 = new Pedido(cliente2, listaPedido2);

        // --- PROCESSANDO PEDIDO 1 ---
        Console.WriteLine("----- EXIBINDO PEDIDO 1 -----");
        Console.WriteLine("--- Etiqueta de Embalagem ---");
        Console.WriteLine(pedido1.EtiquetaEmbalagem());

        Console.WriteLine("--- Etiqueta de Envio ---");
        Console.WriteLine(pedido1.EtiquetaEndereco());
        Console.WriteLine($"Taxa de Envio: ${pedido1.CalcTaxaEnvio():F2}");

        // Calculando o preço total do Pedido 1
        double precoTotalP1 = 0;
        foreach (Produto prod in pedido1.Produtos) // Usando a propriedade pública que você criou!
        {
            precoTotalP1 += prod.CalcValorTotal(); // Soma o valor total (preço * quantidade) de cada produto
        }
        precoTotalP1 += pedido1.CalcTaxaEnvio(); // Soma a taxa de envio no final

        Console.WriteLine($"PREÇO TOTAL DO PEDIDO 1: ${precoTotalP1:F2}");
        Console.WriteLine("\n");


        // --- PROCESSANDO PEDIDO 2 ---
        Console.WriteLine("----- EXIBINDO PEDIDO 2 -----");
        Console.WriteLine("--- Etiqueta de Embalagem ---");
        Console.WriteLine(pedido2.EtiquetaEmbalagem());

        Console.WriteLine("--- Etiqueta de Envio ---");
        Console.WriteLine(pedido2.EtiquetaEndereco());
        Console.WriteLine($"Taxa de Envio: ${pedido2.CalcTaxaEnvio():F2}");

        // Calculando o preço total do Pedido 2
        double precoTotalP2 = 0;
        foreach (Produto prod in pedido2.Produtos)
        {
            precoTotalP2 += prod.CalcValorTotal();
        }
        precoTotalP2 += pedido2.CalcTaxaEnvio();

        Console.WriteLine($"PREÇO TOTAL DO PEDIDO 2: ${precoTotalP2:F2}");
    }
}
