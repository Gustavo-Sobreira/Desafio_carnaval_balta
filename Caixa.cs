namespace Desafio_04;

public static class Caixa
{
    private static readonly decimal[] _valoresMoeda =
    {
        200, 100, 50, 20, 10, 5, 2, 1,
        (decimal)(0.5), (decimal)0.25, (decimal)0.1, (decimal)0.05, (decimal)0.01
    };

    public static void SepararTroco(decimal valorTotalDaCompra, decimal valorDoPagamento)
    {
        List<decimal> moedasParaTroco = new List<decimal>();

        decimal troco = valorDoPagamento - valorTotalDaCompra;

        for (int i = 0; (i < _valoresMoeda.Length) && (troco > 0); i++)
        {
            if (_valoresMoeda[i] <= troco)
            {
                
                troco -= _valoresMoeda[i];
                moedasParaTroco.Add(_valoresMoeda[i]);
                i--;
            }
        }
        ContadorDeTroco(moedasParaTroco);
    }

    public static void ContadorDeTroco(List<decimal> moedasParaTroco)
    {
        Console.Write("Troco:\n");

        for (int i = 0; i < moedasParaTroco.Count; i++)
        {
            int totalDeMoeda = 1;
           
            if (i < moedasParaTroco.Count - 1 && moedasParaTroco[i] == moedasParaTroco[i + 1])
            {
                totalDeMoeda++;
                i++;
            }
            var opcao = (moedasParaTroco[i] > 0 && moedasParaTroco[i] < 1) ? "Moeda" : "Nota";
            Console.WriteLine($"> {totalDeMoeda} {opcao} de {moedasParaTroco[i].ToString("C")}");
        }

        
    }

    public static decimal GetValor(string tipoPagamento)
    {

        decimal valor = 0;

        try
        {
            Console.WriteLine($"Qual foi o valor {tipoPagamento}?");
            decimal recebido = decimal.Parse(Console.ReadLine());
            valor = 0 <= recebido ? recebido : GetValor(tipoPagamento);
        }
        catch
        {
            Console.WriteLine("O valor deve ser dado usando apenas números e ponto. No formato X.XX\nEnter para continuar...");
            Console.ReadLine();
            GetValor(tipoPagamento);
        }
        return valor;
    }

}

