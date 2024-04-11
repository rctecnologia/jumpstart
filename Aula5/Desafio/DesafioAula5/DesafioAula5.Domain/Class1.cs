namespace DesafioAula5.Domain
{
   

    public class ContaCorrente
    {
        private string _agencia;
        private string _conta;
        private string _documento;
        private int numContas = 1;
        private int op = 0;

        string[,] cadastro = new string[10, 3];

        public ContaCorrente() { 
      
        }

        public void Menu()
        {
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
                    AbreConta();
                }
            }
            while (op != 5);
        }
        public void AbreConta()
        {
            if (numContas <= 10)
            {
                Console.WriteLine($"Conta Número {numContas}");
                Console.Write("Digite Agência: ");
                cadastro[numContas, 0] =  Console.ReadLine();
                Console.Write("Digite Conta: ");
                cadastro[numContas, 1] = Console.ReadLine();
                Console.Write("Digite Documento: ");
                cadastro[numContas, 2] = Console.ReadLine();                
                numContas++;
                Console.Write("\nConta cadastrada com sucesso, Digite algo para voltar menu principal");
                Console.ReadKey();
                Console.Clear();
                }
            else
            {
                Console.WriteLine("O limite de cadastro de contas foi atingido!");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
