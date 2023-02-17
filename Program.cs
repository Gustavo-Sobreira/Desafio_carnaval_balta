//Escreva um programa que conte a quantidade de palavras e caracteres que um determinado texto, escrito no Console.
using desafio001;

string ReceberFrase()
{
    Console.Clear();
    Console.WriteLine("Escreva sua frase: ");
    return Console.ReadLine() ?? throw new InvalidOperationException("Error S01: A expressão não pode ser nula.");
}

string fraseRecebida = ReceberFrase();
Console.Clear();

Contador fraseAtual = new Contador(fraseRecebida);

Console.WriteLine("Sua frase: {0}\n\n"+
    "Sua frase tem {1} caracteres. \n" +
    "E {2} palavras no total",fraseRecebida, fraseAtual.ContarTotalCaracteres(), fraseAtual.ContarTotalDePalvaras());
