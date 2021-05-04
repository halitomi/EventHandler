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

        public LancoltLista<T>[,] matrix = new LancoltLista<T>[26, 26];

        protected int m;

        protected HasitoTabla(int m)
        {
            this.m = m;
        }


        public void MatrixBeszuras(T elem)
        {
            //Helyezze el az elemet az A betűnek megfelelő sor és B betűnek megfelelő oszlop metszéspontjában 
            //lévő listába
            //mi a száma az A betunek, ami megadja hogy 26-os tombben hova kerül 
            //     m.B megadja hogy 26-os tombben hova kerül 
            //Szemely beszurandoListaElemSZemely = new Szemely(elem.A, elem.B);
            //matrix[2, 3] = (beszurandoListaElemSZemely as Szemely;

            matrix[elem.A, elem.B].Beszuras(elem);

            //Lista rendezése ??TODO: 5. második része
            // matrix[elem.A, elem.B].
            //Lista összehasonlitása??
        }

        public void Torles(T elem)
        {
            //A paraméterben átadott elemmel egyező tulajdonságú elemeket töröljük a hasítótáblából. Sz
            // bool Equals() metódus igazat ad rájuk. Ezt az 
            //osztályon tetszőlegesen valósítsa meg(pl: a vezetéknév, a keresztnév és az életkor egyezősége
            //(int)’A’ megadja az angol nagy A betű UTF16 kódjátesetén egyezik meg a két elem, a maradék x db tulajdonságnak nem kell egyeznie). A
            //GetHashCode() felüldefiniálása nem kötelező. (6 pont)
            //  TorlesTortent?.Invoke(elem);

            //Ha egyezik, töröljük a listábol
            //Lista? matrix

            //mennyunk végig a 
           // matrix[elem.A, elem.B].Torles(elem);
            if (elem is Szemely)
            {
               // if(elem.Equals())
            }
        }

        public int[,] Statisztika()
        {
            int[,] stat = new int[26, 26];
            //végig menni az összes cellán
            //végig menni az összes ellemen
            //megszámolni
            var sor = matrix.GetLength(0);
            var oszlop = matrix.GetLength(1);
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    //Mit cisnálunk
                    //int egy =matrix
                    // stat[i, j] = matrix[i, j];
                }
            }//nums.Count(); //12
             // szemely mátrixot Convert az inté
            int rowsOrHeight = matrix.GetLength(0);
            int colsOrWidth = matrix.GetLength(1);
            //  stat[0,0] = rowsOrHeight,
            return stat;
        }
    }
}
