using System; 

class URI {

    static void Main(string[] args) { 
        int cont = 0;
        int vitalidade = -1;
        while (vitalidade != 0)
        {
            vitalidade = Convert.ToInt32(Console.ReadLine());
            if(vitalidade != 0)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int i = 0;
                for(i = 0; i < entrada.Length; i++)
                {
                    if (entrada[i] != null)
                    {
                        bool teste = false;
                        for (int j = i + 1; j < entrada.Length; j++)
                        {
                            if (entrada[j] != null && entrada[i].Equals(entrada[j]))
                            {
                                entrada[i]  = null;
                                entrada[j]  = null;
                                teste = true;
                                break;
                            }
                        }
                        if (!teste){
                            cont++;
                            break;
                        }
                    }
                }
                Console.WriteLine(entrada[i]);
            }
        }
    }

}