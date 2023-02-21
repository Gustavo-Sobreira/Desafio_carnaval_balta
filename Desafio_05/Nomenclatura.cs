namespace Desafio_05;

public static class Nomenclatura
{
    int centena = (int)(numeroInputado / 100.00);
    int dezena = (int)((numeroInputado / 10.00) % 10);
    int unidade = (int)((numeroInputado % 100) % 10);
    int decimais = (int)((numeroInputado - (int)(numeroInputado))*10);
    int centesimal = (int)((((decimal) (numeroInputado) - (int)(numeroInputado))*100) % 10);

    string nomeCasaCentena = "";
    string nomeCasaDezena = "";
    string nomeCasaUnidade = "";
    void CasaDasCentenas()
    {
        string[] nomesPossiveisCent =
        {
            "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos",
            "Novecentos"
        };

        if (centena == 1)
        {
            nomeCasaCentena = "Cento";
            if (dezena == 0 && unidade == 0)
            {
                nomeCasaCentena = "Cem";
            }
        }
        else
        {
            for (int i = 2; i <= centena; i++)
            {
                if (i == centena)
                {
                    nomeCasaCentena = nomesPossiveisCent[i - 2];
                }
            }
        }
    }

    void CasaDasDezenas()
    {
        string[] nomesPossiveisDez =
        {
            "Vinte","Trinta","Quarenta","Cinquenta","Secenta","Setenta","Oitenta","Noventa"
        };
        if (dezena == 1)
        {
            string[] nomesPossiveisDezADezenove =
            {
                "Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis","Dezessete","Dezoito","Dezenove"
            };
            for (int i = 0; i <= unidade; i++)
            {
                if (i == unidade)
                {
                    nomeCasaDezena = nomesPossiveisDezADezenove[i];
                }
            }
        }
        else
        {
            for (int i = 1; i <= dezena; i++)
            {
                if (i == dezena)
                {
                    nomeCasaDezena = nomesPossiveisDez[i - 2];
                }
            }
        }
    }

    void CasaDaUnidade()
    {
        string[] nomesPossiveisUni =
        {
            "Um","Dois","Três","Quatro","Cinco","Seis","Sete","Oito","Nove"
        };
        for (int i = 1; i <= unidade; i++)
        {
            if (i == unidade)
            {
                nomeCasaUnidade = nomesPossiveisUni[i -1];
            }
        }
    }

}