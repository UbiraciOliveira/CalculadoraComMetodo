//// 1. CHAVE DE OURO: Importamos nossa oficina para liberar o uso dos métodos !
//using Calculadora.Engine;
//using System.Threading.Tasks.Dataflow;

//Console.WriteLine("--- TESTE DA NOSSA CALCULADORA ---");

//// 2. Criamos duas variáveis com números fixos por enquanto
//double numero1 = 10;
//double numero2 = 5;

//// 3. Chamamos o nosso método passando os dois números. Note o padrão: NomeDaClasse.NomeDoMetodo(valores);
//double resultado = Calculos.Multiplicar(numero1, numero2);

//Console.WriteLine($"A soma de {numero1} com {numero2} é igual a {resultado}");

Console.WriteLine("\t--- MINHA CALCULADORA DINÂMICA ---\n");

Console.Write("Digite o primeiro número ");
double numero1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número ");
double numero2 = double.Parse(Console.ReadLine()!);


Console.ReadKey();

