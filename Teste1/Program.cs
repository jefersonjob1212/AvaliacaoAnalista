/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva algo:");
            var texto = Console.ReadLine();
            if(!string.IsNullOrEmpty(texto)) {
                char[] characters = texto.ToCharArray();
                var result = string.Empty;
                for (int i = 0; i < characters.Length; i++)
                {
                    char character = characters[i];
                    if(i == 0) 
                    {
                        result += character;
                    } 
                    else 
                    {
                        var indexOlder = i - 1;
                        var oldChar = characters[indexOlder];
                        if(oldChar.ToString().ToUpper() != character.ToString().ToUpper()) {
                            result += character;
                        }
                    }
                }
                Console.Write(result);
            }

        }
    }
}