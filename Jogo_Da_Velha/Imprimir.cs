using System;

namespace Jogo_Da_Velha
{
    public class Imprimir
    {
        private string[] matriz = {"1","2","3","4","5","6","7","8","9"};

        //esse método receberá um valor e a partir dele preencerá a posição com a escolha X ou O int posicao,string escolha
        public void printJogo()
        {
            Console.Clear();
            Console.WriteLine("\t-----------JOGO DA VELHA-----------");
            Console.WriteLine("");

            // for (int i=0; i < matriz.Length; i++)
            // {
            //    if(i+1 == posicao)
            //     matriz[i] = escolha;
            // }

            Console.WriteLine("\t----------------------------------");
            Console.WriteLine("\t|    "+matriz[0]+"     |     "+matriz[1]+"     |    "+matriz[2]+"    |");
            Console.WriteLine("\t----------------------------------");
            Console.WriteLine("\t|    "+matriz[3]+"     |     "+matriz[4]+"     |    "+matriz[5]+"    |");
            Console.WriteLine("\t----------------------------------");
            Console.WriteLine("\t|    "+matriz[6]+"     |     "+matriz[7]+"     |    "+matriz[8]+"    |");
            Console.WriteLine("\t----------------------------------");
            
            Console.WriteLine("");
        }
    }
}