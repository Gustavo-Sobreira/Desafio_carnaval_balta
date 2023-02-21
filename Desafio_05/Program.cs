/*
 Escreva um programa que informa o valor por extenso, por exemplo:
- Valor final da compra: 328,90
- Output do programa: TREZENTOS E VINTE E OITO REAIS E NOVENTA CENTAVOS
*/
double numero = 0;
int centena = (int)(numero / 100.00);
int dezena = (int)((numero / 10.00) % 10);
int unidade = (int)((numero % 100) % 10);
int decimais = (int)((numero - (int)(numero))*10);
int centesimal = (int)((((decimal) (numero) - (int)(numero))*100) % 10);

string nomeCasaCentena = "";
string nomeCasaDezena = "";
string nomeCasaUnidade = "";

void IniciarPrograma()
{
    try
    {
        Console.WriteLine("Diga o número que deseja escreve-lo por extenso: \nFormato X.XX");
        numero = double.Parse(Console.ReadLine());
    }catch{IniciarPrograma();}
}

void CasaDasCentenas()
{
    if (centena == 1)
    {
        nomeCasaCentena = "Cento";
        if (dezena == 0 && unidade == 0)
        {
            nomeCasaCentena = "Cem";
        }
    }
    else if (centena == 2) { nomeCasaCentena = "Duzentos"; }
    else if (centena == 3) { nomeCasaCentena = "Trezeentos"; }
    else if (centena == 4) { nomeCasaCentena = "Quatrocentos"; }
    else if (centena == 5) { nomeCasaCentena = "Quinhentos"; }
    else if (centena == 6) { nomeCasaCentena = "Seiscentos"; }
    else if (centena == 7) { nomeCasaCentena = "Setecentos"; }
    else if (centena == 8) { nomeCasaCentena = "Oitocentos"; }
    else if (centena == 9) { nomeCasaCentena = "Novecentos"; }
}

void CasaDasDezenas()
{
    if (dezena == 1)
    {
        if (unidade == 1) { nomeCasaDezena = "Onze"; }
        else if (unidade == 2) { nomeCasaDezena = "Doze"; }
        else if (unidade == 3) { nomeCasaDezena = "treze"; }
        else if (unidade == 4) { nomeCasaDezena = "Quatorze"; }
        else if (unidade == 5) { nomeCasaDezena = "Quinze"; }
        else if (unidade == 6) { nomeCasaDezena = "Dezesseis"; }
        else if (unidade == 7) { nomeCasaDezena = "Dezessete"; }
        else if (unidade == 8) { nomeCasaDezena = "Dezoito"; }
        else if (unidade == 9) { nomeCasaDezena = "Dezenove"; }
        else { nomeCasaDezena = "Dez"; }
    }
        
    else if (dezena == 2) { nomeCasaDezena = "Vinte"; }
    else if (dezena == 3) { nomeCasaDezena = "Trinta"; }
    else if (dezena == 4) { nomeCasaDezena = "Quarenta"; }
    else if (dezena == 5) { nomeCasaDezena = "Cinquenta"; }
    else if (dezena == 6) { nomeCasaDezena = "Secenta"; }
    else if (dezena == 7) { nomeCasaDezena = "Setenta"; }
    else if (dezena == 8) { nomeCasaDezena = "Oitenta"; }
    else if (dezena == 9) { nomeCasaDezena = "Noventa"; }
}

void CasaDaUnidade()
{
    if (unidade == 1){nomeCasaUnidade = "Um";}
    else if (unidade == 2){nomeCasaUnidade = "Dois";}
    else if (unidade == 3){nomeCasaUnidade = "Três";}
    else if (unidade == 4){nomeCasaUnidade = "Quatro";}
    else if (unidade == 5){nomeCasaUnidade = "Cinco";}
    else if (unidade == 6){nomeCasaUnidade = "Seis";}
    else if (unidade == 7){nomeCasaUnidade = "Sete";}
    else if (unidade == 8){nomeCasaUnidade = "Oito";}
    else if (unidade == 9){nomeCasaUnidade = "Nove";}
}

IniciarPrograma();
if (numero < 1000)
{
    CasaDasCentenas();
    CasaDasDezenas();
    if (dezena != 1)
    {
        CasaDaUnidade();
    }

    string centDez = "";
    string dezUnid = "";

    void VerificarUsoDoE()
    {
        if (nomeCasaCentena != "")
        {
            centDez = " e ";
        }

        if (nomeCasaDezena != "" && dezena != 1)
        {
            dezUnid = " e ";
        }
    }
    
    VerificarUsoDoE();
    Console.Write($"-> {nomeCasaCentena} {centDez}{nomeCasaDezena} {dezUnid}{nomeCasaUnidade} reais");

    
    nomeCasaDezena = "";
    nomeCasaUnidade = "";
    dezUnid = "";
    
    dezena = decimais;
    unidade = centesimal;
    
    CasaDasDezenas();
    if (dezena != 1)
    {
        CasaDaUnidade();
    }

    VerificarUsoDoE();
    
    Console.Write($" e {nomeCasaDezena} {dezUnid}{nomeCasaUnidade} centavos");
}
else
{
    Console.WriteLine("Infelizmente fiquei com preguiça de fazer a casa dos milhares... desculpe");
}

