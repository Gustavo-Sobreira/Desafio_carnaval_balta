namespace Desafio_02;

public class CalculadoraIMc
{
    public double MedidaInformada { get; private set; }
    private string _tipoMedida;
    
    public CalculadoraIMc(string tipoMedida)
    {
        this._tipoMedida = tipoMedida;
        GetMedidas();
    }
    private void MontarCabecalho()
    {
        Console.Clear();
        Console.WriteLine("========== ========== === Calculadora de IMC === ========== ========== \n");
    }
    private void GetMedidas()
    {
        MontarCabecalho();
        Console.WriteLine($"Quanto você {_tipoMedida}? X.XX");
    
        double medidaInformada = 0;
    
        try{medidaInformada = double.Parse(Console.ReadLine()!);}
        catch
        {
            Console.WriteLine("Informe seu peso e sua altura, usando apenas números e ponto final\nEnter para continuar...");
            Console.ReadLine();
            GetMedidas();
        }
        ValidarMedida(medidaInformada);
    }
    private void ValidarMedida(double medidaInformada)
    {
        if (medidaInformada > 0){MedidaInformada = medidaInformada;}
        else 
        {
            Console.WriteLine("Somente peso / altura positivos são aceitos\nEnter para continuar...");
            Console.ReadLine();
            GetMedidas();
        }
    }
    
    private static string[,] _listaDeValores =
    {
        {"Magreza Grau III", "0", "" },
        {"Magreza Grau II", "16", ""},
        {"Magreza Grau I","17", ""},
        {"Eutrofia", "18.5", ""},
        {"Sobrepeso", "25", "Risco Aumentado"},
        {"Obesidade Grau I","30", "Risco Moderado"},
        {"Obesidade Grau II", "35", "Risco Grave"},
        {"Obesidade Grau III", "40.01", "Risco Muito Grave"}
    };

    public static List<string> RetornarClassificacao(double imc)
    {
        List<string> classificacaoEncontrada = new List<string>();
        
        int ponteiro = 8;
        while (ponteiro != 0)
        {
            ponteiro--;
            
            if (imc >= double.Parse(_listaDeValores[ponteiro,1]))
            {
                classificacaoEncontrada.Add(_listaDeValores[ponteiro,0]);
                classificacaoEncontrada.Add(_listaDeValores[ponteiro,2]);
                ponteiro = 0;
            }
        }
        return classificacaoEncontrada;
    }
}