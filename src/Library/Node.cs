using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public Persona persona {
            get
            {
                return this.persona;
            }
        }

        public Node(int number, int edad, string nombre)
        {
            this.number = number;
            Persona persona = new Persona(edad, nombre);
            
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
             visitor.Visit(this);
        }
        
    }
}
