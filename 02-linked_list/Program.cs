/*
Una linked list, o lista ligada en español, es una estructura de datos dinámica utilizada en programación para almacenar una secuencia 
de elementos. Una linked list consiste en una serie de nodos, cada uno de los cuales contiene un valor y una referencia al siguiente 
nodo en la lista.

A diferencia de los arrays, en los que los elementos se almacenan en posiciones de memoria contiguas, en una linked list cada nodo 
puede estar ubicado en cualquier lugar de la memoria. Esto significa que los nodos de la lista no tienen que estar almacenados en 
posiciones de memoria contiguas, lo que hace que la inserción y eliminación de elementos sea más eficiente en algunos casos.
*/

namespace LinkedList
{
    class Program
    {
        public static void Main ()
        {
            LinkedList lista = new LinkedList();

            lista.Add(2);
            lista.Add(4);
            lista.Add(16);
            lista.Add(3);
            lista.Add(8);
            lista.Add(43);

            lista.Transversa();
            Console.WriteLine(lista.PreviousNodo(16));

            lista.DeleteNodo(3);
            lista.Transversa();

            lista.InsertNodo(16, 61);
            lista.Transversa();

            lista.InsertNodo(5, 62);
            lista.Transversa();

            lista.InsertFirstNodo(63);
            lista.Transversa();

            Console.WriteLine(lista.SearchByIndex(4));

            // lista.Transversa();
            // lista.DeleteAll();
            // lista.Transversa();
            // lista.IsEmpty();

        }
    }
}