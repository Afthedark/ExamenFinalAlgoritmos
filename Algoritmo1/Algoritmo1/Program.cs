using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo DesembRey = new Nodo() { Nombre = "DesembRey" , Hombre="D"};
            Nodo Volantis = new Nodo() { Nombre = "Volantis", Hombre = "V" };
            Nodo Braavos = new Nodo() { Nombre = "Braavos", Hombre = "B" };
            Nodo Qarth = new Nodo() { Nombre = "Qarth", Hombre = "Q" };
            Nodo Asshai = new Nodo() { Nombre = "Asshai", Hombre = "A" };
            Nodo Meereen = new Nodo() { Nombre = "Meereen", Hombre = "M" };
            Nodo Pentos = new Nodo() { Nombre = "Pentos", Hombre = "P" };


            DesembRey.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 1600 , Hombre=60});
            DesembRey.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1200 , Hombre=70});
            DesembRey.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 1900, Hombre = 90 });
            DesembRey.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 950, Hombre = 40});
            DesembRey.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 900, Hombre = 30});
            DesembRey.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 300, Hombre = 10 });

            Volantis.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 1600, Hombre = 60 });
            Volantis.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1000, Hombre = 20 });
            Volantis.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 1050, Hombre = 30 });
            Volantis.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 800, Hombre = 30});
            Volantis.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 1600, Hombre = 10});
            Volantis.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 1100, Hombre = 80 });

            Braavos.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 1200, Hombre = 70 });
            Braavos.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 1000, Hombre = 20 });
            Braavos.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 1900, Hombre = 110 });
            Braavos.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 1000, Hombre = 120});
            Braavos.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 1300, Hombre = 40 });
            Braavos.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 1800, Hombre = 20});

            Qarth.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 1900, Hombre = 90 });
            Qarth.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 1050, Hombre = 30 });
            Qarth.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1900, Hombre = 110 });
            Qarth.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 500, Hombre = 70});
            Qarth.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 700, Hombre = 60 });
            Qarth.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 1200, Hombre = 30});

            Asshai.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 300, Hombre = 50 });
            Asshai.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 500, Hombre = 70 });
            Asshai.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 1100, Hombre = 20});
            Asshai.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1000, Hombre = 120});
            Asshai.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 1050, Hombre = 10});
            Asshai.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 1100, Hombre = 80 });

            Meereen.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 700, Hombre = 60 });
            Meereen.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 300, Hombre = 50});
            Meereen.Caminos.Add(new Camino() { Nodo = Pentos, Distancia = 200, Hombre = 150});
            Meereen.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 900, Hombre = 30});
            Meereen.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 1600, Hombre = 10 });
            Meereen.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1800, Hombre = 20});

            Pentos.Caminos.Add(new Camino() { Nodo = Meereen, Distancia = 200, Hombre = 150 });
            Pentos.Caminos.Add(new Camino() { Nodo = Qarth, Distancia = 1200, Hombre = 30 });
            Pentos.Caminos.Add(new Camino() { Nodo = Asshai, Distancia = 1100, Hombre = 20});
            Pentos.Caminos.Add(new Camino() { Nodo = Volantis, Distancia = 800, Hombre = 30});
            Pentos.Caminos.Add(new Camino() { Nodo = DesembRey, Distancia = 950, Hombre = 40});
            Pentos.Caminos.Add(new Camino() { Nodo = Braavos, Distancia = 1300, Hombre = 40 });

            List<Nodo> graph = new List<Nodo>() { DesembRey, Volantis, Braavos, Qarth, Asshai, Meereen, Pentos };

            AlgoritmoTSP tsp = new AlgoritmoTSP(graph, 103, DesembRey);
            AlgoritmoTSP tsp1 = new AlgoritmoTSP(graph, 103, Volantis);
            AlgoritmoTSP tsp2 = new AlgoritmoTSP(graph, 103, Braavos);
            AlgoritmoTSP tsp3 = new AlgoritmoTSP(graph, 103, Qarth);
            AlgoritmoTSP tsp4 = new AlgoritmoTSP(graph, 103, Asshai);
            AlgoritmoTSP tsp5 = new AlgoritmoTSP(graph, 103, Meereen);
            AlgoritmoTSP tsp6 = new AlgoritmoTSP(graph, 103, Pentos);


            tsp.Caminar();
            tsp1.Caminar();
            tsp2.Caminar();
            tsp3.Caminar();
            tsp4.Caminar();
            tsp5.Caminar();
            tsp6.Caminar();
            Console.WriteLine(tsp.GetTodasRutas + "" + tsp1.GetTodasRutas + "" + tsp2.GetTodasRutas + "" + tsp3.GetTodasRutas + "" + tsp4.GetTodasRutas + "" + tsp5.GetTodasRutas + "" + tsp6.GetTodasRutas);
              Console.ReadLine();
        }

        public static string Hombres { get; set; }
    }
}
