using System.ComponentModel.Design;

//Declaração de variáveis
Double impCalc = 0;
Double vFaturamento = 0;
int op = 0;
char decisao = 's';

//Método para leitura de dados
void lerDados()
{
    //Looping que testa se a o~pção escolhida é 1 ou 2.
    while (op != 1 && op != 2)
    {
        Console.WriteLine("Calculadora de Imposto de Renda");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Digite 1 para PF ou 2 para PJ: ");
        Console.WriteLine("_______________________________");
        Console.WriteLine("");
        Console.Write(">");
        op = Int32.Parse(Console.ReadLine());

        Console.Clear();
        //Condição para solicitar o valor do faturamento ou acusar erro.
        if (op == 1 || op == 2)
        {
            Console.Write("Informe o valor do faturamento: ");
            vFaturamento = Double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Opção Inválida, Digite qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
          
        }


    }

}
//Método para cálculo do imposto
 void calcImposto()
{
if (op == 1)
    {
        impCalc = vFaturamento + (vFaturamento * 0.15);
        
    }
else if (op == 2)
        {
        impCalc = vFaturamento + (vFaturamento * 0.10);
    }
    
}

//Método para apresentação dos dados
void apresentarDados()
{
    Console.WriteLine($"O imposto devido é de: {impCalc}");
    Console.WriteLine("");
    Console.WriteLine("Deseja realizar um novo cálculo? (s/n)");
    decisao = Char.Parse(Console.ReadLine());
    op = 0;
    Console.Clear();

}


do
{
    lerDados();
    calcImposto();
    apresentarDados();
}
while (decisao != 'n');



