using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_do_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            if (idade >= 0 && idade <= 11)
            //Tá errado, precisa do && porque aqui diz que qualquer um acima de 0 anos é criança
            //então todos nós somos, saca?
            {
                Console.WriteLine("Você é uma criança!");
            }else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolecente");


            } else if (idade >= 19 && idade <= 60)
                Console.WriteLine("Você é um adulto");
                
            else
           {
                Console.WriteLine("Você é um idoso");
            }
            
            Console.ReadLine();
            // C# sempre retorna uma string ou seja texto, independente de o usuário digitar número,mas
            //mas como converto para número?
            //chamo o int.Parse, onde o PARSE significa converter


        
        }
    }
}
