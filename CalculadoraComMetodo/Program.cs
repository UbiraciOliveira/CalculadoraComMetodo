//// 1. CHAVE DE OURO: Importamos nossa oficina para liberar o uso dos métodos !
using Calculadora.Engine;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;


Console.WriteLine("\t--- MINHA CALCULADORA DINÂMICA ---\n");

// 1. Perguntamos e capturamos o primeiro número
Console.Write("\tDigite o primeiro número ");
double numero1 = double.Parse(Console.ReadLine()!);

// 2. Perguntamos e capturamos o operador matemático
Console.Write("Escolha a operação (+, -, *, /) ");
string operador = Console.ReadLine()!;

// 3. Perguntamos e capturamos o segundo número 
Console.Write("Digite o segundo número ");
double numero2 = double.Parse(Console.ReadLine()!);

// Criamos a váriavel que vai guardar o resultado final
double resultado = 0;

// 4. A estrutura SWITCH decide qual operador chamar.
switch (operador)
{
    case "+":
        resultado = Calculos.Somar(numero1, numero2);
        break;
    case"-":
        resultado = Calculos.Subtrair(numero1, numero2);
        break;
    case "*":
        resultado = Calculos.Multiplicar(numero1, numero2);
        break;
    case "/":
        resultado = Calculos.Dividir(numero1, numero2);
        break;
    default:
        Console.WriteLine("O operador escolhido é invlido´!");
        return; // Parar o progamar aqui caso digitem algo errado.
}

Console.WriteLine($"Resultado: {numero1} {operador} {numero2} = {resultado}");

Console.WriteLine("\t Fim do Processo...");

Console.ReadKey();

