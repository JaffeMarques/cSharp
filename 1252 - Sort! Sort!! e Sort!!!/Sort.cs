using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort__Sort_e_sort
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            int interacoes = 1;
            while (interacoes != 0)
            {
                string nums = Console.ReadLine();
                int numN    = Convert.ToInt32(nums.Split(' ')[0]);
                int numM    = Convert.ToInt32(nums.Split(' ')[1]);
                interacoes  = numN;

                int[] vetorNum = new int[numN];
                int[] vetorMod = new int[numN];
                for (int i = 0; i < numN; i++)
                {
                    vetorNum[i] = Convert.ToInt32(Console.ReadLine());
                    vetorMod[i] = (vetorNum[i] % numM);

                }
                Console.WriteLine(nums);
                if (numN != 0)
                {
                    selectionSort(vetorNum, vetorMod);
                }

            }
        }
        static void selectionSort(int[] arr, int[] arrM)
        {
            int n = arr.Length;
            int temp, menor, tempM;
            for (int i = 0; i < n - 1; i++)
            {
                menor = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arrM[j] < arrM[menor])
                    {
                        menor = j;
                    }
                    else if (arrM[j] == arrM[menor])
                    {
                        if (arr[j] % 2 == 0 && arr[menor] % 2 == 0)
                        {
                            if (arr[j] < arr[menor])
                            {
                                menor = j;
                            }
                        }
                        else if (arr[j] % 2 != 0 && arr[menor] % 2 != 0)
                        {
                            if (arr[j] > arr[menor])
                            {
                                menor = j;
                            }
                        }
                        else if (arr[j] % 2 != 0 && arr[menor] % 2 == 0)
                        {
                            menor = j;
                        }
                        else if (arr[j] % 2 == 0 && arr[menor] % 2 != 0)
                        {
                            menor = menor;
                        }
                    }
                }
                temp        = arr[menor];
                tempM       = arrM[menor];
                arr[menor]  = arr[i];
                arrM[menor] = arrM[i];
                arr[i]      = temp;
                arrM[i]     = tempM;
            }

            for (int t = 0; t < n; t++)
            {
                int ksd = arr[t];
                Console.WriteLine(arr[t]);
            }
        }
    }
}