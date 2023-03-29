using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //exercício 1
            //int I;
            //float flo;
            //Console.WriteLine("A afirmativa do exercício 1 está errada pois não é possível atribuir valores float em valores Int");
            //Console.WriteLine("Podemos resolver esse problema aproximando o valor por meio do comando MathRound, se o número depois da vírgula fo5 <= 5 o número inteiro será o mesmo se o número depois da vírgula for > 5 somará 1 ao número inteiro");
            //flo = 24.3f;
            //I = (int)Math.Round(flo);

            //Console.WriteLine(I);
            //Console.ReadKey();


            //exercício 2
            //Console.WriteLine("ConsoleReadLine(): é responsável por ler uma linha, ou seja, todos os caracteres até que encontre um indicador de fim de linha");
            //Console.WriteLine("ConsoleRead(): é responsável por ler unicamente um caracter e retornar um inteiro indicando qual seria o caractere escolhido");

            //3 Console.WriteLine("O programa só consegue ler uma variavél se ela for a do mesmo tipo declarda inicialmente");


            //exercício 4
            //int num, num2, num3;
            //Console.WriteLine(
            //    "Entre com um número:");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");
            //Console.ReadKey();


            // Console.WriteLine("O objetivo do programa é identificar se o valor digitado é correspondente a mensagem 1 ou a mensagem 2");
            // Console.WriteLine("se digitar-se o valor 8 a saída será:mensagem2");
            // Console.WriteLine("se digitar-se o valor 27 a saída será: mensagem2");
            // Console.WriteLine("se digitar-se o valor 28 a saída será: mensagem1");



            //exercício 5


            //double MRU, d, t;
            //Console.WriteLine("Digite o valor da distância percorrida");
            //d = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do tempo percorrido");
            //t = double.Parse(Console.ReadLine());

            //MRU = 0 + d * t;

            //Console.WriteLine("Sua velocidade percorrida foi de:" + MRU);

            //Console.ReadLine();



            //exercício 6
            //int o;
            //Console.WriteLine("Digite um número qualquer");
            // o = int.Parse(Console.ReadLine());

            //if (o % 3 == 0 && o % 5 == 0 && o % 10 == 0)
            //{
            //    Console.WriteLine("O valor é divisível po 3, 5 e 10");
            //}


            //else if (o % 3 == 0 && o % 5 == 0)
            //{
            //    Console.WriteLine("O valor é divisível po 3 e 5");
            //}


            // else if (o % 3 == 0) 
            //{
            //    Console.WriteLine("O valor é divisível po 3");
            //}

            //else if (o % 5 == 0 ) 
            //{
            //    Console.WriteLine("O valor é divisível po 5");
            //}

            //else
            //{
            //    Console.WriteLine("O valor não é dívisivel por 3, 5 e 10");
            //}

            //Console.ReadKey();

            //exercício 7 
            float PU, C, IsL;
            Console.WriteLine("======Menu=====");
            Console.WriteLine("1- Royal");
            Console.WriteLine("2- Wiskas");
            Console.WriteLine("3- Golden");
            Console.WriteLine("4- Nutrien");
            Console.WriteLine("5- Specialcat");
            Console.WriteLine("6- Marba");
            Console.WriteLine("7- Gatus");

            PU = float.Parse(Console.ReadLine());

            switch (cargo)
            {





                case 1:
                    Console.WriteLine("Digite o seu salario atual:");

                    salario = float.Parse(Console.ReadLine());
                    aumento = salario + (salario * 0.075f);
                    diferenca = aumento - salario;
                    Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                    break;













            }
    }
}
