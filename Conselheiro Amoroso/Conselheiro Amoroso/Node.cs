using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conselheiro_Amoroso
{
    class Node<T>
    {
        public T info;
        public Node<T> sim, nao;

        public Node(T info)
        {
            this.info = info;
            sim = null;
            nao = null;
        }
    }
}
