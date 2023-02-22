namespace Desafio_06;

public class Criptografia
{
    private static char[,] tradutor =
    {
        { 'a', 'l' }, { 'e', 'k' }, { 'i', 'j' }, { 'o', 'p' }, { 'u', 'm' },
        { 'b', 'z' }, { 'c', 'x' }, { 'd', 'v' }, { 'g', 's' }, { ' ', '-' }
    };
    
    public static string CriptografarTexto(string textoOriginal)
    {
        char[] textoParaMudanaca = textoOriginal.ToLower().ToCharArray();
        
        for (int i = 0; i < textoParaMudanaca.Length; i++)
        {
            for (int j = 0; j < tradutor.Length/2 - 1; j++)
            {
                if (textoParaMudanaca[i] == tradutor[j,0])
                {
                    textoParaMudanaca[i] = tradutor[j, 1];
                    j = tradutor.Length;
                }
            }   
        }
        string textoPronto = "";
        
        for (int i = 0; i < textoParaMudanaca.Length; i++){textoPronto += textoParaMudanaca[i];}
        
        return textoPronto;
    }
}