using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conselheiro_Amoroso
{
    class Node<T>
    {
        public T info;
        public int valor;
        public Node<T> esq, dir;

        public Node(T info, int valor)
        {
            this.info = info;
            this.valor = valor;
            esq = null;
            dir = null;
        }
    }
}
