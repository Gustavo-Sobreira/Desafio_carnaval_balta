namespace Desafio_02;

public class Regras
{
    private static string[,] _listaDeValores =
    {
        {"Magreza Grau III", "0" },
        {"Magreza Grau II", "16"},
        {"Magreza Grau I","17"},
        {"Eutrofia", "18.5"},
        {"Sobrepeso", "25"},
        {"Obesidade Grau I","30"},
        {"Obesidade Grau II", "35"},
        {"Obesidade Grau III", "40.01"}
    };

    public static string RetornarClassificacao(double imc)
    {
        string classificacaoEncontrada = "";
        
        int ponteiro = 8;
        while (ponteiro != 0)
        {
            ponteiro--;
            
            if (imc >= double.Parse(_listaDeValores[ponteiro,1]))
            {
                classificacaoEncontrada = _listaDeValores[ponteiro, 0];
                ponteiro = 0;
            }
        }
        return classificacaoEncontrada;
    }
    
    
}