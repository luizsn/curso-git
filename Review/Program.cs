using System;
using System.Globalization; // Neste profejto serve para poder imprimir os números com "." ao inés de ","
namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 2147483647;
            int y = 0;
            y = x + 101;
            float k = 4.5f;
            char car = 'G';
            char car1 = '\u0041';
            string name = "Zé Mané";
            Object obj = "Jonh Armless"; // Tipo de dado que pode ser qualquer tipo de dado (objeto genérico)
            Object obj1 = 12.4;

            int a = int.MinValue;
            int b = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(car);
            Console.WriteLine(car1);
            Console.WriteLine(name);
            Console.WriteLine(obj);
            Console.WriteLine(obj1);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------------------------------");

            double sal = 258.1245785;
            Console.WriteLine(sal);
            Console.WriteLine(sal.ToString("F2")); // A classe ToString serve para limitar o número de casas decimais.
            Console.WriteLine(sal.ToString("F2", CultureInfo.InvariantCulture)); // a função InvariantCulture ignora qualquer formatação relacionada a um país.
            Console.WriteLine("--------------------------------------------");
            
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e saldo bancário de {2:F2} reais.", nome, idade, saldo); // Imprimindo várias variáveis utilizando Placeholders
            Console.WriteLine($"{nome} tem {idade} anos e saldo bancário de {saldo:F2} reais"); // Imprimindo várias variáveis utilizando a técnica da Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos " + "e saldo bancário de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais." ); // imprimindo várias variáveis utilizando Concatenação
            
            */
            /*
            // ***************************Exercício de fixação 1 - Saída em C#

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produto:");
            Console.WriteLine(produto1 + ", cujo preço é R$" + preco1.ToString("F2") + " reais.");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2} reais.");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}.");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + preco3.ToString("F8"));
            Console.WriteLine("Arredondamento (três casas decimais) : " + preco3.ToString("F3"));
            Console.WriteLine("Separado decimal invarialt culture: " + preco3.ToString("F3",CultureInfo.InvariantCulture));
            */

            //*********************************Operadores Matemáticos
            /*
            int x1 = 3 + 4 * 2;
            int x2 = (3 + 4) * 2;
            int x3 = 17 % 3;
            double x4 = 10 / 8; // Este resultado não gera um número real.
            double x5 = (double) 10 / 8; // Este gera numero real.
            double x6 = 10.0 / 8; // Este também.

            double a = 1.0, b = -3.0, c = -4.0; // Declaração de várias variáveis em uma única linha.
            double delta = Math.Pow(b,2.0)- 4.0 * a * c; // b^2 pode ser b*b ou Math.Pow(b,2.0) para real.
            double r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            Console.WriteLine(x6);
            Console.WriteLine("As raízes desta equação são: x1 = {0} e x2 = {1}",r1,r2);
            */

            // ************************Operadores de atribuição
            /*
            =  | a = 10; a RECEBE 10
            += | a += 2; a RECEBE a + 2; Este operador também serve para string
            -= | a -= 2; a RECEBE a - 2;
            *= | a *= 2; a RECEBE a * 2;
            /= | a /= 2; a RECEBE a / 2;
            %= | a %= 3; a RECEBE a % 3;
            a++| a = a+1; se b = a++, o valor de b será igual ao de a, pois primeiro ele aloca a em b e depos incrementa a;
            a--| a = a-1;
            ++a| a = a+1; se b = ++a, o valor de b será igual ao de a+1, pois primeiro ele incrementa a e depois aloca a em b;
            --a| a = a-1;
            
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
            */

            // **************************Conversão Implícita e casting | Na conversão implícita o próprio compilador converte os dados como no
            // exemplo { float a = 4.5f | double b | b = a;
            // No caso do casting é necessário informar ao complilador o tipo de dados requerido.
            /*
            float a = 4.5f;
            double b = a;           // Conversão implícita
            Console.WriteLine(b);

            double c = 4.32;
            float d = (float)c;        // Conversão por Casting
            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double g = e / f;      // Neste caso o valor em g será do tipo inteiro
            double h = (double)e / f;  // Neste caso o valor em h será do tipo double, por causa do Casting
            Console.WriteLine(g);
            Console.WriteLine(h);
            */

            // *************************Entrada de dados Parte 1
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string cores = Console.ReadLine();
            string[] vet = cores.Split(',');
            string[] vet1 = Console.ReadLine().Split(' '); // Forma direta de ler os dados

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(vet1[0]);
            Console.WriteLine(vet1[1]);
            Console.WriteLine(vet1[2]);
            */

            // ****************************Entrada de dados parte 2

            /*
            int n1 = int.Parse(Console.ReadLine());    // O comando int.Parse converte uma string em um número inteiro
            char ch = char.Parse(Console.ReadLine());  // O atributo Parse serve para converter uma string para o dado desejado.
            double n2 = double.Parse(Console.ReadLine()); // Desta forma o valor real deverá ser escrito com ",".
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Aqui pode ser escrito com "."
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);


            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString(CultureInfo.InvariantCulture));  // Desta forma imprime com ponto "." ao invés de virgula ","
            Console.WriteLine("{0}, que é do gênero {1}, com {2} anos de idade e {3} metros de altura",nome,sexo,idade,altura.ToString(CultureInfo.InvariantCulture));
            */

            // **************************Exercício de fixação 2
            /*
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe quantos quartos tem em sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu último nome, idade e altura: ");
            string[] dados = Console.ReadLine().Split(' ');
            string last_name = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(dados[0]);
            Console.WriteLine(dados[1]);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("O Sr. {0} tem {1} anos de idade e {2} metros de altura.",last_name,idade,altura);
            */

            //****************************************************************************//
            //Exercícios sobre Estrutura Sequencial (entrada, processamento, saída)

            //********************************** Exercício 1
            /*
            int n1, n2, soma;
            Console.WriteLine("Digite dois números inteiros separados por um espaço.");
            string[] num = Console.ReadLine().Split(' ');
            n1 = int.Parse(num[0]);
            n2 = int.Parse(num[1]);

            soma = n1 + n2;

            Console.WriteLine("O valor da soma é: {0}",soma);
            */


            //************************** Exercício 2
            /*
            double pi, area, raio;
            pi = 3.14159;

            Console.WriteLine("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: {0}",area.ToString("F4",CultureInfo.InvariantCulture));
            */

            //****************************** Exercício 3
            /*
            int A, B, C, D, soma;
            Console.WriteLine("Digite quatro números inteiros separados por um espaço.");
            string[] num = Console.ReadLine().Split(' ');
            A = int.Parse(num[0]);
            B = int.Parse(num[1]);
            C = int.Parse(num[2]);
            D = int.Parse(num[3]);

            soma = A * B - C * D;

            Console.WriteLine("O resultado da equação é: {0}", soma);
            */

            //********************** Exercício 4
            /*
            int nf;
            double ht, vh, salario;

            Console.Write("Informe o número do funcionário: ");
            nf = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de horas trabalhadas e o valor da hora trabalhada: ");
            string[] sal = Console.ReadLine().Split(' ');

            ht = double.Parse(sal[0]);
            vh = double.Parse(sal[1]);
            salario = ht * vh;


            Console.WriteLine("O salário do funcionário {0} é R$ {1} reais." , nf, salario.ToString("F2",CultureInfo.InvariantCulture));
            */
            //******************* Exercício 5
            /*
            double v1, v2, qt1, qt2, total;
            Console.Write("Por favor informe o código da peça 1, a quantidade de peças e o valor da peça: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            Console.Write("Por favor informe o código da peça 2, a quantidade de peças e o valor da peça: ");
            string[] peca2 = Console.ReadLine().Split(' ');

            v1 = double.Parse(peca1[2]);
            qt1 = double.Parse(peca1[1]);
            v2 = double.Parse(peca2[2]);
            qt2 = double.Parse(peca2[1]);

            total = v1 * qt1 + v2 * qt2;

            Console.WriteLine("O valor total é de: R$ {0} reais.",total.ToString("F2",CultureInfo.InvariantCulture));
            */

            //***********************Exercício 6
            /*
            double A, B, C, areatriangulo, areacirculo, areatrapezio, areaquadrado, arearetangulo, pi;

            pi = 3.14159;
            Console.Write("Digite três números reais com duas casas decimais: " );
            string[] dados = Console.ReadLine().Split(' ');
            A = double.Parse(dados[0]);
            B = double.Parse(dados[1]);
            C = double.Parse(dados[2]);

            // Área do triângulo

            areatriangulo = (A * C) / 2;

            // Área do círculo

            areacirculo = pi*C*C;

            // Área do trapézio

            areatrapezio = ((A + B) / 2) * C;

            // Área do quadrado

            areaquadrado = B * B;

            // Área do retângulo

            arearetangulo = A * B;

            Console.WriteLine("TRIÂNGULO: {0}",areatriangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", areacirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: {0}", areatrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", areaquadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: {0}", arearetangulo.ToString("F3", CultureInfo.InvariantCulture));
            */

            /* Operadores de comparação e operadores lógicos
            //  Operador Significado
            
                  > maior
                  < menor
                  >= maior ou igual
                  <= menor ou igual
                  == igual
                  != diferente
             

              Operador Significado

                  && E
                  || OU
                   ! NÃO

            */

            // Estrutura condicional if; else; else if
            /*
            Console.WriteLine("Digite a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora <18)
            {
                Console.WriteLine("Boa tarde!");
            }    
            else 
            {
                Console.WriteLine("Boa noite!");
            }

            */

            //**************************** Exercícios parte 2 - Estrutura Condicional

            // Exercício 1
            /*
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x>=0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            */

            // Exercício 2
            /*
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */

            // Exercício 3
            /*
            Console.Write("Digite dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A>B) 
            {
                if (A%B==0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }
            else                                                    // Forma orelha seca
            {
                if (B%A == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else                                                         // Forma otimizada
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            */

            // Exercício 4
            /*
            Console.Write("Digite dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int hora = 0;
            if (A>=B)
            {
                hora = 24 - A + B;                
            }
            else 
            {
                hora = B - A;
            }
            
            Console.WriteLine("O jogo durou " + hora + "horas(s)");
            */

            // Exercício 5
            /*
            Console.WriteLine("Digite o código do produto e a quantidade do produto: ");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            // Exercício 6
            /*
            Console.WriteLine("Digite um número real: ");
            double n1 = double.Parse(Console.ReadLine());

            if (n1<=25.0 && n1>=0.0)
            {
                Console.WriteLine("Intervalo (0 25]");
            }
            else if (n1 <= 50.0 && n1 >= 0.0)
            {
                Console.WriteLine("Intervalo (25 50]");
            }
            else if (n1 <= 75.0 && n1 >= 0.0)
            {
                Console.WriteLine("Intervalo (50 75]");
            }
            else if (n1<= 100.0 && n1 >= 0.0)
            {
                Console.WriteLine("Intervalo (75 100]");
            }
            else
            {
                Console.WriteLine("Fora da faixa");
            }

            */

            // Exercício 7
            /*
            Console.Write("Digite dois valores reais com uma casa decimal: ");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            */

            // Exercício 8 
            /*
            Console.Write("Digite o salário com duas casas decimais: ");
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0.0;

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            //************************ Estrutura de Repetição (WHILE)

            // Exercício 1
            /*
            Console.WriteLine("Digite uma senha de 04 dígitos.");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha incorreta. Tente outra vez.");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido"); */

            // Exercício 2
            /*
            Console.Write("Digite as coordenadas X e Y: ");
            string[] coord = Console.ReadLine().Split(' ');
            double X = double.Parse(coord[0]);
            double Y = double.Parse(coord[1]);

            while (X!=0 && Y!=0)
            {
                if (X>0 && Y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (X>0 && Y < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                else if (X<0 && Y<0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                Console.Write("Digite as coordenadas X e Y: ");
                coord = Console.ReadLine().Split(' ');
                X = double.Parse(coord[0]);
                Y = double.Parse(coord[1]); 
            } */

            // Exercício 3
            /*
            int gas =0, alc =0, die = 0;
            
            Console.WriteLine("Informe com qual combustivel foi abastecido.");
            Console.WriteLine("Digite 1 para Ácool.");
            Console.WriteLine("Digite 2 para Gasolina.");
            Console.WriteLine("Digite 3 para Diesel.");
            Console.WriteLine("Digite 4 para encerrar.");
            int comb = int.Parse(Console.ReadLine());

            while (comb != 4)
            {
                if (comb == 1)
                {
                    alc++;
                }
                else if (comb == 2)
                {
                    gas = gas + 1;
                }
                else if (comb == 3)
                {
                    die = die + 1;
                }
                else
                {
                    Console.WriteLine("Código Incorreto. Digite um dos códigos abaixo");
                }
                Console.WriteLine("Informe com qual combustivel foi abastecido.");
                Console.WriteLine("Digite 1 para Ácool.");
                Console.WriteLine("Digite 2 para Gasolina.");
                Console.WriteLine("Digite 3 para Diesel.");
                Console.WriteLine("Digite 4 para encerrar.");
                comb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Quantidade de clientes que abasteceram com Ácool: " + alc + ".");
            Console.WriteLine("Quantidade de clientes que abasteceram com Gasolina: " + gas + ".");
            Console.WriteLine("Quantidade de clientes que abasteceram com Diesel: " + die + ".");
            */

            // ****************** Estrutura de repetição FOR

            // Exercício 1
            /*
            Console.Write("Digite um número inteiro de entre 1 e 1000: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i=i+2)
            {
                Console.WriteLine(i);
            }
            */

            // Exercício 2
            /*
            Console.Write("Digite o número de repetições: ");
            int n = int.Parse(Console.ReadLine());
            int ent = 0, sai = 0;

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Digite o valor " + i + ".");
                int valor = int.Parse(Console.ReadLine());
                if (valor >=10 && valor <= 20)
                {
                    ent++;
                }
                else
                {
                    sai++;
                }
            }
            Console.WriteLine("Quantidade de números dentro da faixa: " + ent);
            Console.WriteLine("Quantidade de números fora da faixa: " + sai);
            */

            // Exercício 3
            /*
            Console.Write("Digite o número de repetições: ");
            int n = int.Parse(Console.ReadLine());
            double[] media = new double[3];

            for (int i = 0; i <= (n-1); i++)
            {
                Console.Write("Digite três números reais: ");
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0]);
                double n2 = double.Parse(vet[1]);
                double n3 = double.Parse(vet[2]);

                media[i] = (2.0 * n1 + 3.0 * n2 + 5.0 * n3) / 10.0;   
                    
            }
            Console.WriteLine(media[0].ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(media[1].ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(media[2].ToString("F1", CultureInfo.InvariantCulture));
            */

            // Exercício 4
            /*
            Console.Write("Digite o número de repetições: ");
            int n = int.Parse(Console.ReadLine());
            double res = 0;

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("Entre com o par de números: ");
                string[] num = Console.ReadLine().Split(' ');
                double n1 = double.Parse(num[0]);
                double n2 = double.Parse(num[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }
                else 
                {
                    res = n1 / n2;
                    Console.WriteLine(res.ToString("F1",CultureInfo.InvariantCulture)); 
                } 


            }
            */

            // Exercício 5
            /*
            Console.Write("Digite o número N a ser fatorado: ");
            int n = int.Parse(Console.ReadLine());
            int mul = 1;
            if (n != 0)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    mul = mul * (n - i);
                    
                }
                Console.WriteLine(mul);
            }
            else
            {
                Console.WriteLine(mul);
            }
            */

            // Exercício 6
            /*
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int resto = 0;  
            for (int i=1; i<=n; i++)
            {
                resto = n % i;
                if (resto == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // Exercício 7

            Console.Write("Digite o número de linhas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3));
            }

        }
       
    }
}
