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




    }//fim da classe
}//fim do projeto
