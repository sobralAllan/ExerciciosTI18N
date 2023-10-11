using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a control com a program
            ControlFormulario control = new ControlFormulario();//Instanciando
            control.Operacao();

            //Manter aberto
            Console.ReadLine();
        }//fim do método main
    }//fim da classe program
}//fim do projeto
