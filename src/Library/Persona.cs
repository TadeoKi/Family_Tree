using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        private int edad;
        private string nombre;

        public int Edad {
            get
            {
                return this.edad;
            }
        }

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public void Accept(Visitor visitor)
        {
             visitor.Visit(this);
        }
        
    }
}
