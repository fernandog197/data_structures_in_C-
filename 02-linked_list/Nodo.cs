namespace LinkedList
{
    class CNodo
    {
        //Aqui colocamos el dato que guarda el nodo
        private int? data;

        //Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo? next = null;

        //Propiedades que usaremos
        public int Data { get; set; }
        internal CNodo? Next { get; set; }

        //Para su facil impresion
        public override string ToString()
        {
            return string.Format("[{0}]", Data);
        }
    }
}