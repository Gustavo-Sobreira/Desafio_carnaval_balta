/*Escreva um programa que calcula o IMC (Índice de massa corporal de uma pessoa) e exibe o resultado.*/

using System.Net.WebSockets;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

using Desafio_02;

void MontarCabecalho()
{
    Console.Clear();
    Console.WriteLine("========== ========== === Calculadora de IMC === ========== ========== \n");
}

double GetMedidas(string medida)
{
    Console.Clear();
    MontarCabecalho();
    Console.WriteLine($"Quanto você {medida}? X.XX");
    
    double medidaInformada = 0;
    
    try
    {
        medidaInformada = double.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Informe seu peso e sua altura, usando apenas números e ponto final\nEnter para continuar...");
        Console.ReadLine();
        GetMedidas(medida);
    }

    ValidarMedida(medidaInformada, medida);
    
    return medidaInformada;
}

double ValidarMedida(double medidaInformada, string medida)
{
    if (medidaInformada > 0)
    {
        return medidaInformada;
    } else {
        Console.WriteLine("Somente peso / altura positivos são aceitos\nEnter para continuar...");
        Console.ReadLine();
        return GetMedidas(medida);
    }
}

double altura = GetMedidas("mede");
double peso = GetMedidas("pesa");
double imc = (peso / (altura * altura));

Console.WriteLine($"IMC = ({peso} ÷ ({altura} x {altura})) = " + imc.ToString("N2"));
Console.WriteLine(Regras.RetornarClassificacao(imc));