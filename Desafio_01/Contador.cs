namespace desafio001;
public class Contador
{
    public string Frase { get; private set; } = null!;

    public static void MontarCabecalho()
    {
        Console.Clear();
        Console.WriteLine("========== ========== === CONTADOR DE STRINGS === ========== ========== \n");
    }
    public void ReceberTexto()
    {
        MontarCabecalho();
        Console.WriteLine("-> ESCREVA SUA FRASE: ");
        TratarTexto(Console.ReadLine()!);
    }
    private void TratarTexto(string textoBruto)
    {
        char[] textoEmTratamento = textoBruto.Trim().ToUpper().ToCharArray();
        string textoTratado = "";
        for (int i = 0; i < textoEmTratamento.Length; i++)
        {
            textoTratado += (textoEmTratamento[i] == ' ' && textoEmTratamento[i+1] == ' ')? "" : textoEmTratamento[i];
        }
        Frase = textoTratado;
    }
    public int ContarTotalDePalvaras()
    {
        if (Frase.Length != 0)
        {
            string[] palavrasSeparadas = Frase.Split(' ');
            return palavrasSeparadas.Length;
        }
        return 0;
    }
}