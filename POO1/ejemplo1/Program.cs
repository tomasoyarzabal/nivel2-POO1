using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
      class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("tomy");
            // p1.setEdad(22);
            //Console.WriteLine(p1.Saludar("mario"));
            // Console.WriteLine("la edad de la persona es: " + p1.getEdad());
            //b1.Capacidad = 200
            Botella b1 = new Botella("rojo" ,"plastico");
            Console.WriteLine("la capacidad de la botella es " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es de " + b1.cantidadActual);
            b1.recargar();
            Console.WriteLine("luego de de recargar la cantidad actual es " + b1.cantidadActual);
            b1.recargar(20);
            Console.WriteLine("luego de de recargar la cantidad actual es " + b1.cantidadActual);



            Console.ReadKey();
        }
    }     
         

}
