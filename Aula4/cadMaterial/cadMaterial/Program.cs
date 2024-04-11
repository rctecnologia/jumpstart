
baseveiculos[] cadastro = new baseveiculos[2];
for (int i = 0; i < cadastro.Length; i++)
{
    Console.Write("Digite o TIPO do veículo: ");
    cadastro[i].Tipo = Console.ReadLine();
    Console.Write("Digite o MODELO do veículo: ");
    cadastro[i].modelo = Console.ReadLine();
    Console.Write("Digite o ANO do veículo: ");
    cadastro[i].ano = int.Parse(Console.ReadLine());
    Console.WriteLine("");

}
Console.WriteLine("");
Console.WriteLine("-------------------");
Console.WriteLine("Resultado da Coleta");
Console.WriteLine("-------------------");

for (int i = 0; i < cadastro.Length; i++)
{

    Console.WriteLine("O TIPO de veículo é:" + cadastro[i].Tipo);
    Console.WriteLine("O MODELO de veículo é:" + cadastro[i].modelo);
    Console.WriteLine("O ANO de veículo é:" + cadastro[i].ano);
    Console.WriteLine("");
}
struct baseveiculos
{
    public string Tipo;
    public string modelo;
    public int ano;

}
