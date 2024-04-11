Decimal totalImposto = 0;
char resposta = 's';

Pessoa[] pessoas = new Pessoa[10];


for (int i = 0; i < pessoas.Length; i++)
{
    while (resposta != 'n')
    {
        int j = i + 1;
        Console.WriteLine("Digite o Documento " + j);
        pessoas[i].Documento = Console.ReadLine();
        Console.WriteLine("Digite o Tipo");
        pessoas[i].Tipo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Faturamento");
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

        Console.WriteLine("Desja continuar?");
        resposta = char.Parse(Console.ReadLine());
    }

}


for (int i = 0; i < pessoas.Length; i++)
{
    Console.WriteLine("Documento: " + pessoas[i].Documento);
    Console.WriteLine("Tipo: " + pessoas[i].Tipo);
    Console.WriteLine("Faturamento: " + pessoas[i].Faturamento);
    totalImposto += pessoas[i].Imposto;
    Console.WriteLine("Imposto: " + pessoas[i].Imposto);
    Console.WriteLine("---------------------");
}
Console.WriteLine("");
Console.WriteLine("Total de Impostos: " + totalImposto);

struct Pessoa
{
    public string Documento;
    public int Tipo;
    public Decimal Faturamento;
    public Decimal Imposto;
}