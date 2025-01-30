/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 0;
            do
            {
                List<int> fibonacci = new List<int>();
                Console.WriteLine("Por favor digite um número");
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    if(numero > 0 && numero < 20) {
                        for (int i = 0; i < numero; i++)
                        {
                            if(fibonacci.Count == 0) {
                                fibonacci.Add(1);
                            } else {
                                var indexOlder = i - 1;
                                if(indexOlder == 0) {
                                    fibonacci.Add(fibonacci[indexOlder]);
                                } else {
                                    var anotherIndexOlder = i - 2;
                                    fibonacci.Add(fibonacci[anotherIndexOlder] + fibonacci[indexOlder]);
                                }
                            }
                        }
                        Console.Write(string.Join(",", fibonacci));
                    } else {
                        Console.WriteLine("Valor inválido. Informe um número maior que 0 e menor que 20");
                    }
                }
                catch
                {
                    Console.WriteLine("Número inválido");
                }
            } while (numero >= 20 || numero <= 0);
        }
    }
}