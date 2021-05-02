using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papagaio
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<string> ganhador = new List<string>();
            string vitalidade = "";
            while ((line = System.Console.ReadLine()) != null)
            {
                if (line == "esquerda")
                {
                    ganhador.Add("ingles");
                }
                else if (line == "direita")
                {
                    ganhador.Add("frances");
                }
                else if(line == "as duas")
                {
                    ganhador.Add("caiu");
                }
                else if(line == "nenhuma")
                {
                    ganhador.Add("portugues");
                }
            }
            ganhador.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

    }
}
