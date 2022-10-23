using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoCategoria
    {
        public NodoCategoria puntero { get; set; }
        public string data { get; set; }
        public int index { get; set; }
        public NodoCategoria() => puntero = null;

        public NodoCategoria(string data, NodoCategoria puntero = null)
        {
            this.data = data;
            this.puntero = puntero;
        }
    }
    public class ListaEnlazadaCategorias : IBucles<string>
    {
        private NodoCategoria inicio; //nodo creado con el propósito de identificar cualquier nodo como el principal
        public bool Empty => inicio == null;
        public void InsertToEnd(string data)
        {
            NodoCategoria nodo = new NodoCategoria(); //creación del nodo
            nodo.data = data; //asignación del dato

            if (inicio is null) inicio = nodo; //se asigna el nodo como inicial si no tiene datos la lista
            else
            {
                NodoCategoria nodoTemporal = inicio; //creación del nodo temporal
                while (nodoTemporal.puntero != null) //while que recorre todos los elementos hasta el último
                {
                    nodoTemporal = nodoTemporal.puntero; //se asigna el nodo temporal a su puntero para seguir recorriendo
                }

                nodoTemporal.puntero = nodo; //se asgina el puntero del último elemento al nodo que insertamos
            }
            IndexAssignation();
        }
        public void InsertToFirst(string data)
        {
            NodoCategoria nodo = new NodoCategoria();
            nodo.data = data;

            if (inicio is null) inicio = nodo;
            else
            {
                nodo.puntero = inicio.puntero;
                inicio.puntero = nodo;
            }
            IndexAssignation();
        }
        public void InsertTo(string data, int index)
        {
            NodoCategoria nodo = new NodoCategoria();
            nodo.data = data;
            if (inicio is null) nodo = inicio;
            else if (index == 0) InsertToFirst(data);
            else if (index > 0 && index < Quantity())
            {
                nodo.puntero = SearchNodeOfIndex(index);
                SearchNodeOfIndex(index - 1).puntero = nodo;
            }
            else throw new IndexOutOfRangeException();
            IndexAssignation();
        }
        public string ShowAllList()
        {
            NodoCategoria nodoTemporal = new NodoCategoria();
            nodoTemporal = inicio;
            string cadena = "";

            if (inicio is null) return "No hay elementos en la lista";

            while (nodoTemporal != null)
            {
                cadena += $"{nodoTemporal.data}\n";
                nodoTemporal = nodoTemporal.puntero;
            }
            return cadena;
        }
        public void For_Each(Action<string> funcion)
        {
            NodoCategoria nodoTemporal = new NodoCategoria();
            nodoTemporal = inicio;

            if (inicio is null) return;

            while (nodoTemporal != null)
            {
                funcion(nodoTemporal.data);
                nodoTemporal = nodoTemporal.puntero;
            }
        }
        public int Quantity()
        {
            int count = 0;
            NodoCategoria nodoTemporal = inicio;

            while (nodoTemporal != null)
            {
                count++;
                nodoTemporal = nodoTemporal.puntero;
            }

            return count;
        }
        private void IndexAssignation()
        {
            int count = -1;
            NodoCategoria nodoTemporal = inicio;

            while (nodoTemporal != null)
            {
                count++;
                nodoTemporal.index = count;
                nodoTemporal = nodoTemporal.puntero;
            }
        }
        public object SearchDataOfIndex(int index)
        {
            NodoCategoria nodoTemporal = inicio;
            while (nodoTemporal != null)
            {
                if (nodoTemporal.index == index) return nodoTemporal.data;
                nodoTemporal = nodoTemporal.puntero;
            }
            return null;
        }
        private NodoCategoria SearchNodeOfIndex(int index)
        {
            NodoCategoria nodoTemporal = inicio;
            while (nodoTemporal != null)
            {
                if (nodoTemporal.index == index) return nodoTemporal;
                nodoTemporal = nodoTemporal.puntero;
            }
            return null;
        }
        public bool ExistData(string data)
        {
            NodoCategoria nodoTemporal = inicio;
            while (nodoTemporal != null)
            {
                if (nodoTemporal.data.Equals(data)) return true;
                nodoTemporal = nodoTemporal.puntero;
            }
            return false;
        }

        public void ShellSort()
        {
            int lenght = Quantity();
            int brecha = lenght / 2;

            while (brecha > 0)
            {
                for (int i = brecha; i < lenght; i++)
                {
                    string bufer = SearchNodeOfIndex(i).data;
                    int saveIndex = i;

                    while (saveIndex >= brecha && SearchNodeOfIndex(saveIndex - brecha).data.CompareTo(bufer) == 1)
                    {
                        SearchNodeOfIndex(saveIndex).data = SearchNodeOfIndex(saveIndex - brecha).data;
                        saveIndex -= brecha;
                    }

                    SearchNodeOfIndex(saveIndex).data = bufer;
                }
                brecha /= 2;
            }
        }

        public void DeleteOfData(string data)
        {
            NodoCategoria temporal = inicio;
            NodoCategoria anterior = null;

            while (temporal != null)
            {
                if (temporal.data == data)
                {
                    if (temporal == inicio)
                    {
                        inicio = temporal.puntero;
                        return;
                    }
                    else
                    {
                        anterior.puntero = temporal.puntero;
                        return;
                    }
                }

                anterior = temporal;
                temporal = temporal.puntero;
            }
        }

        public void ShowFirstData()
        {
            Console.WriteLine(inicio.data);
        }
    }
}
