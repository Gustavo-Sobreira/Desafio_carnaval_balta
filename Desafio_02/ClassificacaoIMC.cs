namespace Desafio_02;

public class ClassificacaoIMC
{
    public string classificacao { get; set; }
    
    public double valor { get; set; }

    public ClassificacaoIMC(string Classificacao, double Valor)
    {
        classificacao = Classificacao;
        valor = Valor;
    }
}