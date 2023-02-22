using Desafio_06;

void GetTexto()
{
    Console.Clear();
    Console.WriteLine("Digite ou cole seu texto aqui: ");
    string textoOriginal = Console.ReadLine();
    string textoEncriptografado = Criptografia.CriptografarTexto(textoOriginal);
    Console.WriteLine(textoEncriptografado);
}
GetTexto();
