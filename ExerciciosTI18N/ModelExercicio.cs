using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class ModelExercicio
    {
        public ModelExercicio()
        {

        }//fim do construtor

        //Exercício 01 - A média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }//fim do método média

        //Método de validação
        public Boolean ValidarNotas(double nota)
        {
            if((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fim do método

        //Exercício 2
        public int Comparar(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//fim do comparar

        //Exercício 03 - Mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim do antecessor

        public double AreaRetangulo(double bas, double alt)
        {
            return bas * alt;
        }//fim do método

        public double PorcentagemVotos(double votos, double total)
        {
            return (votos * 100) / total;
        }//fim do método de porcentagem

        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//fim da validação

        public double AjusteSalario(double salario, double reajuste)
        {
            return salario * (reajuste / 100) + salario;
        }//fim do método

        public double CustoFinal(double porc, double custInicial)
        {
            return custInicial * (porc / 100);
        }//fim do método



    }//fim da classe
}//fim do projeto
