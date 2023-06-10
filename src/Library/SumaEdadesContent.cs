using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class SumaEdadesContent
    {
        private Node node;

        public SumaEdadesContent(Node node)
        {
            this.node = node;
        }  
        

        public int GetSuma()
        {
            SumaEdadesContentVisitor visitor = new SumaEdadesContentVisitor();
            node.Accept(visitor);
            return visitor.Sumadeedades; 
        }

    }   
}
