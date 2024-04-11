using DesafioAula5.Domain;

int op = 0;
ContaCorrente contaCorrente = new ContaCorrente();

do
{
    Console.Write("Jumpstart Bank\n\n" +
        "Digite a Opção desejada:\n" +
        "1. Abrir Conta\n" +
        "2. Sacar\n" +
        "3. Depositar\n" +
        "4. Transferir\n" +
        "5. Sair\n\n>");

    op = int.Parse(Console.ReadLine());
    Console.Clear();

    if (op == 1)
    {
        contaCorrente.AbreConta();
    }
}
while (op != 5);

