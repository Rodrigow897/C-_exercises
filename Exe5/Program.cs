using Exe5;

List<Produto> listaProdutos =
[
    new Produto("Clips", 3.95m),
    new Produto("Caneta", 5.99m),
    new Produto("Lápis", 4.15m),
    new Produto("Estojo", 6.99m),
    new Produto("Caderno", 7.55m),
];

Console.WriteLine("-- Lista de produtos --");
ExibirCalculo(listaProdutos);

Console.WriteLine("\n-- Lista atualizada com mais um produto --");
listaProdutos.Add(new Produto("Mochila", 22.44m));
ExibirCalculo(listaProdutos);

Console.WriteLine("\n-- Lista ordenada --");

List<Produto> listaordenada = listaProdutos.OrderBy(p => p.Nome).ToList();
ExibirCalculo(listaordenada);

Console.WriteLine("\n-- Produtos com preços inferior a R$ 5.00");

foreach (Produto p in listaordenada)
{
    if(p.Preco < 5.00m)
    {
        Console.WriteLine($"Nome: {p.Nome} -- Preço: R$ {p.Preco}");
    }
}

bool verif = listaordenada.Any(p => (p.Nome ?? "").Equals("estojo", StringComparison.CurrentCultureIgnoreCase));
if(verif)
{
    Console.WriteLine("\nTem estojo na lista!");
} else
{
    Console.WriteLine("\nNão tem estojo na lista!");
}
    static void ExibirCalculo(List<Produto> listaProdutos)
    {
        decimal total = 0;
        decimal media = 0;
        foreach (Produto p in listaProdutos)
        {
            p.Exibir();
            total += p.Preco;
            media = total / listaProdutos.Count;
        }

        Console.WriteLine($"\nTotal de produtos na lista: {listaProdutos.Count}");
        Console.WriteLine($"Soma total dos preços: R$ {total}");
        Console.WriteLine($"Média total dos preços: R$ {Math.Round(media, 2)}\n");
    }