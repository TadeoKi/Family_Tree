using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class NombreLargoContentVisitor : Visitor
    {
        public Persona persona;

        public Persona Persona
        {
            get
            {
                return persona;
            }
        }


        public override void Visit(Persona persona)
        {
            if (this.persona.Nombre.Length < persona.Nombre.Length)
            {
                this.persona = persona;
            }
        }

        public override void Visit(Node node)
        {
            node.persona.Accept(this);
            foreach(Node nodo in node.Children)
            {
              nodo.Accept(this);
            }
            
        }

    }   
}
