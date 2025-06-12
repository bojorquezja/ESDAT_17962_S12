using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizadyacencia {
    internal class MatAdyNDP {
        private int[,] matady;
        public int Nodos {  get; }
        public MatAdyNDP(int nodos) {
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

        public void AgregaArista(int origen, int destino, int peso) {
            matady[origen, destino] = peso;
            matady[destino, origen] = peso;
        }

        public void DFS(int origen) {
            bool[] visitados = new bool[Nodos];
            DFSUtil(origen, visitados);
        }
        private void DFSUtil(int origen, bool[] visitados) {
            visitados[origen] = true;
            Console.Write(origen + ",");
            for (int c = 0; c < matady.GetLength(1); c++) {
                if (matady[origen, c] > 0) {
                    if (!visitados[origen]) {
                        DFSUtil(c, visitados);
                    }
                }
            }
        }
    }
}
