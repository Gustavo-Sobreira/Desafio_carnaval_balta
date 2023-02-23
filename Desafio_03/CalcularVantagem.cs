namespace Desafio_03;

public class CalcularVantagem
{
    private readonly string _nomeCombustivel;
    public double PrecoCombustivel { get; private set; }
    public CalcularVantagem(string nomeCombustivel)
    {
        this._nomeCombustivel = nomeCombustivel;
        GetPrecoCombustivel();
    }
    private void MontarCabecalho()
    {
        Console.Clear();
        Console.WriteLine("========== ========== === POSTO DO BALTA.IO === ========== ========== \n");
    }

    private void GetPrecoCombustivel()
    {
        MontarCabecalho();
        Console.WriteLine($"Quanto custa 1L de {_nomeCombustivel}?\nFormato X.XX");
        try
        {
            double precoCombustivel = double.Parse(Console.ReadLine()!);
            ValidarPreco(precoCombustivel);
        } catch {
            Console.WriteLine("Você pode usar somente números e ponto, conforme o formato exibido X.XX\nEnter para continuar...");
            Console.ReadLine();
            GetPrecoCombustivel();
        }
    }

    private void ValidarPreco(double preco)
    {
        if (preco > 0){PrecoCombustivel = preco;}
        else
        {
            Console.WriteLine("O preço do combustível deve ser positivo\nEnter para continuar...");
            Console.ReadLine();
            GetPrecoCombustivel();
        }
    }

    public static string CalcularRelacaoAlcoolGasolina(double gasolina, double alcool)
    {
        string vantagem = alcool/gasolina <= 0.7 ? "álcool" : "gasolina";
        return vantagem;
    }
}