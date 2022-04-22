using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retornando__Valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Valor (int soma1,int soma2)
            {
                (soma1 + soma2).ToString();

                Result = soma1 + soma2;
                Console.WriteLine(soma1 + soma2);
                Console.ReadLine();
            }
        }
    }
}
