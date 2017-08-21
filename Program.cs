using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDiferenteMediaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, media, produto;

            Console.Write("Digite um número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 != numero2)
            {
                media = (numero1 + numero2) / 2;
                produto = numero1 * numero2;
                Console.Write("A média dos 2 números é " +media + " e o produto é " + produto);
            }
            Console.ReadLine();
        }
    }
}
