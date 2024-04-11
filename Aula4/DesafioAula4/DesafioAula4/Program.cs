//Declarãção das Variáveis
char resposta = 's';
int i = 0;
int contador = 0;
Decimal totalImposto = 0;

//Inicialização da variavel pessoas
Pessoa[] pessoas = new Pessoa[10];

//Teste de condição para coleta dos dados
while (i < pessoas.Length && resposta != 'n')
{
    int y = 0;
    y = i + 1;
    Console.Write("Digite o Documento " + y + ": ");
    pessoas[i].Documento = Console.ReadLine();
    Console.Write("Digite o Tipo (1 ou 2): ");
    pessoas[i].Tipo = int.Parse(Console.ReadLine());
    Console.Write("Digite o Faturamento: ");
    pessoas[i].Faturamento = Decimal.Parse(Console.ReadLine());
    Console.WriteLine("--------------------");


    if (pessoas[i].Tipo == 1)
    {
        pessoas[i].Imposto = pessoas[i].Faturamento * 0.15m;
    }
    else
    {
        pessoas[i].Imposto = pessoas[i].Faturamento * 0.10m;
    }

    Console.Write("Desja continuar?: ");
    resposta = char.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("--------------------");

    i++;
   
}

//Condicional para apresentação dos resultados
for (int j = 0; j < i; j++)
{
    Console.WriteLine("");
    Console.WriteLine("Documento: " + pessoas[j].Documento);
    Console.WriteLine("Tipo: " + pessoas[j].Tipo);
    Console.WriteLine("Faturamento: " + pessoas[j].Faturamento);
    totalImposto += pessoas[j].Imposto;
    Console.WriteLine("Imposto: " + pessoas[j].Imposto);
    Console.WriteLine("---------------------");
}
Console.WriteLine("");
Console.WriteLine("Total de Impostos: " + totalImposto);

//Criação da struct
struct Pessoa
{
    public string Documento;
    public int Tipo;
    public Decimal Faturamento;
    public Decimal Imposto;
}