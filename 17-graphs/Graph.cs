namespace Graphs
{
    class Graph
    {
        int[,] myAdjacent;
        int[] inDegree;
        int nodes;

        public Graph (int nodes)
        {
            this.nodes = nodes;
            this.myAdjacent = new int[nodes, nodes];
            this.inDegree = new int[nodes];
        }

        public void AddEdge (int firstNode, int lastNode)
        {
            myAdjacent[firstNode, lastNode] = 1;
        }

        public void printAdjacency ()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(n=0; n<this.nodes; n++)
            {
                Console.Write("\t{0}", n);
            }

            Console.WriteLine();

            for(n=0; n<this.nodes; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);

                for(m=0; m<this.nodes; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0}", myAdjacent[n, m]);
                }
                Console.WriteLine();
            }
        }

        public void calculateInDegree ()
        {
            int n = 0;
            int m = 0;

            for(n=0; n<this.nodes; n++)
            {
                for(m=0; m<this.nodes; m++)
                {
                    if(myAdjacent[m, n] == 1)
                    {
                        inDegree[n]++;
                    }
                }
            }
        }

        public void printInDegree ()
        {
            int n = 0;

            Console.ForegroundColor = ConsoleColor.White;

            for(n=0; n<this.nodes; n++)
            {
                Console.WriteLine("Nodo: [{0}][{1}]", n, inDegree[n]);
            }
        }

        public int foundZeroInDegree ()
        {
            bool found = false;
            int n = 0;

            for(n=0; n<this.nodes; n++)
            {
                if(inDegree[n] == 0)
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                return n;
            }
            else
            {
                return -1;
            }
        }

        public void decreaseInDegree (int node)
        {
            inDegree[node] = -1;

            int n = 0;

            for(n=0; n<this.nodes; n++)
            {
                if(myAdjacent[node, n] == 1)
                {
                    inDegree[n]--;
                }
            }
        }
    }
}