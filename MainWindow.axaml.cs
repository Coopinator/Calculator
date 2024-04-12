using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using System;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        Bitmap myBitmapO;
        Bitmap myBitmapX;
        bool playerOne = true, gameOver = false;
        double xWins = 0, oWins = 0;
        int numGames;
        BoardChecker boardChecker;

        public MainWindow()
        {
            InitializeComponent();
            TurnText.Text = "X";
            boardChecker = new BoardChecker();
            boardChecker.Clear();
            myBitmapO = new Bitmap("Images/cat.png");
            myBitmapO = myBitmapO.CreateScaledBitmap(new PixelSize(100, 100));
            myBitmapX = new Bitmap("Images/logo.png");
            myBitmapX = myBitmapX.CreateScaledBitmap(new PixelSize(100, 100));
        }
        
        public void GameManager()
        {
            playerOne = !playerOne;
            if (playerOne)
                TurnText.Text = "X";
            else
                TurnText.Text = "O";

            if (boardChecker.Xwin() == true || boardChecker.Owin() == true || boardChecker.Tie() == true)
            {
                numGames++;
                EndGame();
            }
        }

        public void EndGame()
        {
            gameOver = true;
            if (boardChecker.Xwin())
            {
                WinnerText.Text = "X wins!";
                xWins++;
            }   
            else if (boardChecker.Owin())
            {
                WinnerText.Text = "O wins!";
                oWins++;
            }
            else
                WinnerText.Text = "Tie game!";

            WinRate.Text = "Records: \n" + "X winning " + Math.Round((xWins / numGames), 2).ToString() + "\n"
                                         + "O winning " + Math.Round((oWins / numGames), 2).ToString();
        }

        public void NewGame()
        {
            playerOne = true;
            gameOver = false;
            TurnText.Text = "X";
            WinnerText.Text = "";
            boardChecker.Clear();
            Button1.Background = null;  Button2.Background = null;  Button3.Background = null;
            Button4.Background = null;  Button5.Background = null;  Button6.Background = null;
            Button7.Background = null;  Button8.Background = null;  Button9.Background = null;
        }

        public void Reset()
        {
            NewGame();
        }

        public void PlayAgainHandler(object sender, RoutedEventArgs arg)
        {
            NewGame();
        }
        public void ClickHandler1(object sender, RoutedEventArgs arg)
        {
            if(!gameOver && boardChecker.board[0] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(0, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button1.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(0, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button1.Background = b;
                }
                GameManager();
            }
        }

        public void ClickHandler2(object sender, RoutedEventArgs arg)
        {
            if(!gameOver && boardChecker.board[1] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(1, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button2.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(1, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button2.Background = b;
                }
                GameManager();
            }

        }
        public void ClickHandler3(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[2] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(2, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button3.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(2, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button3.Background = b;
                }
                GameManager();
            }

        }
        public void ClickHandler4(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[3] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(3, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button4.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(3, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button4.Background = b;
                }
                GameManager();
            }
        }
        public void ClickHandler5(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[4] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(4, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button5.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(4, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button5.Background = b;
                }
                GameManager();
            }
        }
        public void ClickHandler6(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[5] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(5, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button6.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(5, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button6.Background = b;
                }
                GameManager();
            }
        }

        public void ClickHandler7(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[6] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(6, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button7.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(6, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button7.Background = b;
                }
                GameManager();
            }
        }

        public void ClickHandler8(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[7] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(7, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button8.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(7, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button8.Background = b;
                }
                GameManager();
            }
        }

        public void ClickHandler9(object sender, RoutedEventArgs arg)
        {
            if (!gameOver && boardChecker.board[8] == "")
            {
                if (playerOne)
                {
                    boardChecker.Accumulate(8, "x");
                    ImageBrush b = new ImageBrush(myBitmapX);
                    Button9.Background = b;
                }
                else
                {
                    boardChecker.Accumulate(8, "o");
                    ImageBrush b = new ImageBrush(myBitmapO);
                    Button9.Background = b;
                }
                GameManager();
            }
        }
    }
}