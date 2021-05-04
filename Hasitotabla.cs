using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ZH2_IQGAMA
{
    class HasitoTabla<A, B, T> where T : ITagolhato, IComparable
    {


        public delegate void TorlesHandler(T elem);
        public event TorlesHandler TorlesTortent;

        class HasitoElem
        {
            public A a;
            public B b;
            public T tartalom;
        }

        public int[,] matrix = new int[26, 26];

        protected int m;

        protected HasitoTabla(int m)
        {
            this.m = m;
        }


        public void MatrixBeszuras(T elem)
        {
            //matrix[elem.A, elem.B];

        }

        public void Torles(T elem)
        {

            TorlesTortent?.Invoke(elem);
        }

        public int[,] Statisztika()
        {
            int[,] stat = new int[26, 26];

            return stat;
        }
    }
}
