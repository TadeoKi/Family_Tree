using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class SumaEdadesContentVisitor : Visitor
    {
        private int sumadeedades = 0;
        public int Sumadeedades
        {
            get
            {
                return sumadeedades;
            }
        }

        public override void Visit(Persona persona)
        {
            sumadeedades += persona.Edad;
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
