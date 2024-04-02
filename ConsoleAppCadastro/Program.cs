using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int cont_a = 0;
            int cont_d = 0;
            int cont_e = 0;
            int cont_m = 0;

            Console.WriteLine("Deseja começar o programa[S-SIM/N-NÃO]");
            string resp = Console.ReadLine().ToLower();
            while(resp == "s")
            {
                Console.WriteLine("Deseja cadastrar qual curso[A-ADMINISTRAÇÃO/M-MECATRÔNICA/D-DESENVOLVIMENTO DE SISTEMAS/E-EDIFICAÇÕES]");
                string curso = Console.ReadLine().ToLower();

                switch (curso)
                {
                    case "a":
                        Console.WriteLine("Deseja cadastrar um aluno [S-SIM/N-NÃO]?");
                        string resp_a = Console.ReadLine().ToLower();
                        if (resp_a == "s" && cont_a <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            cont_a++;
                            cont++;
                        }
                        else
                        {
                            Console.Write("A quantidade de vagas foi atingida.");
                        }
                        Console.WriteLine("Deseja cadastrar um aluno novamente [S-SIM/N-NÃO]?");
                        resp_a = Console.ReadLine().ToLower();
                        break;
                    case "m":
                        Console.WriteLine("Deseja cadastrar um aluno [S-SIM/N-NÃO]?");
                        string resp_m = Console.ReadLine().ToLower();
                        if (resp_m == "s" && cont_a <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            cont_m++;
                            cont++;
                        }
                        else
                        {
                            Console.Write("A quantidade de vagas foi atingida.");
                        }
                        Console.WriteLine("Deseja cadastrar um aluno novamente [S-SIM/N-NÃO]?");
                        resp_m = Console.ReadLine().ToLower();
                        break;
                    case "e":
                        Console.WriteLine("Deseja cadastrar um aluno [S-SIM/N-NÃO]?");
                        string resp_e = Console.ReadLine().ToLower();
                        if (resp_e == "s" && cont_a <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado.");
                            cont++;
                            cont_e++;
                        }
                        else
                        {
                            Console.Write("A quantidade de vagas foi atingida.");
                        }
                        Console.WriteLine("Deseja cadastrar um aluno novamente [S-SIM/N-NÃO]?");
                        resp_e = Console.ReadLine().ToLower();
                        break;
                    case "d":
                        Console.WriteLine("Deseja cadastrar um aluno?");
                        string resp_d = Console.ReadLine().ToLower();
                        if (resp_d == "s" && cont_a <= 5)
                        {
                            Console.WriteLine("Aluno cadastrado. [S-SIM/N-NÃO]");
                            cont++;
                            cont_d++;
                        }
                        else
                        {
                            Console.Write("A quantidade de vagas foi atingida.");
                        }
                        Console.WriteLine("Deseja cadastrar um aluno novamente [S-SIM/N-NÃO]? ");
                        resp_d = Console.ReadLine().ToLower();
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;

                }
                Console.Write("Deseja continuar[S-SIM/N-NÃO]");
                resp = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Foram cadastrados "+cont+" alunos, sendo "+cont_a+" de administração, "+cont_d+" alunos de desenvolvimento de sistemas, "+cont_e+" de edificações e "+cont_m+" de mecatrônica.");
            Console.ReadKey();
        }
    }
}
