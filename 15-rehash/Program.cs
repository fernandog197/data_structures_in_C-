namespace ReHash
{
    class Program
    {
        public static void Main ()
        {
            HashTable myTable = new HashTable(11);

            myTable.Insertion(23, "Hola");
            myTable.Insertion(51, "Manzana");
            myTable.Insertion(40, "Pera");
            myTable.Insertion(62, "Mango");
            myTable.Insertion(32, "Prueba");
            myTable.Insertion(11, "de");
            myTable.Insertion(21, "Rehash");

            myTable.Print();
            Console.WriteLine("-----");

            myTable.Insertion(4, "C#");
            myTable.Insertion(54, "Otro mas");
            myTable.Insertion(18, "Nuevo elemento");
            myTable.Insertion(98, "Nuevo elemento02");

            myTable.Print();
            Console.WriteLine("-----");
        }
    }
}