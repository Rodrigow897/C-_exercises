string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pessego", "Amora" };

//letra a
Exibir(frutas);

Console.WriteLine($"contem {frutas.Count()} frutas.");

//letra b
Console.WriteLine($"{frutas[1]}, {frutas[frutas.Length - 2]}\n");

//letra c
frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Exibir(frutas);

static void Exibir(string[] frutas)
{
    foreach (var item in frutas)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\n");
}

//letra d
Console.WriteLine("Lista ordenada:");
Array.Sort(frutas);
Exibir(frutas);

//letra e
Console.WriteLine("Lista inversa:");
Array.Reverse(frutas);
Exibir(frutas);