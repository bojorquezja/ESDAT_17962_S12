// See https://aka.ms/new-console-template for more information
using matrizadyacencia;

Console.WriteLine("Ingrese cantidad de nodos:");
int nodos = Convert.ToInt32(Console.ReadLine());
MatAdyDNP mat = new MatAdyDNP(nodos);
string[] resp = { "0", "0", "0" };
while (resp.Length == 3) {
    Console.WriteLine($"Ingrese Origen, Destino y Peso separados por comas:");
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

mat.Mostrar();