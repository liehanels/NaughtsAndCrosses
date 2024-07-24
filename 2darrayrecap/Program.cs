namespace _2darrayrecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] oandx = new string[3, 3];
            int i = 0;
            newGame(oandx);
            while (getWinner(oandx, i))
            {
                Console.WriteLine(getPlayer(i) + " next move?");
                string pos = Console.ReadLine() + "";
                string icon = getIcon(i);
                makeMove(oandx, pos, icon);
                i++;
            }
        }
        static void newGame(string[,] oandx)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    oandx[i,j] = " ";
                }
            }
            printTable(oandx);
        }
        static void printTable(string[,] oandx)
        {
            Console.WriteLine("   A | B | C");
            Console.WriteLine("  -----------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i+1) +"| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(oandx[i,j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("  -----------");
            }
        }
        static void makeMove(string[,] oandx, string pos, string icon)
        {
            int x, y = 0;
            if (pos.Contains("A")||pos.Contains("a")) { x = 0; }
            else if (pos.Contains("B") || pos.Contains("b")) { x = 1; }
            else { x = 2; }
            y = int.Parse(pos[1] + "") - 1;
            if (!oandx[y, x].Equals(" ")) { Console.WriteLine("Invalid move"); }
            else { oandx[y, x] = icon; }
            printTable(oandx);
        }
        static string getIcon(int i)
        {
            if(i % 2 == 0) { return "x"; }
            else { return "o"; }
        }
        static string getPlayer(int i)
        {
            if(i % 2 == 0) { return "Player 1 "; }
            else { return "Player 2 "; }
        }
        static bool getWinner(string[,] oandx, int i)
        {
            i++;
            //diag1
            if (oandx[0,0] == oandx[1,1] && oandx[0, 0] == oandx[2, 2] && oandx[0,0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[0,0]);
                return false;
            }
            //diag2
            else if (oandx[2, 0] == oandx[1, 1] && oandx[2, 0] == oandx[0, 2] && oandx[2, 0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[2, 0]);
                return false;
            }
            //row1
            else if(oandx[0, 0] == oandx[0, 1] && oandx[0, 0] == oandx[0, 2] && oandx[0, 0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[0, 0]);
                return false;
            }
            //row2
            else if (oandx[1, 0] == oandx[1, 1] && oandx[1, 0] == oandx[1, 2] && oandx[1, 0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[1, 0]);
                return false;
            }
            //row3
            else if (oandx[2, 0] == oandx[2, 1] && oandx[2, 0] == oandx[2, 2] && oandx[2, 0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[2, 0]);
                return false;
            }
            //col1
            else if (oandx[0, 0] == oandx[1, 0] && oandx[0, 0] == oandx[2, 0] && oandx[0, 0] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[0, 0]);
                return false;
            }
            //col2
            else if (oandx[0, 1] == oandx[1, 1] && oandx[0, 1] == oandx[2, 1] && oandx[0, 1] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[0, 1]);
                return false;
            }
            //col3
            else if (oandx[0, 2] == oandx[1, 2] && oandx[0, 2] == oandx[2, 2] && oandx[0, 2] != " ")
            {
                Console.WriteLine("Winner is " + getPlayer(i) + oandx[0, 2]);
                return false;
            }
            else { return true; }
        }
    }
}
