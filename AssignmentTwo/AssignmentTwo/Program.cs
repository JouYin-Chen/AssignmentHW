using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            String chessboard = "";
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            chessboard += "X";
                        }
                        else
                        {
                            chessboard += "O";
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            chessboard += "O";
                        }
                        else
                        {
                            chessboard += "X";
                        }
                    }
                }
                chessboard += "\r\n";
            }
            Console.WriteLine(chessboard);
            Console.ReadKey();
        }
    }
}
