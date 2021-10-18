using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("--------CALCULADORA SIMPLES---------");
                Console.WriteLine("\tDigite [1] para somar");
                Console.WriteLine("\tDigite [2] para subtrair");
                Console.WriteLine("\tDigite [3] para dividir");
                Console.WriteLine("\tDigite [4] para multiplicar");
                Console.WriteLine("\tDigite [0] para fechar calculadora");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                    case 0:
                        Console.WriteLine("Saindo !");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
                
            } while (escolha !=0);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine(v1 + " + "+v2+" = "+resultado);
            
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo  valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine(v1 + " - "+v2+" = "+resultado);
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine(v1 + " / "+v2+" = "+resultado);
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine(v1 + " * "+v2+" = "+resultado);
        }
    }
}
