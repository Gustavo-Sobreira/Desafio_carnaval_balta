namespace Desafio_02;

public class Regras
{
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
            };
        }

        return classificacaoEncontrada;
    }
}
