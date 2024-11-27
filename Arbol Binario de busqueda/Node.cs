using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario_de_busqueda
{
    public class Node
    {
        public int Value;
        // Our node will have a left and right atributte
        public Node Left;
        public Node Right;

        //Node constructor whose input is value
        public Node(int value)
        {

            Value = value;
            Left = Right = null;
        }
    }
}
