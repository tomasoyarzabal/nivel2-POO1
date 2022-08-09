using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        // atributos o miembros:
        private int edad;
        private float sueldo;
        private string nombre;

        //constructor de nombre.
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
        //geter y seter son como seudometodos.
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }
        //metodos:
        public string Saludar()
        {
            return "hola soy " + nombre;
        }
        // sobrecarga de metodos. ej.
        public string Saludar(string personaje)
        {
            return " hola " + personaje + " soy " + nombre;

        }

    }
}
