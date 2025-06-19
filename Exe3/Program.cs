float[,] notas = new float[2, 5];

for (int i = 0; i < notas.GetLength(0); i++)
{
    Console.WriteLine($"Digite a nota dos 5 alunos do grupo {i+1}\n" );
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.Write($"Diite a nota do aluno {j+1}: ");
        notas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}


for (int i = 0; i < notas.GetLength(0); i++)
{
    Console.Write($"\nnotas do grupo {i+1} :");
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.Write(notas[i,j] + " ");
    }
    Console.WriteLine("\n");
}
