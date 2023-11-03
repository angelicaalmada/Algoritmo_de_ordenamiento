using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_de_ordenamiento
{
    public class Ejercicios
    {
        public void ejercicioSeleccion()
        {
            int[] arreglo = new int[] { 19, 25, 99, 100, 55, 1, 468, 0, 250, 45, 23, 68, 5 };
            int menor = 0;
            int posicion = 0;
            int temporal = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                menor = arreglo[i];
                posicion = i;
                for(int x = i+1; x < arreglo.Length; x++)
                {
                    if (arreglo[x]< menor)
                    {
                        menor = arreglo[x];
                        posicion = x;
                    }
                }
                if(posicion != i)
                {
                    temporal = arreglo[i];
                    arreglo[i] = arreglo[posicion];
                    arreglo[posicion] = temporal;
                }
            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

        }

        public void ejercicioBurbuja()
        {
            int[] arreglo = new int[] { 19, 25, 99, 100, 55, 1, 468, 0, 250, 45, 23, 68, 5 };
            int temporal = 0;
            for(int i = 0; i< arreglo.Length; i++)
            {
                for(int x = i; x < arreglo.Length; x++)
                {
                    if (arreglo[i] > arreglo[x])
                    {
                        temporal = arreglo[i];
                        arreglo[i] = arreglo[x];
                        arreglo[x] = temporal;
                    }
                }

            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }


        public void ejercicioInsercion()
        {
            int[] arreglo = new int[] { 19, 25, 99, 100, 55, 1, 468, 0, 250, 45, 23, 68, 5 };
            int temporal = 0;
            int x = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                temporal = arreglo[i];
                x = i - 1;

                while(x >= 0 && arreglo[x] > temporal)
                {
                    arreglo[x + 1] = arreglo[x];
                    x--;
                }

                arreglo[x+1] = temporal;

            }
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

        }
    }
}
