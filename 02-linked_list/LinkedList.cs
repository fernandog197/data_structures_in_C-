namespace LinkedList
{
    class LinkedList
    {
        //Ancla o encabezado de la lista: hace referencia al primer elemente de la lista. Puede o no contener datos.
        private CNodo anchor;

        //Variable de referencia: elemento con el que se esta trabajando actualmente.
        private CNodo actualNodo;

        //Variable de apoyo: variable de apoyo para algunas operaciones.
        private CNodo supportNodo;

        //Constructor
        public LinkedList()
        {
            //Instanciamos anchor
            this.anchor = new CNodo();

            //Como es una lista vacia, su siguiente nodo es null
            this.anchor.Next = null;
        }

        //El siguiente metodo recorrera la LinkedList de principio a fin, mostrando los valores de cada nodo.
        public void Transversa ()
        {
            //Asignamos anchor a nuestra variable actualNodo, que es donde comienza el recorrido.
            this.actualNodo = this.anchor;

            while(this.actualNodo.Next != null)
            {
                //Avanzamos la referencia de actualNodo al siguiente Nodo de la lista.
                this.actualNodo = this.actualNodo.Next;

                //Asignamos el valor del Nodo a una variable para poder mostrarlo
                int d = this.actualNodo.Data;

                Console.Write("{0}, ", d);
            }

            //Bajamos la linea
            Console.WriteLine();
        }

        //El siguiente metodo creara y asignara su correspondiente valor a un nuevo nodo de nuestra lista
        public void Add (int v)
        {
            //Emulando Transversa avanzamos a traves de la lista hasta encontrar el final
            this.actualNodo = this.anchor;

            while(this.actualNodo.Next != null)
            {
                this.actualNodo = this.actualNodo.Next;
            }

            //Una vez actualNodo esta asignado al ultimo Nodo de nuestra list, creamos una nueva instancia de CNodo, le asignamos el valor
            //pasado por parametro(v), conectamos con nuestro ultimo Nodo y asignamos null al siguiente.
            
            //Creamos el nuevo Nodo
            CNodo newNodo = new CNodo();

            //Le asignamos su valor
            newNodo.Data = v;

            //Conectamos con el que era el ultimo nodo de la lista:
            this.actualNodo.Next = newNodo;

            //Asignamos null a newNodo.Next, quedando este como ultimo elemento de la  lista
            newNodo.Next = null;
        }

        //El siguiente metodo vaciara la lista completamente
        public void DeleteAll ()
        {   
            //Emulando Transversa asignamos el anchor a actualNodo
            this.actualNodo = this.anchor;

            //Recorremos la lista eliminando las referencias de cada nodo con su siguiente
            while(this.actualNodo.Next != null)
            {
                //Utilizamos un auxiliar para guardar el valor del nodo actual
                this.supportNodo = actualNodo;

                //Asignamos a actualNodo el valor del nodo siguiente
                this.actualNodo = this.actualNodo.Next;

                //Eliminamos la referencia del nodo actual con su siguiente
                this.supportNodo.Next = null;
            }
        }

        //El siguiente metodo verifica si la LinkedLista esta vacia
        public bool IsEmpty ()
        {
            if(this.anchor.Next == null)
            {
                return true;
            }else {
                return false;
            }
        }

        //El siguiente metodo buscara, si es que existe, el primer nodo que contenga el valor buscado v.
        public CNodo SearchValue (int v)
        {
            //Antes de todo chequeamos si la Lista esta vacia.
            if(IsEmpty())
            {
                return null;
            }

            //Asignamos actualNodo y recorremos la Lista
            this.actualNodo = this.anchor;

            while(this.actualNodo.Next != null)
            {
                this.actualNodo = this.actualNodo.Next;

                //Chequeamos el valor del Nodo. Si coincide con el valor buscado, devolvemos ese nodo.
                if(this.actualNodo.Data == v)
                {
                    return actualNodo;
                }
            }

            //Si no se encontro el valor devolvemos null.
            return null;
        }

        //El siguiente metodo devolvera el índice del Nodo con el valor buscado.
        public int GetIndexOfValue (int v)
        {
            //Establecemos el valor de indice de anchor. En este caso particular anchor no contiene ningun valor, por ende,
            //omitimos el valor de su índice.
            int i = -1;

            if(IsEmpty())
            {
                return i;
            }
            
            this.actualNodo = this.anchor;

            while(this.actualNodo.Next != null)
            {
                //Avanzamos al siguiente nodo de la lista y actualizamos el valor del indice.
                this.actualNodo = this.actualNodo.Next;
                i++;

                //Chequeamos si el valor del nodo coincide con el valor buscado, en cuyo caso devolvemos el indice actualizado.
                if(this.actualNodo.Data == v)
                {
                    return i;
                }
            }
            
            return -1;
        }

        //El siguiente metodo devuelve la referencia del Nodo anterior en la lista, de un Nodo cuyo valor se busca.
        public CNodo PreviousNodo (int v)
        {
            //Chequeamos si la LinkedList esta vacia
            if(IsEmpty())
            {
                return null;
            }

            //Configuramos actualNodo para comenzar la iteracion
            this.actualNodo = this.anchor;

            /*
            En este caso, las condiciones de la iteracion estan atadas a 2 condiciones:
            1- La existencia de un Nodo siguiente al cual "avanzar".
            2- Como debemos devolver la referencia al nodo ANTERIOR al nodo que tiene el valor que BUSCAMOS, chequeamos si el valor del Nodo
            siguiente coincide con el valor buscado.
            Solo si estas 2 condiciones se cumplen, seguiremos avanzando en la iteracion.
            */
            while(this.actualNodo.Next != null && this.actualNodo.Next.Data != v)
            {
                this.actualNodo = this.actualNodo.Next;
            }

            /*
            Una vez fuera del ciclo solo podemos tener 2 resultados:
            1- El valor buscado v fue encontrado y actualNodo tiene la referencia al nodo anterior a este; que es lo que debemos retornar.
            2- La lista NO contiene el valor que buscamos, por ende actualNodo no tiene un Next y no se cumple el objetivo de la función.
            */
            if(this.actualNodo.Next == null)
            {
                //No se encontro el valor.
                return null;
            }
            
            //Se encontro el valor y se devuelve la referencia del Nodo anterior.
            return actualNodo;
        }

        //El siguiente metodo eliminara de la lista el nodo con el valor que se pase.
        public void DeleteNodo (int v)
        {
            //Chequeamos que la lista no se encuentra vacia
            if(IsEmpty())
            {
                return;
            }

            //Chequeamos si el valor del nodo con el valor a eliminar existe dentro de la lista
            if(SearchValue(v) == null)
            {
                return;
            }
            
            //Obtenemos las referencias del nodo a eliminar y el nodo anterior al mismo
            this.supportNodo = PreviousNodo(v);
            this.actualNodo = SearchValue(v);

            //Ligamos el nodo previo al siguiente del nodo que vamos a eliminar.
            this.supportNodo.Next = this.actualNodo.Next;

            //Finalmente desligamos el nodo de la lista, poniendo su referencia Next en null;
            this.actualNodo.Next = null;
        }
    
        /*
        El siguiente metodo permite insertar un nuevo nodo con un valor pasado por parametro. Es necesario tambien
        aclarar luego de cual nodo queremos hacer la insercion. Para ello le pasaremos el valor de dicho nodo tambien
        por parametro.
        */
        public void InsertNodo (int nodoValue, int newValue)
        {
            //Si la lista esta vacia, simplemente insertamos el nuevo nodo despues del anchor
            if(IsEmpty())
            {
                //Referenciamos el anchor
                this.actualNodo = this.anchor;

                //Creamos un nuevo nodo
                this.supportNodo = new CNodo();

                //Asignamos el valor pasado por parametro al nuevo Nodo
                this.supportNodo.Data = newValue;

                //Enlazamos el nuevo nodo a nuestro nodo anterior(En este caso el anchor)
                this.actualNodo.Next = this.supportNodo;

                //Finalizamos la ejecucion del metodo
                return;
            }

            //El valor pasado por parametro no pertenece a ningun nodo en la lista
            if(SearchValue(nodoValue) == null)
            {
                //Referenciamos el anchor y recorremos la lista hasta el final
                this.actualNodo = this.anchor;

                while(this.actualNodo.Next != null)
                {
                    this.actualNodo = this.actualNodo.Next;
                }

                //Una vez ubiacados en el final generamos un nuevo nodo y le pasamos el valor
                this.supportNodo = new CNodo();
                this.supportNodo.Data = newValue;

                //Enlazamos el nuevo nodo al final de la lista
                this.supportNodo.Next = null;
                this.actualNodo.Next = this.supportNodo;
                
                //Finalizamos la ejecucion del metodo
                return;
            }

            //En caso de que el valor pasado por parametro pertenezca a un nodo de la lista, nos ubicamos en dicho nodo
            this.actualNodo = SearchValue(nodoValue);
            //Referenciamos el nodo siguiente al nodo encontrado
            this.supportNodo = this.actualNodo.Next;

            //Creamos el nuevo nodo
            CNodo newElement = new CNodo();
            //Le pasamos el valor correspondiente al nodo recien creado
            newElement.Data = newValue;
            //Enlazamos el nodo encotrado al nodo recien creado
            this.actualNodo.Next = newElement;
            //Enlazamos el nuevo nodo al que era Next del nodo encontrado
            newElement.Next = this.supportNodo;
        }
    
        //El siguiente metodo insertara un nodo en la posicion inicial de la LinkedList
        public void InsertFirstNodo (int v)
        {
            if(IsEmpty())
            {
                this.actualNodo = this.anchor;
                this.supportNodo = new CNodo();
                this.supportNodo.Data = v;
                this.actualNodo.Next = this.supportNodo;
                this.supportNodo.Next = null;

                return;
            }

            this.actualNodo = anchor;
            this.supportNodo = this.actualNodo.Next;

            CNodo newElement = new CNodo();
            newElement.Data = v;

            this.actualNodo.Next = newElement;
            newElement.Next = this.supportNodo;
        }
    
        //El siguiente metodo devuelve el nodo cuyo indice dentro de la lista coincide con el pasado por parametro.
        public CNodo SearchByIndex (int i)
        {
            //Chequeamos si la LinkedList esta vacia
            if(IsEmpty() == null)
            {
                return null;
            }

            //Configuramos las referencias para comenzar a iterar en la lista
            this.actualNodo = this.anchor;
            int actualIndex = -1;

            while(this.actualNodo.Next != null)
            {
                //Actualizamos el valor del nodo y el indice del mismo
                this.actualNodo = this.actualNodo.Next;
                actualIndex++;

                //Chequeamos si el indice actual coincide con el indice pasado por parametro
                if(actualIndex == i)
                {
                    //Si es correcto, devolvemos el nodo.
                    return this.actualNodo;
                }
            }

            //En caso de no encontrarse, devolvemos null.
            return null;
        }
    
        //Indexamos nuestra lista para leer o modificar el valor de cierto nodo.
        public int this[int i]
        {
            get
            {
                this.actualNodo = SearchByIndex(i);
                return actualNodo.Data;
            }

            set
            {
                this.actualNodo = SearchByIndex(i);
                if(this.actualNodo != null)
                {
                    this.actualNodo.Data = value;
                }
            }
        }
    }
}