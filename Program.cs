double numerador, denominador, resultado;

Console.Write("Digite o numerador.....: ");
numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o denominador...: ");
denominador = Convert.ToDouble(Console.ReadLine());

if (denominador != 0)
{
    resultado = numerador / denominador;
    Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");
}
else
{
    Console.WriteLine("Não é possível dividir por zero.");
}