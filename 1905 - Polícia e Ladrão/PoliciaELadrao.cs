using System; 
using System.Collections;
class URI {

    private static bool stop = false;
        private static ArrayList mapLeft   = new ArrayList();
        private static ArrayList mapRight  = new ArrayList();
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                ArrayList matriz = new ArrayList();
                for (int x = 0; x < 5; x++)
                {
                    string entrada = Console.ReadLine();
                    if (!entrada.Trim().Equals(""))
                    {
                        matriz.Add(entrada);
                    }
                    else
                        x--;
                }
                stop = false;
                mapLeft.Clear();
                mapRight.Clear();
                if (!matriz[0].ToString().Split(' ')[0].Equals("1"))
                    right(matriz, 0, 0);
                if (stop)
                    Console.WriteLine("COPS");
                else
                    Console.WriteLine("ROBBERS");
            }

        }
        public static void right(ArrayList matriz, int direito, int baixo)
        {
            if (stop)
                return;

            if (direito > 4 || baixo < 0 || baixo > 4)
                return;

            if (mapRight.Contains(direito.ToString() + baixo.ToString()))
                return;

            mapRight.Add(direito.ToString() + baixo.ToString());

            string[] matrizAux = matriz[baixo].ToString().Split(' ');
            if (baixo == 4 && direito == 4)
            {
                if (matrizAux[direito].Equals("1"))
                    return;
                stop = true;
                return;
            }

            if (matrizAux[direito].Equals("1")){
                return;
            }

            right(matriz, direito + 1, baixo);
            left(matriz, direito - 1, baixo);
            right(matriz, direito, baixo + 1);
            right(matriz, direito, baixo - 1);
        }

        public static void left(ArrayList matriz, int esquerdo, int baixo)
        {
            if (stop){
                return;
            }
            if (esquerdo < 0 || baixo > 4 || baixo < 0){
                return;
            }
            if (mapLeft.Contains(esquerdo.ToString() + baixo.ToString())){
                return;
            }
            mapLeft.Add(esquerdo.ToString() + baixo.ToString());
            string[] matrizAux = matriz[baixo].ToString().Split(' ');
            if (baixo == 4 && esquerdo == 4)
            {
                if (matrizAux[esquerdo].Equals("1")){
                    return;
                }
                stop = true;
                return;
            }

            if (matrizAux[esquerdo].Equals("1")){
                return;
            }
            left(matriz, esquerdo - 1, baixo);
            right(matriz, esquerdo + 1, baixo);
            left(matriz, esquerdo, baixo + 1);
            left(matriz, esquerdo, baixo - 1);
        }

}