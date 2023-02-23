/*Escreva um programa que calcula o IMC (Índice de massa corporal de uma pessoa) e exibe o resultado.*/

using Desafio_02;

CalculadoraIMc alturaParaValidar = new CalculadoraIMc("altura");
CalculadoraIMc pesoParaValidar = new CalculadoraIMc("peso");

double altura = alturaParaValidar.MedidaInformada;
double peso = pesoParaValidar.MedidaInformada;

double imc = (peso / (altura * altura));
List<string> classificacao = CalculadoraIMc.RetornarClassificacao(imc);

Console.WriteLine($"IMC = ({peso} ÷ ({altura} x {altura})) = " + imc.ToString("N2"));
Console.WriteLine(classificacao[0] +"\n" + classificacao[1]);
Console.ReadLine();