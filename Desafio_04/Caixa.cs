namespace Desafio_04;

public static class Caixa
{
    private static decimal[] _valoresMoeda =
    {
        200, 100, 50, 20, 10, 5, 2, 1, 
        (decimal)(0.5), (decimal)0.25, (decimal)0.1, (decimal)0.05, (decimal)0.01
    };

    public static void SepararTroco(decimal valorTotalDaCompra, decimal valorDoPagamento)
    {
        List<decimal> moedaParaTroco = new List<decimal>();
        
        decimal troco = valorDoPagamento - valorTotalDaCompra;

        for (int i = 0; (i <= _valoresMoeda.Length) && (troco > 0); i++)
        {
            if (_valoresMoeda[i] <= troco)
            {
                troco -= _valoresMoeda[i];
                moedaParaTroco.Add(_valoresMoeda[i]);
                i--;
            }
        }
        ContadorDeTroco(moedaParaTroco);
    }

    public static void ContadorDeTroco(List<decimal> notasParaTroco)
    {
        int valor = 0;
        
        for ( valor = 0; valor < notasParaTroco.Count() -1; valor++)
        {
            int totalDeNota = 1;
            
            if (notasParaTroco[valor] == notasParaTroco[valor + 1])
            {
                totalDeNota++;
                valor++;
            }
            Console.WriteLine($"> {totalDeNota} exemplar(es) de {notasParaTroco[valor]} reais.");
        }

        if (notasParaTroco[notasParaTroco.Count()-1] != notasParaTroco[notasParaTroco.Count()-2])
        {
            Console.WriteLine($"> 1 exemplar(es) de {notasParaTroco[valor - 1]} reais.");
        }
    }

    public static decimal GetValor(string tipoPagamento)
    {
        Console.Clear();
        decimal valor = 0;
        
        try
        {
            Console.WriteLine($"Qual foi o valor {tipoPagamento}?\nFormato X.XX");
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

