
/*
Escreva um programa que informa o troco a ser recebido pelo cliente, por exemplo:

- Valor final da compra: R$ 328,00
- Pagamento: R$ 400,00
- Troco:
    - 1 nota de 2 reais
    - 2 notas de 10 reais
    - 2 notas de 50 reais
*/

using Desafio_04;

Console.Clear();
decimal valorFinal = Caixa.GetValor("total da compra");
decimal pagamento = Caixa.GetValor("recebido");

Caixa.SepararTroco(valorFinal, pagamento);
