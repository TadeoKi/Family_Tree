using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class NombreLargoContent
    {
       private Node node;

        public NombreLargoContent(Node node)
        {
            this.node = node;
        }  

        public Persona GetNombreLargo()
        {
            NombreLargoContentVisitor visitor = new NombreLargoContentVisitor();
            node.Accept(visitor);
            return visitor.Persona; 
        }
    }   
}
