Console.Write("Digite o tamanho do vetor: ");

int tamanho = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[tamanho];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1} numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

bool loop = true;

while (loop) {
    Console.Write("\nDigite um valor inteiro para procurar no array...: ");
    int adivinhar = Convert.ToInt32(Console.ReadLine());

    if (numeros.Contains(adivinhar)) {
        Console.WriteLine($"\nNumero encontrado {adivinhar}");
    } else
    {
        Console.WriteLine($"\nNumero {adivinhar} não existe no array");
    }

    Console.Write("\nDigite fim para sair ou qualquer outra tecla para continuar: ");
    string fim = Console.ReadLine();

    if (fim == "fim" || fim == "Fim")
    {
        loop = false;
    }
}
