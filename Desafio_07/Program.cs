/*
Escreva um programa que imprime uma pirâmide na tela, apenas com os números da sequência de Fibonacci.
*/

List<int> sequencia = new List<int>(){0,1};
string lista = "";

for(int i = 0; i < 2; i++)
{
    lista += ($" - {i}");
    Console.WriteLine(lista);
}

for (int i = 1;(sequencia.Count > 1) && (i < 50); i++)
{
    sequencia.Add(sequencia[i] + sequencia[i-1]);
    lista += ($" - {sequencia[i] + sequencia[i - 1]}");
    Console.WriteLine($"{lista}");
}

