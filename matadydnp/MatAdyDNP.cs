using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizadyacencia {
    internal class MatAdyDNP {
        private int[,] matady;
        public int Nodos {  get; }
        public MatAdyDNP(int nodos) {
            Nodos = nodos;
            matady = new int[nodos, nodos];
        }
        public void Mostrar() {
            for (int f = 0; f < matady.GetLength(0); f++) {
                for (int c = 0; c < matady.GetLength(1); c++) {
                    Console.Write(matady[f, c] + ", ");
                }
                Console.WriteLine();
            }
        }

        public void AgregaArista(int origen, int destino) {
            matady[origen, destino] = 1;
        }
    }
}
