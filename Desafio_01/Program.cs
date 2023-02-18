/*Escreva um programa que conte a quantidade
 de palavras e caracteres que um determinado 
 texto, escrito no Console.*/

using desafio001;

void MontarCabecalho()
{
    Console.Clear();
    Console.WriteLine("========== ========== === CONTADOR DE STRINGS === ========== ========== \n");
}
string ReceberFrase()
{
    MontarCabecalho();
    Console.WriteLine("-> ESCREVA SUA FRASE: ");
    return Console.ReadLine() ?? throw new InvalidOperationException("Error S01: A expressão não pode ser nula.");
}

void ExibirResultados()
{
    string fraseRecebida = ReceberFrase();
    MontarCabecalho();
    
    Contador fraseAtual = new Contador(fraseRecebida);
    Console.WriteLine("-> SUA FRASE: {0}\n\n"+
    "                            TEMOS {1} CARACTERES \n" +
    "                               E {2} PALAVRAS\n" +
    "========== ========== ========== # # # ========== ========== =========="
        ,fraseRecebida.ToUpper(), fraseAtual.ContarTotalCaracteres(), fraseAtual.ContarTotalDePalvaras());
}

ExibirResultados();

