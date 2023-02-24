 namespace Desafio_05;

 public class NumParaExtenso
 {
     public NumParaExtenso(decimal numero)
     {
         _numeroNaoExtenso = numero;
         OrdenarVerificacao();
     }

     private decimal _numeroNaoExtenso;
     private string _numEmExtenso = "";

     private void OrdenarVerificacao()
     {
         if (_numeroNaoExtenso < 1000)
         {
             if (_numeroNaoExtenso is <= 999 and >= 100){NomearCentena();}
             if(_numeroNaoExtenso is <= 99 and >= 10){NomearDezena();}
             if(_numeroNaoExtenso is <= 9 and >= 0){NomearUnidade();}
         }
         else
         {
             Console.WriteLine("Desculpe nosso prograva vai até 999");
         }
         Console.WriteLine(_numEmExtenso);
     }
     private void NomearCentena()
     {
         
         if (_numeroNaoExtenso % 100 == 1)
         {
             _numeroNaoExtenso = 0;
             _numEmExtenso += "Cem";
         }
         else
         {
             string[] centena =
             {
                 "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos",
                 "Novecentos"
             };
             string numeroRetorno = centena[(int)((_numeroNaoExtenso / (100)) - 1)];
             _numEmExtenso += (_numeroNaoExtenso % 100 > 0) ? numeroRetorno + " e ": numeroRetorno + " ";
             _numeroNaoExtenso = _numeroNaoExtenso % 100;
         }
     }
     private void NomearDezena()
     {
         string numRetorno;
         if (_numeroNaoExtenso >= 20)
         {
             string[] dezena =
             {
                 "Vinte","Trinta","Quarenta","Cinquenta","Secenta","Setenta","Oitenta","Noventa"
             };
             numRetorno = dezena[(int)((_numeroNaoExtenso / (10)) - 2)];
            _numeroNaoExtenso %= 10;
         }
         else
         {
             string[]dezena =
             {
                 "Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis","Dezessete","Dezoito","Dezenove"
             };
             numRetorno = dezena[(int)(_numeroNaoExtenso % 10)];
             _numeroNaoExtenso = 0;
         }
         _numEmExtenso += (_numeroNaoExtenso % 10 > 0) ? numRetorno + " e " : numRetorno + " ";
     }
     private void NomearUnidade()
     {
         if (_numEmExtenso == "" && _numeroNaoExtenso == 0)
         {
             _numEmExtenso += "Zero";
             _numeroNaoExtenso = -1;
         }
         else
         {
             string[] unidadesExtenso =
             {
                 "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove"
             };
             
             for (int j = 0; j < unidadesExtenso.Length; j++)
             {
                 if ((int)_numeroNaoExtenso == j + 1)
                 {
                     _numEmExtenso += unidadesExtenso[j];
                     j = unidadesExtenso.Length;
                 }
             }
             _numeroNaoExtenso = -1;
         }
     }
 }