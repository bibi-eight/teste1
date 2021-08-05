using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            string situacao;

            Console.Write("Bom dia, por favor entre com a sua nota do primeiro bimestre: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("entre com a sua nota do segundo bimestre: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("entre com a sua nota do terceiro bimestre: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("entre com a sua nota do quarto bimestre: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media< 5)
                situacao = "em prova final";
            else
                situacao = "Aprovado! Boas férias";

            Console.WriteLine("sua média é {0}", media);
            Console.WriteLine("Você está {0}", situacao);
        }

    }
}
   
