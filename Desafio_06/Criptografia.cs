namespace Desafio_06;

public class Criptografia
{
    private string? _textoParaCriptografar;

    private readonly List<string> _textoCriptografado = new List<string>();

    private int _chavePrivada;

    private string? _textoDescriptografado;

    private static void MontarCabecalho()
    {
        Console.Clear();
        Console.WriteLine("<========= ========== ========== CRIPTOTEXT ========== ========== =========>");
    }

    public void EscolherAcao()
    {
        MontarCabecalho();
        Console.WriteLine("   [ 1 ] -> CRIPTOGRAFAR\n   [ 2 ] -> LER CRIPTOGRAFIA");
        try
        {
            int escolha = int.Parse(Console.ReadLine()!);
            if (escolha == 1)
            {
                SetTextoParaCriptografia();
                GerarCriptografia();
            }
            else
            {
                SetCodigoDescriptografar();
                TirarCriptografia();
            }
        }
        catch
        {
            EscolherAcao();
        }
    }
    private void SetTextoParaCriptografia()
    {
        MontarCabecalho();
        Console.WriteLine("\nCOLE AQUI O TEXTO QUE DESEJA CRIPTOGRAFAR: ");
        _textoParaCriptografar = Console.ReadLine()!;
        SetChavePrivada();
    }
    private void SetChavePrivada()
    {
        MontarCabecalho();
        Console.WriteLine(
            "\nESCOLHA / DIGA UMA CHAVE PRIVADA:\nUtilize APENAS números");
        try
        {
            _chavePrivada = int.Parse(Console.ReadLine()!);
        }
        catch
        {
            SetChavePrivada();
        }
    }
    private void GerarCriptografia()
    {
        char[] textoEmChars = _textoParaCriptografar!.ToCharArray();
        Console.WriteLine((int)textoEmChars[0]);
        for (int i = 0; i < textoEmChars.Length; i++)
        {
            int caracterCriptografado = textoEmChars[i] * _chavePrivada;
            _textoCriptografado.Add(caracterCriptografado + " ");
        }
        PrintarDadosFinais();
    }
    private void PrintarDadosFinais()
    {
        MontarCabecalho();
        string codigo = "";
        for (int i = 0; i < _textoCriptografado.Count; i++)
        {
            codigo += _textoCriptografado[i];
        }
        Console.WriteLine($"\n   Seu código é :\n    {codigo}\n\n   Sua senha é :\n    {_chavePrivada}");
        Console.ReadLine();
    }

    private void SetCodigoDescriptografar()
    {
        MontarCabecalho();
        Console.WriteLine("QUAL SEU CÓDIGO PARA DESCRIPTOGRAFIA ? ");
        _textoCriptografado.Add(Console.ReadLine()!);
        SetChavePrivada();
    }
    
    private void TirarCriptografia()
    {
        MontarCabecalho();
        string[] removendoEspaco = _textoCriptografado[0].Split(' ');
        for (int i = 0; i < removendoEspaco.Length; i++)
        {
            int caracterEmInt = int.Parse(removendoEspaco[i]) / _chavePrivada;
            char carcterEmChar = (char)caracterEmInt;
            _textoDescriptografado += carcterEmChar;
        }

        Console.WriteLine(_textoDescriptografado);
        Console.ReadLine();
    }
}