using System;

namespace DesafioAula5.Domain
{
   

    public class ContaCorrente
    {
        //private string? _agencia;
        private string? _conta;
        private decimal? _valor;
        //private decimal? _saldo;
        //private string? _documento;
        private int _numContas = 1;
        private int _op = 0;
        private int _p = 0;
        private int _cs = 0;

        object[,] cadastro = new object[10, 4];

        public ContaCorrente() { 
      
        }

        public void Menu()
        {
            do
            {
                Console.Write($"Jumpstart Bank - {_numContas - 1} Contas cadastradas\n\n" +
                    "Digite a Opção desejada:\n" +
                    "1. Abrir Conta\n" +
                    "2. Saldo\n" +
                    "3. Sacar\n" +
                    "4. Depositar\n" +
                    "5. Transferir\n" +
                    "6. Sair\n\n>");

                _op = int.Parse(Console.ReadLine());
                Console.Clear();

                if (_op == 1)
                {
                    AbreConta();
                }
                if (_op == 2)
                {
                    Saldo();
                }
                else if (_op == 4)
                {
                    
                    Depositar();

                }
            }
            while (_op != 5);
        }
        public void AbreConta()
        {
            if (_numContas <= 10)
            {
                Console.WriteLine($"Conta Número {_numContas}");
                Console.Write("Digite Agência: ");
                cadastro[_numContas, 0] =  Console.ReadLine();
                Console.Write("Digite Conta: ");
                cadastro[_numContas, 1] = Console.ReadLine();
                Console.Write("Digite Documento: ");
                cadastro[_numContas, 2] = Console.ReadLine();                
                _numContas++;
                Console.Write("\nConta cadastrada com sucesso, Tecle algo para voltar menu principal");
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

        public void Saldo()
        {
            Console.Write($"Digite o número da conta a ser consultada: ");
            _cs = int.Parse(Console.ReadLine());            
            if (cadastro[_cs, 3] != null)
            {
                Console.WriteLine($"O saldo da conta {_cs} é de {cadastro[_cs, 3]}, Tecle algo para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Conta não possui saldo, Tecle algo para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Depositar()
        {
            Console.Write("Digite o número da conta que receberá o depósito: ");
            _p = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor que deseja depositar: ");
            _valor = decimal.Parse(Console.ReadLine());

            if (_valor >= 0)
            {
                cadastro[_p, 3] = _valor;
                Console.Write($"\n{cadastro[_p, 3]}, foi depositado na conta {_p} com sucesso! Tecle algo para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Transferir()
        {

        }

    }
}
