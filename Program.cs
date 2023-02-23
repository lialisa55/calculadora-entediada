Console.WriteLine("Digite dois números");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double resultado;

Console.WriteLine("Que operação você deseja efetuar?");
Console.WriteLine("0 - Soma de números");
Console.WriteLine("1 - Subtração de números");
Console.WriteLine("2 - Multiplicação de números");
Console.WriteLine("3 - Divisão de números");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 0:
        {
            resultado = num2 + num1;
            Console.WriteLine("A soma dos valores é: " + resultado);
            break;
        }
    case 1:
        {
            resultado = num2 - num1;
            Console.WriteLine("A subtração dos valores é: " + resultado);
            break;
        }
    case 2:
        {
            resultado = num2 * num1;
            Console.WriteLine("A multiplicação dos valores é: " + resultado);
            break;
        }
    case 3:
        {
            resultado = num2 / num1;
            Console.WriteLine("A divisão dos valores é: " + resultado);
            break;
        }
}