using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ZH2_IQGAMA
{
    public class ListaElem<T>
    {
        public T Tartalom { get; set; }
        public ListaElem<T> Kovetkezo { get; set; }
    }

     class LancoltLista<T> where T : ITagolhato, IComparable
    {

        public T Tartalom { get; set; }
        public ListaElem<T> Kovetkezo { get; set; }




        private ListaElem<T> fej;
        public ListaElem<T> ElsoElem
        {
            get
            {
                return fej;
            }
        }


        public void Beszuras(T tartalom)
        {
            int hely = 0;
            ListaElem<T> uj = new ListaElem<T>();
            uj.Tartalom = tartalom;
            ListaElem<T> p = fej;
            ListaElem<T> e = null;

            while (p != null && p.Tartalom.A < tartalom.A)
            {
                e = p;
                p = p.Kovetkezo;
                hely++;
            }
            if (e == null)
            {
                uj.Kovetkezo = fej;
                fej = uj;
            }
            else
            {
                uj.Kovetkezo = p;
                e.Kovetkezo = uj;
            }
        }
        public void Torles(int kulcs)
        {
            ListaElem<T> p = fej;
            ListaElem<T> e = null;

            while (p != null)
            {
                if (p.Tartalom.A == kulcs)
                {
                    if (e != null)
                    {
                        fej = p.Kovetkezo;
                    }
                    else
                    {
                        e.Kovetkezo = p.Kovetkezo;
                    }
                }
                else
                {
                    e = p;
                    p = p.Kovetkezo;
                }
            }
        }
    }
    
}

