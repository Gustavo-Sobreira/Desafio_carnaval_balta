/*
 Escreva um programa que informa o valor por extenso, por exemplo:
- Valor final da compra: 328,90
- Output do programa: TREZENTOS E VINTE E OITO REAIS E NOVENTA CENTAVOS
*/
double numeroInputado = 0;
string numeroPorExtenso = "";
IniciarPrograma();

int centena = (int)(numeroInputado / 100.00);
int dezena = (int)((numeroInputado / 10.00) % 10);
int unidade = (int)((numeroInputado % 100) % 10);
int decimais = (int)((numeroInputado - (int)(numeroInputado))*10);
int centesimal = (int)((((decimal) (numeroInputado) - (int)(numeroInputado))*100) % 10);

string nomeCasaCentena = "", nomeCasaDezena = "", nomeCasaUnidade = "";

void IniciarPrograma()
{
    try{
        Console.WriteLine("Diga o número que deseja escreve-lo por extenso: \nFormato X.XX");
        numeroInputado = double.Parse(Console.ReadLine());
    }catch{IniciarPrograma();}
}

void CasaDasCentenas()
{
    string[] nomesPossiveisCent =
    {
        "Cento","Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"
    };
    if (centena == 1 && dezena == 0 && unidade == 0){nomeCasaCentena = "Cem";}
    else
    {
        for (int i = 1; i <= centena; i++)
        {
            if (i == centena){nomeCasaCentena = nomesPossiveisCent[i - 1];}
        }
    }
    numeroPorExtenso += nomeCasaCentena;
}

void CasaDasDezenas()
{
    numeroPorExtenso += (nomeCasaCentena != "") ? " e " : "";
    string[] nomesPossiveisDez =
    {"Vinte","Trinta","Quarenta","Cinquenta","Secenta","Setenta","Oitenta","Noventa"};
    if (dezena == 1)
    {
        string[] nomesPossiveisDezADezenove =
        {"Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis","Dezessete","Dezoito","Dezenove"};
        for (int i = 0; i <= unidade; i++)
        {
            if (i == unidade)
            {
                nomeCasaDezena += nomesPossiveisDezADezenove[i];
            }
        }
    }
    else
    {
        for (int i = 1; i <= dezena; i++)
        {
            if (i == dezena)
            {
                nomeCasaDezena += nomesPossiveisDez[i - 2];
            }
        }
    }
    numeroPorExtenso += nomeCasaDezena;
}

void CasaDaUnidade()
{
    numeroPorExtenso += (nomeCasaDezena != "") ? " e " : "";
    string[] nomesPossiveisUni =
    {"Um","Dois","Três","Quatro","Cinco","Seis","Sete","Oito","Nove"};
    for (int i = 1; i <= unidade; i++)
    {
        if (i == unidade){nomeCasaUnidade = nomesPossiveisUni[i -1];}
    }
    if (nomeCasaDezena == "" && nomeCasaCentena == "" && unidade == 0){nomeCasaUnidade = "Zero";}
    numeroPorExtenso += nomeCasaUnidade;
}

if (numeroInputado < 1000)
{
    CasaDasCentenas();
    CasaDasDezenas();
    if (dezena != 1){CasaDaUnidade();}

    numeroPorExtenso += " reais e ";
    dezena = decimais;
    unidade = centesimal;
    nomeCasaCentena = ""; nomeCasaDezena = ""; nomeCasaUnidade = "";
    
    CasaDasDezenas();
    if (dezena != 1){CasaDaUnidade();}

    Console.WriteLine(numeroPorExtenso +" centavos");
}
else
{
    Console.WriteLine("Infelizmente fiquei com preguiça de fazer a casa dos milhares... desculpe");
}