/*Escreva um programa que, dado o valor da gasolina e do álcool, diz qual dos dois compensa mais ser utilizado.
Faça a divisão do valor do álcool pelo valor da gasolina (ex.: litro do álcool = R$ 3,44 e o da gasolina R$ 5,26,
 a relação, então, é de 0,65 ou 65%).
- A relação de preço feita acima (65%) garante uma vantagem econômica para o motorista que escolher álcool para
 abastecer o tanque do seu veículo.
Vale ressaltar também que, caso o resultado desse cálculo feito for igual a 0,72 ou 72%, como calculado no item 1,
 o consumidor também economizará ao abastecer com álcool.
*/

void MontarCabecalho()
{
    Console.Clear();
    Console.WriteLine("========== ========== === POSTO DO BALTA.IO === ========== ========== \n");
}

double GetPrecoCombustivel(string combustivel)
{
    MontarCabecalho();

    try
    {
        Console.WriteLine($"Quanto custa 1L de {combustivel}?\nFormato X.XX");
        double precoCombustivel = double.Parse(Console.ReadLine());

        if (precoCombustivel > 0)
        {
            Console.Clear();
            return precoCombustivel;
        }

        Console.WriteLine("O preço não pode ser negativo");
        return GetPrecoCombustivel(combustivel);
    } catch {
        Console.WriteLine("Você pode usar somente números e ponto, conforme o formato exibido X.XX\nEnter para continuar...");
        Console.ReadLine();
        return GetPrecoCombustivel(combustivel);
    }
}

double gasolina = GetPrecoCombustivel("gasolina");
double alcool = GetPrecoCombustivel("álcool");


double relacaoGasolinaAlcool = alcool / gasolina;
string vantagem = relacaoGasolinaAlcool <= 0.7 ? "álcool" : "gasolina";

Console.WriteLine($"Como resultado da divisão álcool / gasolina, temos {relacaoGasolinaAlcool}\n" +
                  $"Isso indica melhor custo / benefício no abastecimento de {vantagem}.\n");
Console.WriteLine("========== ========== === ###-###- -###-### === ========== ==========");
Console.ReadLine();

