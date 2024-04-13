using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace DesafioAula5.Domain
{


    public class ContaCorrente
    {
        private decimal? _valor;
        private int _numContas = 1;
        private int _op = 0;
        private int _p = 0;
        private int _cs = 0;
        private decimal? _swap = 0;
        private int? _t1 = 0;
        private int? _t2 = 0;

        object[,] cadastro = new object[10, 4];

        public ContaCorrente() {

        }

        public void Menu()//método que apresenta o menu pricipal e chama os métodos correspondentes aos números.
        {
            do
            {
                Console.Write($"Jumpstart Bank - {_numContas - 1} Conta(s) cadastradas\n\n" +
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
                if (_op == 3)
                {
                    Saque();
                }
                if (_op == 4)
                {
                    Depositar();
                }
                if ( _op == 5)
                {
                    Transferir();
                }
            }
            while (_op != 6);
        }
        public void AbreConta()//método de abertura de contas - funcionando
        {
            if (_numContas <= 10)
            {
                Console.WriteLine($"Conta Número {_numContas}");
                Console.Write("Digite Agência: ");
                cadastro[_numContas, 0] = Console.ReadLine();
                Console.Write("Digite Conta: ");
                cadastro[_numContas, 1] = Console.ReadLine();
                Console.Write("Digite Documento: ");
                cadastro[_numContas, 2] = Console.ReadLine();
                _numContas++;
                Console.Write("\nConta aberta com sucesso, Tecle algo para voltar menu principal");
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

        public void Saldo()//método de verificação de saldo da conta específicada - funcionando
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

        public void Saque()//método que implementa a função de saque - funcionando
        {
            Console.Write($"Digite o número da conta que deseja sacar: ");
            _p = int.Parse(Console.ReadLine());
            if (cadastro[_p, 3] != null)
            {
                Console.WriteLine($"O saldo da conta {_p} é de {cadastro[_p, 3]}, Quanto deseja sacar?");
                _valor = decimal.Parse(Console.ReadLine());
                _swap = (decimal?)cadastro[_p, 3];
                cadastro[_p, 3] = _swap - _valor;
                Console.WriteLine($" Saque realizado com suceso. Seu novo saldo é de {cadastro[_p, 3]}, tecle qualquer tecla para voltar ao menu principal...");
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

        public void Depositar() //método que imprementa a função de depósito - funcionando
        {
            Console.Write("Digite o número da conta que receberá o depósito: ");
            _p = int.Parse(Console.ReadLine());
            if (cadastro[_p, 0] != null)
            {
                Console.Write("Digite o valor que deseja depositar: ");
                _valor = decimal.Parse(Console.ReadLine());

                if (_valor >= 0)
                {
                    if (cadastro[_p, 3] != null)
                    {
                        _swap = (decimal?)cadastro[_p, 3];
                        cadastro[_p, 3] = _swap + _valor;
                        Console.Write($"\n{_valor}, foi depositado na conta {_p} com sucesso! Seu novo saldo é de {cadastro[_p, 3]}. Tecle algo para voltar ao menu principal...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        cadastro[_p, 3] = _valor;
                        Console.Write($"\n{_valor}, foi depositado na conta {_p} com sucesso! Seu novo saldo é de {cadastro[_p, 3]}. Tecle algo para voltar ao menu principal...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Conta {_p} não localizada, necessário a abertura da conta! Tecle algo para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Transferir()//***testando somente se a conta de origem e destino existe. Falta implementar testes de saldo para transferência.***
        {
            Console.Write("Digite o número da conta de origem: ");
            _t1 = int.Parse(Console.ReadLine());
           if (cadastro[(int)_t1, 0] != null)
            {
                Console.Write("Digite o número da conta de destino: ");
                _t2 = int.Parse(Console.ReadLine());
                if (cadastro[(int)_t2, 0] != null)
                {
                    Console.Write("Digite o valor a ser transferido: ");
                    _valor = decimal.Parse(Console.ReadLine());
                    _swap = (decimal?)cadastro[(int)_t2, 3];
                    cadastro[(int)_t2, 3] = _swap + _valor;
                    Console.WriteLine($"O valor de {_valor}, foi transferido para a conta {_t2} com sucesso. Tecle algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Conta de Destino não existe!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
           else
            {
                Console.WriteLine("Conta de Origem não existe!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        
    }
}
