// See https://aka.ms/new-console-template for more information
using matrizadyacencia;

Console.WriteLine("Ingrese cantidad de nodos:");
int nodos = Convert.ToInt32(Console.ReadLine());
MatAdyNDP mat = new MatAdyNDP(nodos);
string[] resp = { "0", "0", "0" };

mat.AgregaArista(0, 1, 2);
mat.AgregaArista(0, 2, 1);
mat.AgregaArista(0, 3, 5);
mat.AgregaArista(3, 1, 4);
/*
while (resp.Length == 3) {
    Console.WriteLine($"Ingrese Origen, Destino y Peso separados por comas (o cero para terminar):");
    resp = Console.ReadLine().Split(",");
    //0,1,2
    if (resp.Length == 3) {
        mat.AgregaArista(
            Convert.ToInt32(resp[0]),
            Convert.ToInt32(resp[1]),
            Convert.ToInt32(resp[2])
            );
    }
}
*/
Console.WriteLine("ingrese peso maximo");
int peso = Convert.ToInt32(Console.ReadLine());
mat.Mostrar();
mat.DFS(0);
Console.WriteLine();
mat.DFSPesoMax(0, peso);
