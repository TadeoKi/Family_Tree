using System;
using Library;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, 80, "edgar");
            Node n2 = new Node(2 , 60, "magdalena" );
            Node n3 = new Node(3, 55, "robert");
            Node n4 = new Node(4, 40, "jorge");
            Node n5 = new Node(5, 35, "mariana");
            Node n6 = new Node(6, 30, "nico");
            Node n7 = new Node(7, 35, "estefi");

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

            SumaEdadesContent SumaEdad = new SumaEdadesContent(n1);
            Console.WriteLine(SumaEdad.GetSuma());

            NombreLargoContent NomLarg = new NombreLargoContent(n1);
            Console.WriteLine(NomLarg.GetNombreLargo());
        }
    }
}
