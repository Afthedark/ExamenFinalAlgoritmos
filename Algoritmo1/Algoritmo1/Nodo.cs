using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo1
{
    public class Nodo
    {
        public string Nombre { get; set; }

        public List<Camino> Hombres { get; set; }

        public List<Camino> Caminos { get; set; }

        public Nodo()
        {
            Caminos = new List<Camino>();
            Hombres = new List<Camino>();
        }

        public string Hombre { get; set; }
    }

    public struct Camino
    {
        public Nodo Nodo { get; set; }
        public int Distancia { get; set; }
        public int Hombre { get; set; }
    }

    public class Ruta
    {
        public List<Nodo> Nodos { get; set; }
        public int DistanciaTotal { get; set; }
        public int cantidadhombres { get; set; }

        public Ruta()
        {
            Nodos = new List<Nodo>();
            DistanciaTotal = 0;
            cantidadhombres = 0;
        }
    }
}
