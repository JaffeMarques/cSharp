using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class URI
{
    static void Main(string[] args)
    {

        string turing  = Console.ReadLine();
        string crib    = Console.ReadLine();

        int cont = 0;
        for (int i = 0; i < turing.Length; i++)
        {
            if (i + crib.Length <= turing.Length)
            {
                bool teste = true;
                for (int j = i, k = 0; k < crib.Length; j++, k++)
                {
                    if (turing[j].Equals(crib[k]))
                    {
                        teste = false;
                        break;
                    }
                }
                if (teste)
                {
                    cont++;
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(cont);
    }
}