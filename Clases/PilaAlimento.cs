using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PilaAlimento : IBucles<Alimento>
    {
        //public delegate void AccionRecorrer(Alimento x);

        public NodoAlimento cima = null;
        public bool PilaVacia => cima == null;

        public void Apilar(Alimento data)
        {
            NodoAlimento nuevo = new NodoAlimento(data);
            if (PilaVacia) cima = nuevo;
            else
            {
                if (!ElementoExistente(data))
                {
                    nuevo.puntero = cima;
                    cima = nuevo;
                }
                else throw new AggregateException();
            }
        }
        public Alimento Desapilar()
        {
            NodoAlimento temporal = cima;
            if (!PilaVacia)
            {
                Alimento datoCima = cima.data;
                cima = temporal.puntero;
                return datoCima;
            }
            else return null;
        }
        public void EliminarElementoPila(Alimento data)
        {
            NodoAlimento actual = cima;
            PilaAlimento pilaTemporal = new PilaAlimento();

            if (!PilaVacia)
            {
                while (actual != null)
                {
                    pilaTemporal.Apilar(actual.data);
                    Desapilar();

                    if (actual.data == data)
                    {
                        pilaTemporal.Desapilar();
                        break;
                    }
                    actual = actual.puntero;
                }
                ApilarPila(pilaTemporal);
            }
        }
        public string Mostrar()
        {
            string retorno = "";
            NodoAlimento actual = cima;
            while (actual != null)
            {
                retorno += actual.data;
                actual = actual.puntero;
            }
            return retorno;
        }

        public void For_Each(Action<Alimento> funcion)
        {
            NodoAlimento actual = cima;
            while (actual != null)
            {
                funcion(actual.data);
                actual = actual.puntero;
            }
        }

        public string MostrarRevez()
        {
            PilaAlimento pila = new PilaAlimento();
            pila.ApilarPila(this);
            return pila.Mostrar();
        }
        public void ApilarPila(PilaAlimento pila)
        {
            NodoAlimento actual = pila.cima;
            while (actual != null)
            {
                Apilar(actual.data);
                actual = actual.puntero;
            }
        }

        /// <summary>
        /// Para hallar un elemento según la busqueda que se realice
        /// Devuelve null si no se encuentra
        /// </summary>
        /// <param name="index">1) nombre, 2) tipo</param>
        /// <param name="text"></param>
        /// <returns></returns>
        public Alimento BuscarElemento(int index, string text)
        {
            switch (index)
            {
                case 1:
                    if (!PilaVacia)
                    {
                        NodoAlimento actual = cima;
                        while (actual != null)
                        {
                            if (text.Equals(actual.data.Nombre)) return actual.data;
                            actual = actual.puntero;
                        }
                        return null;
                    } break; //Nombre

                case 2:
                    if (!PilaVacia)
                    {
                        NodoAlimento actual = cima;
                        while (actual != null)
                        {
                            if (text.Equals(actual.data.Tipo)) return actual.data;
                            actual = actual.puntero;
                        }
                        return null;
                    } break; //Tipo

                default: throw new ArgumentOutOfRangeException();
            }
            return null;
        }
        public bool ElementoExistente(Alimento data)
        {
            NodoAlimento actual = cima;
            while (actual != null)
            {
                if (data.Equals(actual.data)) return true;
                actual = actual.puntero;
            }
            return false;
        }

        public bool ElementoExistenteNombre(string nombre)
        {
            if (PilaVacia) return false;
            NodoAlimento actual = cima;
            while (actual != null)
            {
                if (nombre.Equals(actual.data.Nombre)) return true;
                actual = actual.puntero;
            }
            return false;
        }

        public Alimento BuscarElementoExistenteNombre(string nombre)
        {
            if (PilaVacia) return null;
            NodoAlimento actual = cima;
            while (actual != null)
            {
                if (nombre.Equals(actual.data.Nombre)) return actual.data;
                actual = actual.puntero;
            }
            return null;
        }
    }
}
