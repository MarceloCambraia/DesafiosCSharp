using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DesafiosCSharp
{
    public static class Palindromo
    {
        public static bool EhPalindromo(string palavra)
        {
            palavra = palavra.ToLower().Replace(" ", "");
            int esquerda = 0;
            int direita = palavra.Length - 1;

            while (esquerda < direita)
            {
                if (palavra[esquerda] != palavra[direita])
                    return false;

                esquerda++;
                direita--;
            }

            return true;
        }

        public static void Executar()
        {
            Console.Write("\nDigite uma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine($"É palíndromo? {EhPalindromo(palavra)}");
        }
    }
}