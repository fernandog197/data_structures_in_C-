namespace SingBalance
{
    class Program
    {
        public static void Main ()
        {
            string expresion = "";
            char s = ' ';
            Stack pila = new Stack();

            //Pedimos la expresion a evaluar
            Console.WriteLine("Por favor, ingrese la expresion a evaluar: ");
            expresion = Console.ReadLine();

            foreach(char c in expresion)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }

                if(c == ')' || c == ']' || c == '}')
                {
                    if(pila.IsEmpty())
                    {
                        Console.WriteLine("-----| Exceso de simbolos de cierre |-----");
                        return;
                    }
                    else
                    {
                        s = pila.Pop().Data;

                        if(s == '(' && c != ')')
                        {
                            Console.WriteLine("-----| Se esperaba ) |-----");
                            return;
                        }

                        if(s == '[' && c != ']')
                        {
                            Console.WriteLine("-----| Se esperaba ] |-----");
                            return;
                        }

                        if(s == '{' && c != '}')
                        {
                            Console.WriteLine("-----| Se esperaba } |-----");
                            return;
                        }
                    }
                }
            }

            if(!pila.IsEmpty())
            {   
                Console.WriteLine("----| Tiene un exceso de simbolos de apertura |-----");
                return;
            }

            Console.WriteLine("-----| Perfecto! Su expresión esta balanceada |------");
            Console.ReadLine();
        }
    }
}