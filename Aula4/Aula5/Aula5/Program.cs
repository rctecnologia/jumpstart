namespace Aula05;

public class ContaCorrente
{
    private string _agencia;
    private string _conta;
    private decimal _saldo;

    public decimal Saldo { get { return _saldo; } }
    public ContaCorrente(string agencia, string conta)
    {
        _agencia = agencia;
        _conta = conta;
    }

    public void Depositar(decimal valor)
    {
        if (valor >= 0)
        {
            _saldo += valor;
        }
    }

    public bool Sacar(decimal valor)
    {
        if (_saldo >= valor)
        {
            _saldo -= valor;
            return true;
        }
        return false;
    }

    public void Transferir(decimal valor, ContaCorrente contaDestino)
    {
        if (Sacar(valor))
            contaDestino.Depositar(valor);


    }

}