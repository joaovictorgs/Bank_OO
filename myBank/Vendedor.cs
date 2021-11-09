public class Vendedor: Funcionario
{
    public int NumeroClientesAtendidos {get ; set;}

    public override double Bonificacao 
    {
        get
        {
            return _bonificacao;
        }
        set
        {
                _bonificacao += 12 * (value * 0.02);
        }
    }

    public override int CalcularFerias() {
        int dias_ferias = 30 + NumeroClientesAtendidos * 1;
        return dias_ferias;
    }
}