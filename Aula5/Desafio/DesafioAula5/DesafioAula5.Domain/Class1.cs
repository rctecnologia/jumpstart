﻿namespace DesafioAula5.Domain
{
   

    public class ContaCorrente
    {
        private string _agencia;
        private string _conta;
        private string _documento;
        private int numContas = 1;

        string[,] cadastro = new string[10, 3];

        public ContaCorrente() { 
      
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
        int j = 0;
        int k = 0;
        public void mostrarContas()
        {
            for (int j = 1; j <= numContas; j++)
            {
                for (k = 0; k <3; k++)
                {
                    Console.WriteLine($"Conta {j} campo {k}");
                    Console.WriteLine(cadastro[j, k]);
                   
                }
                
                k++;
            }
            Console.Write("Digite algo para voltar menu principal");
            Console.ReadKey();
            Console.Clear();
        }


    }
}