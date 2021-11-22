using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDiscos
{
    class Proceso
    {
        public string nombre;
        public int llegada, cpu, prioridad, tiempo, tiempor, tiempoe;
          
        public Proceso(string n, int ll, int cpu, int prio,int t)
        {
            nombre = n;
            llegada = ll;
            this.cpu = cpu;
            prioridad = prio;
            tiempo = t;
        }
        public Proceso() 
        { 
        
        }
    }
}
