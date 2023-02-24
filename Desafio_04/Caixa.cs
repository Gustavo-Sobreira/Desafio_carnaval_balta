namespace Desafio_04;

public static class Caixa
{
    private static readonly decimal[] ValoresMoeda =
    {
        200, 100, 50, 20, 10, 5, 2, 1, 
        (decimal)(0.5), (decimal)0.25, (decimal)0.1, (decimal)0.05, (decimal)0.01
    };

    public static void SepararTroco(decimal valorTotalDaCompra, decimal valorDoPagamento)
    {
        List<decimal> moedasParaTroco = new List<decimal>();
        
        decimal troco = valorDoPagamento - valorTotalDaCompra;

        for (int i = 0; (i <= ValoresMoeda.Length) && (troco > 0); i++)
        {
            decimal moedaAtual = ValoresMoeda[i];
            if (moedaAtual <= troco)
            {
                troco -= moedaAtual;
                moedasParaTroco.Add(moedaAtual);
                i--;
            }
        }
        ContadorDeTroco(moedasParaTroco);
    }

    private static void ContadorDeTroco(List<decimal> moedasParaTroco)
    {
        int valor;
        
        for ( valor = 0; valor < moedasParaTroco.Count() -1; valor++)
        {
            int totalDeNota = 1;
            decimal moedaAtual = moedasParaTroco[valor];
            
            if (moedaAtual == moedasParaTroco[valor + 1])
            {
                totalDeNota++;
                valor++;
            }
            Console.WriteLine($"> {totalDeNota} exemplar(es) de {moedaAtual} reais.");
        }

        if (moedasParaTroco[moedasParaTroco.Count()-1] != moedasParaTroco[moedasParaTroco.Count()-2])
        {
            Console.WriteLine($"> 1 exemplar(es) de {moedasParaTroco[valor]} reais.");
        }
    }

    public static decimal GetValor(string tipoPagamento)
    {
        decimal valor = 0;
        
        try
        {
            Console.WriteLine($"Qual foi o valor {tipoPagamento}?\nFormato X.XX");
            decimal recebido = decimal.Parse(Console.ReadLine()!);
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