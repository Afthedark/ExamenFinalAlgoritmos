using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo1
{
    public class AlgoritmoTSP
    {
        private List<Nodo> _graph { get; set; }
        private int _n = 0;
        private Nodo _origen { get; set; }
        private List<Ruta> _soluciones { get; set; }
        

        public AlgoritmoTSP(List<Nodo> graph, int n, Nodo origen)
        {
            _graph = graph;
            _n = n;
            _origen = origen;
        }

        public void Caminar()
        {
            _soluciones = new List<Ruta>();
            for (int i = 0; i < _n; i++)
            {
                _soluciones.Add(GenerarRuta());
            }
        }

        private Ruta GenerarRuta()
        {
            int total = 20000;
            int total1 = 1000;
            Ruta solucion = new Ruta();
            solucion.Nodos.Add(_origen);
            Nodo actual = _origen;
            for (int i = 0; i < _graph.Count - 1; i++)
            {
                Nodo siguiente = null;
                do
                {
                    siguiente = SiguienteNodo(actual);

                } while (solucion.Nodos.Contains(siguiente));
                solucion.Nodos.Add(siguiente);
                solucion.cantidadhombres += actual.Caminos.Where(h => h.Nodo.Hombres == siguiente.Hombres).First().Hombre;
                solucion.DistanciaTotal += actual.Caminos.Where(d => d.Nodo.Nombre == siguiente.Nombre).First().Distancia;
                actual = siguiente;

            }
            solucion.Nodos.Add(_origen);
            solucion.cantidadhombres += actual.Caminos.OrderBy(h => h.Nodo.Hombres == _origen.Hombres).First().Hombre;
            solucion.cantidadhombres = Math.Abs(solucion.cantidadhombres - total1);
            solucion.DistanciaTotal += actual.Caminos.Where(d => d.Nodo.Nombre == _origen.Nombre).First().Distancia;
            solucion.DistanciaTotal = solucion.DistanciaTotal - total;
            solucion.DistanciaTotal = Math.Abs(solucion.DistanciaTotal);
            return solucion;

        }

        private Nodo SiguienteNodo()
        {
            throw new NotImplementedException();
        }

        private Nodo SiguienteNodo(Nodo actual)
        {
            int siguienteNodo = new Random().Next(0, +_graph.Count - 1);
            return actual.Caminos[siguienteNodo].Nodo;
        }

        public string GetTodasRutas
        {

            get
            {
                string result = string.Empty;
                int cont = 1;
                foreach (var ruta in _soluciones)
                {
                    foreach (var nodo in ruta.Nodos)
                    {
                        result += nodo.Nombre + "->";

                    }
                  
                    result += " ORO RESTANTE = " + ruta.DistanciaTotal + "\n";
                    result += " SALDO SOLDADOS = " + ruta.cantidadhombres + "\n";
              
                }
                
                return result;
                Console.ReadLine();
            }
           
        }

    }
}
