using System;
using System.Collections.Generic;

namespace BLASTOFF
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual exercício deseja verificar:");
            Console.WriteLine("");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("7 - Exercício 7");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Exer1(); break;
                case 2: Exer2(); break;
                case 3: Exer3(); break;
                case 4: Exer4(); break;
                case 5: Exer5(); break;
                case 6: Exer6(); break;
                case 7: Exer7(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Exer1()
        {
            Console.Clear();
            Console.WriteLine("Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.");
            Console.WriteLine("");
            Console.WriteLine("Digite a idade I: ");
            int I = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade J: ");
            int J = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade K: ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade Y: ");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = ((float)I + (float)J + (float)K + (float)X + (float)Y) / 5;

            Console.WriteLine($"A média das idades é: {resultado.ToString("N2")}");
            Console.ReadKey();
            Menu();
        }
        static void Exer2()
        {
            Console.Clear();
            Console.WriteLine("Dada a distância A e o combustível B, faça um algoritmo para calcular o consumo médio.");
            Console.WriteLine("");
            Console.WriteLine("Digite a distância percorrida A: ");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o combustivel gasto B: ");
            float B = float.Parse(Console.ReadLine());

            float consumo = A / B;

            Console.WriteLine($"O consumo médio de combustível foi de: {consumo.ToString("N2")}");
            Console.ReadKey();
            Menu();
        }
        static void Exer3()
        {
            Console.Clear();
            Console.WriteLine("Dados três numeros (a, b, c), faça um algoritmo para mostrar o menor numero.");
            Console.WriteLine("");
            Console.WriteLine("Digite o numero a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero c: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && a < c)
                Console.WriteLine($"O menor numero é: {a}");
            else if (a < b && a == c)
                Console.WriteLine($"O menor numero é: {a}");
            else if (b < a && b == c)
                Console.WriteLine($"O menor numero é: {b}");
            else if (b == a && b < c)
                Console.WriteLine($"O menor numero é: {b}");
            else if (a < b && a < c)
                Console.WriteLine($"O menor numero é: {a}");
            else if (b < a && b < c)
                Console.WriteLine($"O menor numero é: {b}");
            else
                Console.WriteLine($"O menor numero é: {c}");
            Console.ReadKey();
            Menu();
        }
        static void Exer4()
        {
            Console.Clear();
            Console.WriteLine("Faça um algoritmo que converta a temperatura de C para F.utileze a formula C= 5/9(F-32).");
            Console.WriteLine("");
            Console.WriteLine("Digite a temperatura em graus ceusius: ");
            float temperaturaC = float.Parse(Console.ReadLine());

            float temperaturaF = (temperaturaC * 9 / 5) + 32;

            Console.WriteLine($"Essa é a temperatura em F: {temperaturaF.ToString("N2")}°");
            Console.ReadKey();
            Menu();
        }
        static void Exer5()
        {
            Console.Clear();
            Console.WriteLine("Faça um algoritmo para apresentar se dois numeros são multiplos.");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro numero: ");
            int primeiroNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int segundoNum = int.Parse(Console.ReadLine());

            if (primeiroNum == segundoNum)
                Console.WriteLine($"os numeros {primeiroNum} e {segundoNum} são multiplos.");
            else if (primeiroNum > segundoNum)
            {
                int divisao = primeiroNum % segundoNum;
                if (divisao == 0)
                    Console.WriteLine($"os numeros {primeiroNum} e {segundoNum} são multiplos.");
                else
                    Console.WriteLine($"os numeros {primeiroNum} e {segundoNum} não são multiplos.");
            }
            else
            {
                int divisao = segundoNum % primeiroNum;
                if (divisao == 0)
                    Console.WriteLine($"os numeros {primeiroNum} e {segundoNum} são multiplos.");
                else
                    Console.WriteLine($"os numeros {primeiroNum} e {segundoNum} não são multiplos.");
            }
            Console.ReadKey();
            Menu();
        }
        static void Exer6()
        {
            Console.Clear();
            Console.WriteLine("Uma partida de futebol iniciou na hora A e terminou na hora B.Faça um algortimo que calcule o tempo que durou a partida.");
            Console.WriteLine("");
            Console.WriteLine("Digite a hora que começou a partida no formato (00:00).");
            DateTime A = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a hora que acabou a partida no formato (00:00).");
            DateTime B = Convert.ToDateTime(Console.ReadLine());
            TimeSpan diferenca;
            diferenca = B.Subtract(A);
            Console.WriteLine($"O tempo que durou a partida foi: {diferenca}");
            Console.ReadKey();
            Menu();
        }
        static void Exer7()
        {
            Console.Clear();
            Console.WriteLine("Dada uma lista A[1, 2, 3,...],faça um algoritmo que retorne uma lista somente com os numeros pares.");
            Console.WriteLine("");
            Console.WriteLine("Digite a quantidades de numeros da lista: ");
            int quantidade = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    lista.Add(num);
            }
            Console.WriteLine("quantidade:{0}", lista.Count);
            for (int i = 0, length = lista.Count; i < length; i++)
            {
                Console.WriteLine("item:{0},Pares:{1}", i, lista[i]);
            }

            Console.ReadKey();
            Menu();
        }
    }
}
