/*
Escreva um programa que encripta um texto utilizando uma tabela de mapeamento de caracteres, por exemplo:
a = K, n = J, d = A, r = T, e = L*/

char[] alfabeto =
{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z','a',' ',' '
};
Console.WriteLine("Diga seu texto: ");

string texto = Console.ReadLine();
char[] textoEmArray = texto.ToLower().ToCharArray();
string textoEncriptografado = "";

for (int i = 0; i < texto.Length; i++)
{
    for (int j = 0; j < alfabeto.Length; j++)
    {
        if (textoEmArray[i] == alfabeto[j])
        {
            textoEncriptografado += alfabeto[j + 1];
            j = alfabeto.Length;
        }
    }
}

Console.WriteLine(textoEncriptografado.ToUpper());