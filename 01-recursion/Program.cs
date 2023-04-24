/*
RECURSION

Podria definirse como la resolución de un problema haciendo uso de una versión mas sencilla del mismo.
- Parte inductiva: Invoco una versión mas sencilla del problema para poder resolverlo.
- Caso base: podemos resolver directamente el problema.

Utilizar recursión no implica que el método que se utiliza se "llama a si mismo", sino que genera un instancia totalmente
nueva del mismo; que deja en standby la instancia anterior hasta llegar al caso base, devolviendo un valor.
*/

namespace Recursion
{
    class Program
    {
        public static void Main()
        {
            int f = 0;
            int fibo;

            //5! = 5*4*3*2*1

            f = Factorial(5);
            fibo = Fibonacci(6);

            Console.WriteLine("Resultado de Factorial: ");
            Console.WriteLine(f);

            Console.WriteLine("Resultado de Fibonacci: ");
            Console.WriteLine(fibo);
        }
        public static int Factorial (int n)
        {
            int r = 0;

            //caso inductivo
            if(n > 1)
            {
                r = n * Factorial(n - 1);
            }

            //caso base
            if(n == 1)
            {
                r = 1;
            }

            return r;
        }

        public static int Fibonacci (int n)
        {
            int r = 0;

            //caso inductivo
            if(n > 1)
            {
                r = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            //caso base
            if(n <= 1)
            {
                r = 1;
            }

            return r;
        }
    }
}