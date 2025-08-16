using ExeContaBancaria;

Console.WriteLine("\nConta Corrente: Numero: 111 Titular: Maria");

Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Deposito(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");



Console.WriteLine("\nConta Poupança : Numero: 222 Titular: josé");
ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 222;
contapoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1.000,00");
contapoupanca.Deposito(1000);
Console.WriteLine("Sacando R$ 100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta : {contapoupanca.Saldo.ToString("c")}");



Console.WriteLine("\nConta Poupança : Numero: 333 Titular: Rodrigo");
ContaInvestimento containvestimento = new();
contapoupanca.Numero = 333;
contapoupanca.Titular = "Rodrigo";
Console.WriteLine("Depositando R$ 1.000,00");
containvestimento.Deposito(1000);
Console.WriteLine("Sacando R$ 100,00");
containvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta : {containvestimento.Saldo.ToString("c")}");

Console.WriteLine("Sacando R$ 2.000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {containvestimento.Saldo.ToString("c")}");
