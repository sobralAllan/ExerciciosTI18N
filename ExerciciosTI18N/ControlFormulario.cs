using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;

        public ControlFormulario()
        {
            exercicio = new ModelExercicio();//Conecta a classe model e a control
            ConsultarOpcao = -1;
        }//fim do método construtor

        //Métodos modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do método

        public void Menu()
        {
            Console.WriteLine("\n\n ----- Menu ----- \n\n" +
                              "0. Sair\n"         +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "7. Exercício 07\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//mostrar menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpar dados antigos
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1;//Declarei do lado de fora
                        double nota2;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);

                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim da validação
                        } while (exercicio.ValidarNotas(nota2) == true);

                        //Chamar o método da média que está na classe model
                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine("O Antecessor é: " + exercicio.Antecessor(num));
                        break;
                    case 4:
                        double bas;
                        double alt;
                        do {
                            Console.WriteLine("Informe a base do retângulo: ");
                            bas = Convert.ToDouble(Console.ReadLine());
                            if(bas < 0)
                            {
                                Console.WriteLine("Erro! Informe um valor positivo!");
                            }
                        } while (bas < 0);

                        do
                        {
                            Console.WriteLine("Informe a altura do retângulo: ");
                            alt = Convert.ToDouble(Console.ReadLine());
                            if(alt < 0)
                            {
                                Console.WriteLine("Erro! Informe um valor positivo");
                            }
                        } while (alt < 0);
                        //Mostrar a mensagem na tela
                        Console.WriteLine("A área do retângulo é: " + exercicio.AreaRetangulo(bas, alt));
                        break;
                    case 5:
                        double totalEleitores;
                        double validos;
                        double nulos;
                        double brancos;
                        //Total de Eleitores
                        do
                        {
                            Console.WriteLine("Informe o total de eleitores");
                            totalEleitores = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalEleitores) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(totalEleitores) == false);
                        //Votos Brancos
                        do
                        {
                            Console.WriteLine("Informe o total de votos brancos");
                            brancos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(brancos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(brancos) == false);
                        //Votos Validos
                        do
                        {
                            Console.WriteLine("Informe o total de votos válidos");
                            validos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(validos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(validos) == false);
                        //Total de nulos
                        do
                        {
                            Console.WriteLine("Informe o total de votos nulos");
                            nulos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(nulos) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(nulos) == false);

                        //Fazer o cálculo
                        if(brancos + validos + nulos == totalEleitores)
                        {
                            Console.WriteLine("\nHá " + exercicio.PorcentagemVotos(brancos, totalEleitores) + "% de votos brancos" 
                                            + "\nHá " + exercicio.PorcentagemVotos(nulos, totalEleitores)   + "% de votos nulos"
                                            + "\nHá " + exercicio.PorcentagemVotos(validos, totalEleitores) + "% de votos validos");
                        }
                        else
                        {
                            Console.WriteLine("O total de eleitores é diferente da soma de brancos, validos e nulos.");
                        }

                        break;
                    case 6:
                        double salario;
                        double reajuste;
                        do
                        {
                            Console.WriteLine("Informe o Salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(salario) == false)
                            {
                                Console.WriteLine("Informe um salário positivo!");
                            }//fim da validação
                        } while (exercicio.Validar(salario) == false);

                        do
                        {
                            Console.WriteLine("Informe o percentual de reajuste: ");
                            reajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(reajuste) == false)
                            {
                                Console.WriteLine("Informe um reajuste positivo!");
                            }//fim da validação
                        } while(exercicio.Validar(reajuste) == false);

                        Console.WriteLine("O novo salário é: " + exercicio.AjusteSalario(salario, reajuste));
                        break;
                    case 7:
                        double custInicial = 0;
                        double imp = 0;
                        double dist = 0;
                        do
                        {
                            Console.WriteLine("Informe o custo inicial: ");
                            custInicial = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(custInicial) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(custInicial) == false);

                        do
                        {
                            Console.WriteLine("Informe o percentual de impostos: ");
                            imp = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(imp) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(imp) == false);

                        do
                        {
                            Console.WriteLine("Informe o percentual do distribuidor: ");
                            dist = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(dist) == false)
                            {
                                Console.WriteLine("Informe um valor positivo!");
                            }
                        } while (exercicio.Validar(dist) == false);

                        //Mostrar
                        Console.WriteLine("O Custo final é: R$ " +
                            (exercicio.CustoFinal(imp, custInicial) +
                            exercicio.CustoFinal(dist, custInicial) +
                            custInicial));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);//Fim do While
        }//fim do método



    }//fim da classe
}//fim do projeto
