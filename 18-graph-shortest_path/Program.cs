namespace GraphShortestPath
{
    class Program
    {
        public static void Main ()
        {
            int start = 0;
            int end = 0;
            int distance = 0;
            int n = 0;
            int m = 0;
            int nodesNumber = 7;
            string data = "";

            Graph myGraph = new Graph(nodesNumber);

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

            //En aplicaciones reales es neceario implementar medidas de seguridad, por ejemplo, verificar los indices.
            Console.WriteLine("Dame el nodo de inicio: ");
            data = Console.ReadLine();
            start = Convert.ToInt32(data);

            Console.WriteLine("Dame el nodo final: ");
            data = Console.ReadLine();
            end = Convert.ToInt32(data);

            /*
            Creamos la tabla:
            0 - Visitado
            1 - Distancia
            2 - Previo
            */
            int[,] board = new int[nodesNumber, 3];

            //Inicializamos la tabla
            for(n=0; n<nodesNumber; n++)
            {
                board[n, 0] = 0;
                board[n, 1] = int.MaxValue;
                board[n, 2] = 0;
            }

            board[start, 1] = 0;

            PrintBoard(board);

            for(distance=0; distance<nodesNumber; distance++)
            {
                for(n=0; n<nodesNumber; n++)
                {
                    if((board[n, 0] == 0) && (board[n, 1] == distance))
                    {
                        board[n, 0] = 1;

                        for(m=0; m<nodesNumber; m++)
                        {
                            if(myGraph.getAdjancent(n, m) == 1)
                            {
                                if(board[m ,1] == int.MaxValue)
                                {
                                    board[m, 1] = distance + 1;
                                    board[m, 2] = n;
                                }
                            }
                        }
                    }
                }
            }

            PrintBoard(board);

            List<int> route = new List<int>();
            int node01 = end;

            while(node01 != start)
            {
                route.Add(node01);
                node01 = board[node01, 2];
            }

            route.Add(start);
            route.Reverse();

            foreach(int position in route)
            {
                Console.Write("{0} -> ", position);
            }

            Console.WriteLine();
        }

        public static void PrintBoard (int[,] board)
        {
            int n = 0;

            for(n=0; n<board.GetLength(0); n++)
            {
                Console.WriteLine("{0} -> {1}\t{2}\t{3}", n, board[n, 0], board[n, 1], board[n, 2]);
            }

            Console.WriteLine("------");
        }
    }
}