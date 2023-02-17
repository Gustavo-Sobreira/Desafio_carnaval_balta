namespace desafio001;
public class Contador
{
    public string _frase { get; private set; }
    
    public Contador(string frase)
    {
        _frase = frase;
    }
    public int ContarTotalCaracteres()
    {
        return _frase.Length;
    }

    public int ContarTotalDePalvaras()
    {
        char[] caracteresDeSeparacao = { ' ', '!', '|', '>', '<', '.', ',', ';', ':', '?', '\n', '\r' };
        string[] palavrasSeparadas = _frase.Split(caracteresDeSeparacao);
        return palavrasSeparadas.Length;
    }
}