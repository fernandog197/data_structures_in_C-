namespace Graphs
{
    class Program
    {
        public static void Main ()
        {
            int node = 0;

            Graph myGraph = new Graph(7);

            myGraph.AddEdge(0, 1);
            myGraph.AddEdge(0, 2);
            myGraph.AddEdge(0, 3);
            myGraph.AddEdge(1, 3);
            myGraph.AddEdge(1, 4);
            myGraph.AddEdge(2, 5);
            myGraph.AddEdge(3, 2);
            myGraph.AddEdge(3, 5);
            myGraph.AddEdge(3, 6);
            myGraph.AddEdge(4, 3);
            myGraph.AddEdge(4, 6);
            myGraph.AddEdge(6, 5);

            myGraph.printAdjacency();

            myGraph.calculateInDegree();
            myGraph.printInDegree();

            Console.ForegroundColor = ConsoleColor.Cyan;

            do
            {
                node = myGraph.foundZeroInDegree();

                if(node != -1)
                {
                    Console.Write("{0} -> ", node);

                    myGraph.decreaseInDegree(node);
                } 


            } while (node != -1);
            
            Console.WriteLine();
        }
    }
}