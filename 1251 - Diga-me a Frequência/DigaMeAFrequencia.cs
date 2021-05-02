using System;
using System.Collections;
class URI
{

    static void Main(string[] args)
    {
        string line;
        int vitalidade = 0;
        while ((line = System.Console.ReadLine()) != null)
        {
            vitalidade++;
            if (vitalidade > 1)
            {
                Console.WriteLine("");
            }
            ArrayList letras     = new ArrayList();
            ArrayList quantidade = new ArrayList();
            for (int i = 0; i < line.Length; i++)
            {
                char letra = line[i];
                if (!letras.Contains(Convert.ToInt32(letra)))
                {
                    letras.Add(Convert.ToInt32(letra));
                    int cont = 0;
                    for (int i2 = 0; i2 < line.Length; i2++)
                    {
                        if (letra.Equals(line[i2]))
                        {
                            cont++;
                        }  
                    }
                    quantidade.Add(cont);
                }
            }
            while (quantidade.Count > 0)
            {
                int menor = 0;
                for (int i = 0; i < quantidade.Count; i++)
                {
                    if (Convert.ToInt32(quantidade[i]) < Convert.ToInt32(quantidade[menor]))
                    {
                        menor = i;
                    }
                    else if (
                    Convert.ToInt32(quantidade[i]) == Convert.ToInt32(quantidade[menor]) &&
                    Convert.ToInt32(letras[i]) > Convert.ToInt32(letras[menor])
                    )
                    {
                        menor = i;
                    }
                }
                Console.WriteLine(Convert.ToInt32(letras[menor]) + Convert.ToString(" ") + Convert.ToInt32(quantidade[menor]));
                quantidade.RemoveAt(menor);
                letras.RemoveAt(menor);
            }
        }
        
    }
}