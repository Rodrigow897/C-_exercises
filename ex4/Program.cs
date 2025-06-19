using ex4;
using System.Collections;

ArrayList listaPessoas = new ArrayList();


for(int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite os dados da {i} pessoa");

    Console.Write("Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Pessoa pessoa = new(nome, idade);
    listaPessoas.Add(pessoa);
}

Console.WriteLine("\n---- Lista de Pessoas ----");

ExibirLista(listaPessoas);

listaPessoas.Add(new Pessoa("Thomas", 18));
listaPessoas.Add(new Pessoa("Arthur", 29));

Console.WriteLine("\n---- Lista Atuaizada com mais duas pessoas ----");

ExibirLista(listaPessoas);

listaPessoas.RemoveAt(listaPessoas.Count -1);

Console.WriteLine("\n---- Lista apos remover o último elemento ----");

ExibirLista(listaPessoas);
static void ExibirLista(ArrayList listaPessoas)
{
    foreach (Pessoa pessoa in listaPessoas)
    {
        pessoa.Exibir();
    }
}