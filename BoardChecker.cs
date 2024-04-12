using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class BoardChecker : IChecker
    {
        public bool gameOver;
        public string winner = "";
        public string[] board = new string[9];

        public void Accumulate(int i, string s)
        {
            board[i] = s;
        }

        public void Clear()
        {
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = "";
            }
        }

        public bool Owin()
        {
            /*012
             *345
             *678*/

            // Horizontal win conditions
            if (( board[0] == "o" && board[1] == "o" && board[2] == "o" ) || 
                ( board[3] == "o" && board[4] == "o" && board[5] == "o" ) ||
                ( board[6] == "o" && board[7] == "o" && board[8] == "o" ) ||

            // Vertical win conditions
                ( board[0] == "o" && board[3] == "o" && board[6] == "o" ) ||
                ( board[1] == "o" && board[4] == "o" && board[7] == "o" ) ||
                ( board[2] == "o" && board[5] == "o" && board[8] == "o" ) ||

            // Diaginal win conditions
                ( board[0] == "o" && board[4] == "o" && board[8] == "o" ) ||
                ( board[6] == "o" && board[4] == "o" && board[2] == "o" ))
                
                return true;
            
            else

            return false;
        }

        public bool Tie()
        {
            if (board[0] != "" && board[1] != "" && board[2] != "" &&
                board[3] != "" && board[4] != "" && board[5] != "" &&
                board[6] != "" && board[6] != "" && board[7] != "" &&
                
                Owin() == false && Xwin() == false )
                
                return true;

            else
                return false;
        }

        public bool Xwin()
        {
            /*012
             *345
             *678*/

            // Horizontal win conditions
            if ((board[0] == "x" && board[1] == "x" && board[2] == "x") ||
                (board[3] == "x" && board[4] == "x" && board[5] == "x") ||
                (board[6] == "x" && board[7] == "x" && board[8] == "x") ||

            // Vertical win conditions
                (board[0] == "x" && board[3] == "x" && board[6] == "x") ||
                (board[1] == "x" && board[4] == "x" && board[7] == "x") ||
                (board[2] == "x" && board[5] == "x" && board[8] == "x") ||

            // Diaginal win conditions
                (board[0] == "x" && board[4] == "x" && board[8] == "x") ||
                (board[6] == "x" && board[4] == "x" && board[2] == "x"))

                return true;

            else

                return false;
        }
    }
}
