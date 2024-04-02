using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double total = 0;
            int cont = 0;
            string respost;
            Console.WriteLine("Deseja começar? (S/N)");
            respost = Console.ReadLine().ToUpper();
            while (respost == "S")
            {
                Console.WriteLine("Qual a forma de contratação do funcionário [A-Assalariado,H-Horista,C-Comissado]");
                string respost2 = Console.ReadLine().ToUpper();
                switch (respost2)
                {
                  case "A":
                  Console.WriteLine("Informe o valor do salário: ");
                  double salario = double.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o valor do desconto: ");
                    double desc = double.Parse(Console.ReadLine());
                    double salb = salario - desc;
                    Console.WriteLine("O salário bruto do funcionário é de: " + salb.ToString("C"));
                    cont++;
                    total += salb;
                    break;

                    case "H":
                        Console.WriteLine("Digite o valor por hora: ");
                        double valh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                        int quanth = int.Parse(Console.ReadLine());

                        salb = quanth * valh;
                        Console.WriteLine("Salário bruto do funcionário é de: " + salb.ToString("C"));
                        cont++;
                        total += salb;
                        break;
                    case "C":
                        Console.WriteLine("Digite o valor que o funcionário ganha por peça: ");
                        double valp = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade de peças que o funcionário vendeu: ");
                        int quantp = int.Parse(Console.ReadLine());

                        salb = quantp * valp;
                        Console.WriteLine("O salário bruto do funcionário é de: " + salb.ToString("C"));
                        cont++;
                        total += salb;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Deseja continuar: ");
                respost = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de funcionários cadastrados é: " + cont);
            Console.WriteLine("O total da folha de pagamento é: " + total.ToString("C"));
            Console.WriteLine("A média salarial é de: " + (total / cont).ToString("C"));
            Console.ReadKey();
        }
    }
}