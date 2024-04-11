using Aula05;

ContaCorrente c1 = new ContaCorrente("1400", "0041784-0");
ContaCorrente c2 = new ContaCorrente("0417", "20923-6");



c1.Depositar(300);
c1.Transferir(200, c2);

Console.WriteLine(c1.Saldo);
Console.WriteLine(c2.Saldo);