using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conselheiro_Amoroso
{
    class Node<T>
    {
        public T info;
        public Node<T> esq, dir;

        public Node(T info)
        {
            this.info = info;
            esq = null;
            dir = null;
        }
    }
}
