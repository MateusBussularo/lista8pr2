using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista8pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, para = 4, i;
            double preço, total1, total2 = 0;

            i = 0;
            do
            {
                Console.WriteLine("Qual a quantidade dos produtos");
                quantidade = int.Parse(Console.ReadLine());
                if (quantidade != 0)
                {
                    Console.WriteLine("Qual o preço do produto");
                    preço = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite 0 para SAIR e 3 para continuar");
                    para = int.Parse(Console.ReadLine());

                    total1 = quantidade * preço;
                    total2 = total1 + total2;
                    i++;
                }
            } while (quantidade != 0);

            Console.WriteLine("Suas compra custou {0} reais ", total2);
        }
        public static void Exercicio2()
        {
            string nome, nomemenor = "", nomemaior = "";
            int numeroitens, parada = 2;
            float valor, maiorvalor, menorvalor;

            maiorvalor = float.MinValue;
            menorvalor = float.MaxValue;

            do
            {
                if (parada != 1)
                {
                    Console.WriteLine("Qual o nome do pruduto");
                    nome = Console.ReadLine();

                    Console.WriteLine("Qual a quantidade de produtos");
                    numeroitens = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o preço do produto");
                    valor = float.Parse(Console.ReadLine());

                    float total = numeroitens * valor;
                    if (total > maiorvalor)
                    {
                        maiorvalor = total;
                        nomemaior = nome;
                    }

                    if (total < menorvalor)
                    {
                        menorvalor = total;
                        nomemenor = nome;
                    }
                }
                Console.WriteLine("Digite 1 para SAIR ou 2 para continuar");
                parada = int.Parse(Console.ReadLine());

            } while (parada != 1);

            Console.WriteLine("Maior quantia investida {0} no produto {1} ", maiorvalor, nomemaior);
            Console.WriteLine("Menor quantia investida {0} no produto {1} ", menorvalor, nomemenor);
        }
        public static void Exercicio3()
        {
            int somaPeso = 0, total, peso, i = 0;

            Console.WriteLine("Informe o total de avaliações do bimestre:");
            total = int.Parse(Console.ReadLine());

            if (total <= 0)
                Console.WriteLine("Número de avaliações inválido!");
            do
            {
                if (i < total) ;
                {
                    Console.WriteLine("Infome o peso da avalição {0}", i + 1);
                    peso = int.Parse(Console.ReadLine());

                    somaPeso += peso;
                    i++;
                }
            } while (i < total);


            if (somaPeso < 100)
                Console.WriteLine("O peso das avalições é Insuficiente!");
            else if (somaPeso > 100)
                Console.WriteLine("O peso das avaliações é Excedente!");
            else
                Console.WriteLine("O peso das avaliações é Adequado.");

        }
        public static void Exercicio4()
        {
            string sigla;
            Console.WriteLine("\nAM");
            Console.WriteLine("AC");
            Console.WriteLine("AL");
            Console.WriteLine("AP");
            Console.WriteLine("BA");
            Console.WriteLine("CE");
            Console.WriteLine("ES");
            Console.WriteLine("GO");
            Console.WriteLine("MA");
            Console.WriteLine("MT");
            Console.WriteLine("MS");
            Console.WriteLine("MG");
            Console.WriteLine("PA");
            Console.WriteLine("PB");
            Console.WriteLine("PR");
            Console.WriteLine("PE");
            Console.WriteLine("PI");
            Console.WriteLine("RJ");
            Console.WriteLine("RN");
            Console.WriteLine("RS");
            Console.WriteLine("RO");
            Console.WriteLine("RR");
            Console.WriteLine("SC");
            Console.WriteLine("SE");
            Console.WriteLine("TO");
            Console.WriteLine("DF");

            Console.WriteLine("\nQual a sigla você deseja usar");
            sigla = Console.ReadLine();

            switch (sigla)
            {
                case "AM":
                    Console.WriteLine("Amazonas");
                    break;
                case "AC":
                    Console.WriteLine("Acre");
                    break;
                case "AL":
                    Console.WriteLine("Alagoas");
                    break;
                case "AP":
                    Console.WriteLine("Amapa");
                    break;
                case "BA":
                    Console.WriteLine("Bahia");
                    break;
                case "CE":
                    Console.WriteLine("Ceara");
                    break;
                case "ES":
                    Console.WriteLine("Espirito Santo ");
                    break;
                case "GO":
                    Console.WriteLine("Goias");
                    break;
                case "MA":
                    Console.WriteLine("Maranhao");
                    break;
                case "MT":
                    Console.WriteLine("Mato Grosso");
                    break;
                case "MS":
                    Console.WriteLine("Mato Grosso do sul");
                    break;
                case "MG":
                    Console.WriteLine("Minas Gerais");
                    break;
                case "PA":
                    Console.WriteLine("Paraiba");
                    break;
                case "PR":
                    Console.WriteLine("Parana");
                    break;
                case "PE":
                    Console.WriteLine("Pernambuco");
                    break;
                case "PI":
                    Console.WriteLine("Piaui");
                    break;
                case "RJ":
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case "RN":
                    Console.WriteLine("Rio Grande do Norte");
                    break;
                case "RS":
                    Console.WriteLine("Rio Grande do Sul");
                    break;
                case "RO":
                    Console.WriteLine("Rondonia");
                    break;
                case "RR":
                    Console.WriteLine("Roraima");
                    break;
                case "SC":
                    Console.WriteLine("Santa Catrina");
                    break;
                case "SE":
                    Console.WriteLine("Sergipe");
                    break;
                case "TO":
                    Console.WriteLine("Tocantins");
                    break;
                case "DF":
                    Console.WriteLine("Distrito Federal");
                    break;
                default:
                    Console.WriteLine("Siga invalida");
                    break;
            }
        }
        public static void Exercicio5()
        {
            int mes, dia;
            string estacao = "";
            Console.WriteLine("1 - Janeiro");
            Console.WriteLine("2 - Fevereiro");
            Console.WriteLine("3 - Marco");
            Console.WriteLine("4 - Abril");
            Console.WriteLine("5 - Maio");
            Console.WriteLine("6 - Junho");
            Console.WriteLine("7 - Julho");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Setembro");
            Console.WriteLine("10 - Outubro");
            Console.WriteLine("11 - Novembro");
            Console.WriteLine("12 - Dezembro");

            Console.WriteLine("Qual o mes ? ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                case 2:
                    estacao = "Verao";
                    break;
                case 3:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 21) estacao = "Verao";
                    else estacao = "Outono";
                    break;

                case 4:
                case 5:
                    estacao = "Outono";
                    break;
                case 6:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 21) estacao = "Inverno";
                    else estacao = "Outono";
                    break;
                case 7:
                case 8:
                    estacao = "Inverno";
                    break;
                case 9:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 23) estacao = "Primavera";
                    else estacao = "Inverno";
                    break;
                case 10:
                case 11:
                    estacao = "Primavera";
                    break;
                case 12:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 22) estacao= "Verao";
                    else estacao = "Primavera";
                    break;
            }
            Console.WriteLine("A estacao do ano é {0}", estacao);
            Console.ReadKey();
        }
        public static void Exercicio6()
        {
            float peso, altura, imc;
            Console.WriteLine("Qual o seu peso ?");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura ?");
            altura = float.Parse(Console.ReadLine());

            imc = peso / altura * altura;

            if (imc <= 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc <= 24.9 && imc >= 18.5)
                Console.WriteLine("Peso normal");
            else if (imc >= 25 && imc <= 29.5)
                Console.WriteLine("Sobrepeso");
            else if (imc >= 30 && imc <= 34.9)
                Console.WriteLine("obesidade grau 1");
            else if (imc >= 35 && imc <= 39.9)
                Console.WriteLine("obsedidade grau 2");
            else
                Console.WriteLine("obsediade grau 3 (morbida)");

        }
        public static void Exercicio7()
        {
            int numero, numtotal, i = 1;

            Console.WriteLine("Informe um numero");
            numero = int.Parse(Console.ReadLine());
            do
            {
                if (numero % i == 0)
                {
                    numtotal = i;
                    Console.WriteLine(numtotal);
                    i++;
                }
                else
                    i++;
            }
            while (i != numero);
        }
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("Para sair - digite 0");
                Console.WriteLine("Para executar o exercicio 1 - digite 1");
                Console.WriteLine("Para executar o exercicio 2 - digite 2");
                Console.WriteLine("Para executar o exercicio 3 - digite 3");
                Console.WriteLine("Para executar o exercicio 4 - digite 4");
                Console.WriteLine("Para executar o exercicio 5 - digite 5");
                Console.WriteLine("Para executar o exercicio 6 - digite 6");
                Console.WriteLine("Para executar o exercicio 7 - digite 7");
                Console.WriteLine("======================================");

                opcao = int.Parse(Console.ReadLine()); //Lê a opção escolhida 

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
                        break;

                    default:
                        Console.WriteLine("Não é um exercicio valido");
                        break;
                }
            } while (opcao != 0);
        }
    }
}

        
    

