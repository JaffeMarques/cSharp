using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrescimentoPopulacional
{
    static void Main(string[] args)
    {
        int i = 0;
        int vitalidade = Convert.ToInt32(Console.ReadLine());
        List<string> dados = new List<string>();

        while (i < vitalidade)
        {
            string tempo = Console.ReadLine();
            Console.WriteLine(aux(tempo));
            i++;
        }
    }
    static string aux(string resposta)
    {
        string[] temp = resposta.Split(' ');
        int pa = Convert.ToInt32(temp[0]);
        int pb = Convert.ToInt32(temp[1]);

        double g1 = double.Parse(temp[2], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);
        double g2 = double.Parse(temp[3], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture);

        return calcPop(pa, pb, g1, g2);
    }
    static string calcPop(int pa, int pb, double g1, double g2)
    {
        int  anos  = 0;
        long paaux = pa;
        long pbaux = pb;

        while (paaux <= pbaux)
        {
            paaux += Convert.ToInt64(Math.Truncate((paaux * g1) / 100));
            pbaux += Convert.ToInt64(Math.Truncate((pbaux * g2) / 100));
            anos++;

            if (anos > 100)
            {
                return "Mais de 1 seculo.";
            }

        }
        if (anos > 0)
        {
            return Convert.ToString(anos + " anos.");
        }
        else
        {
            return "";
        }
    }
}