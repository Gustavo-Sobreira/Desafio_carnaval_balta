/*
 Escreva um programa que informa o valor por extenso, por exemplo:
- Valor final da compra: 328,90
- Output do programa: TREZENTOS E VINTE E OITO REAIS E NOVENTA CENTAVOS
*/

using Desafio_05;

Console.WriteLine("Diga um número de 0 a 999, para que ele seja escrito por extenso: ");
decimal num = decimal.Parse(Console.ReadLine()!);
NumParaExtenso numeroEscrito = new NumParaExtenso(num);

