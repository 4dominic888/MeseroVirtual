namespace Clases
{
    public class NodoAlimento
    {
        public NodoAlimento puntero { get; set; }
        public Alimento data { get; set; }
        public int index { get; set; }
        public NodoAlimento() => puntero = null;

        public NodoAlimento(Alimento data, NodoAlimento puntero = null)
        {
            this.data = data;
            this.puntero = puntero;
        }
    }
}