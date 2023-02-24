/*Escreva um programa que conte a quantidade
 de palavras e caracteres que um determinado 
 texto, escrito no Console.*/

using desafio001;

Contador fraseAtual = new Contador();

fraseAtual.ReceberTexto();
Contador.MontarCabecalho();

Console.WriteLine("-> SUA FRASE: {0}\n\n"+
"                           TEMOS {1} CARACTERES \n" +
"                              E {2} PALAVRAS\n" +
"========== ========== ========== # # # ========== ========== =========="
    ,fraseAtual.Frase, fraseAtual.Frase.Length, fraseAtual.ContarTotalDePalvaras());

Console.ReadLine();

