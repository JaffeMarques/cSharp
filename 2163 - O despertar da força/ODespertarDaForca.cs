using System;
using System.Collections;
using System.IO;
using System.Text;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        int n = Convert.ToInt32(entrada.Split(' ')[0]); // linhas
        int m = Convert.ToInt32(entrada.Split(' ')[1]); // colunas

        ArrayList matriz = new ArrayList();
        int i = 0;
        for (i = 0; i < n; i++)
        {
            if (false)
            {
                continue;
            }
            else
            {
                entrada = Console.ReadLine();
            }
            if (entrada.Split(' ').Length == m)
            {
                matriz.Add(entrada);
            }
        }

        bool resultado = false;
        i              = 0;
        int i2         = 0;
        int j          = 0;
        int indice_n   = 0;
        int indice_m   = 0;

        for (i = 1; i < matriz.Count; i++)
        {
            string[] linha = matriz[i].ToString().Split(' ');
            for (i2 = 1; i2 < linha.Length; i2++)
            {
                if (linha[i2].Equals("42"))
                {
                    if ((linha[i2 - 1].Equals("7")) && (i2 != linha.Length - 1 && linha[i2 + 1].Equals("7")) &&
                        (matriz[i - 1].ToString().Split(' ')[i2].Equals("7")) &&
                        (matriz[i - 1].ToString().Split(' ')[i2 - 1].Equals("7")) &&
                        (i2 != linha.Length - 1 && matriz[i - 1].ToString().Split(' ')[i2 + 1].Equals("7")) &&
                        (i != matriz.Count - 1 && matriz[i + 1].ToString().Split(' ')[i2].Equals("7")) &&
                        (i != matriz.Count - 1 && matriz[i + 1].ToString().Split(' ')[i2 - 1].Equals("7")) &&
                        (i != matriz.Count - 1 && i2 != linha.Length - 1 && matriz[i + 1].ToString().Split(' ')[i2 + 1].Equals("7")))
                    {
                        if (j == 0)
                        {
                            resultado = true;
                            j = 1;
                            indice_n = i;
                            indice_m = i2;
                        }
                        else
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            if (j == 1 && !resultado)
            {
                break;
            }
        }
        if (resultado)
        {
            Console.WriteLine(indice_n + 1 + " " + (indice_m + 1));
        }
        else
        {
            Console.WriteLine("0 0");
        }
    }

}