using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
     class Botella
    {
        //ejemplo ejercicio.
        //capacidad maxima de 100.
        //capacidad actual inicia en 0.
        //metodo recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100.
        private int capacidad;
        private string color;
        private string material;
        private int CantidadActual;

        //Constructor:
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            CantidadActual = 0;


        }
        // sobre carga de constructor:
         public Botella() { }

        //propiedad:

        public int Capacidad
        {
            get { return capacidad; }
        
        }
        public int cantidadActual
        {
            get { return CantidadActual; }
        }


        //metodos.
        public float recargar()
        {
           if(CantidadActual > 0)
            {
                int dif = capacidad - CantidadActual;
                float monto = dif * 50 / capacidad;
                CantidadActual += dif;
                return monto;
            }
            CantidadActual = 100;
            return 50;
        }
        //sobrecarga de metodos.ej.
        public float recargar(int cantidad)
        {
            CantidadActual += cantidad;
            return cantidad * 50 / 100;

        }



    }
}
