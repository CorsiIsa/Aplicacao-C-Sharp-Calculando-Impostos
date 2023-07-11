using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calaculando_o_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            double CF;

            double IMPO;
            double PD;
            double PC;

            Console.Clear(); //Limapando a tela
            Console.WriteLine("Digite o Custo de Fabricação: "); //Interface 1
            Console.SetCursorPosition(29, 0); //Posição 1
            CF = double.Parse(Console.ReadLine()); //Entrada 1

            //Operações
            IMPO = (CF * 0.42);
            PD = (CF * 0.15);
            PC = (CF + IMPO + PD);

            //Saídas
            Console.WriteLine("Imposto: " + IMPO);
            Console.WriteLine("Porcentagem do Distribuidor: " + PD);
            Console.WriteLine("Preço do Consumidor: " + PC);
            Console.ReadLine();
        }
    }
}
