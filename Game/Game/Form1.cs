using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    
    public partial class Form1 : Form
    {
        private Rectangle[] grid = new Rectangle[9];
        /*
         * 0 | 1 | 2
         *-----------
         * 3 | 4 | 5
         * ----------
         * 6 | 7 | 8
         * 
         */

        //different color pens
        Pen penO = new Pen(Brushes.RosyBrown, 2);
        Pen penX = new Pen(Brushes.BlueViolet, 2);
        Pen gridPen = new Pen(Brushes.DarkSlateGray, 3);

        //keep track of placement
        List<char> fillGrid = new List<char>(9);

        //players in pvc
        string[] players = new string[2] { "you", "computer" };

        //for coin flip
        Random randomize = new Random();

        //for 'O's
        private Rectangle[] circles = new Rectangle[9];

        //players in pvp
        string[] pvpPlayers = new string[2] { "you", "opponent" };

        char pvpPawn;
        public Form1()
        {
            InitializeComponent();

            //boxes from left to right
            grid[0] = new Rectangle(0, 0, 96, 96);
            grid[1] = new Rectangle(102, 0, 96, 96);
            grid[2] = new Rectangle(204, 0, 96, 96);
            grid[3] = new Rectangle(0, 102, 96, 96);
            grid[4] = new Rectangle(102, 102, 96, 96);
            grid[5] = new Rectangle(204, 102, 96, 96);
            grid[6] = new Rectangle(0, 204, 96, 96);
            grid[7] = new Rectangle(102, 204, 96, 96);
            grid[8] = new Rectangle(230, 204, 96, 96);

            //no moves yet
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');
            fillGrid.Add('N');

            //create circles
            circles[0] = new Rectangle(12, 12, 70, 70);
            circles[1] = new Rectangle(114, 12, 70, 70);
            circles[2] = new Rectangle(216, 12, 70, 70);
            circles[3] = new Rectangle(12, 114, 70, 70);
            circles[4] = new Rectangle(114, 114, 70, 70);
            circles[5] = new Rectangle(216, 114, 70, 70);
            circles[6] = new Rectangle(12, 216, 70, 70);
            circles[7] = new Rectangle(114, 216, 70, 70);
            circles[8] = new Rectangle(215, 216, 70, 70);

            panel.Enabled = false;
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = panel.CreateGraphics();
            g.DrawLine(gridPen, 201, 0, 201, 300);
            g.DrawLine(gridPen, 99, 0, 99, 300);
            g.DrawLine(gridPen, 0, 99, 300, 99);
            g.DrawLine(gridPen, 0, 201, 300, 201);
        }//end OnPaint

        //you will always be an 'X'
        void Panel_Click(object sender, MouseEventArgs e)
        {
            Graphics g = panel.CreateGraphics();
            if (pvc.Checked == true)
            {
                //top left corner move...
                if (grid[0].Contains(e.Location) && fillGrid[0].Equals('N'))
                {
                    DrawTopLeftCorner('X');
                    fillGrid[0] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //top edge move...
                if (grid[1].Contains(e.Location) && fillGrid[1].Equals('N'))
                {
                    DrawTopEdge('X');
                    fillGrid[1] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //top left corner move...
                if (grid[2].Contains(e.Location) && fillGrid[2].Equals('N'))
                {
                    DrawTopRightCorner('X');
                    fillGrid[2] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //left edge move...
                if (grid[3].Contains(e.Location) && fillGrid[3].Equals('N'))
                {
                    DrawLeftEdge('X');
                    fillGrid[3] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //center move...
                if (grid[4].Contains(e.Location) && fillGrid[4].Equals('N'))
                {
                    DrawCenter('X');
                    fillGrid[4] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //edge right move...
                if (grid[5].Contains(e.Location) && fillGrid[5].Equals('N'))
                {
                    DrawRightEdge('X');
                    fillGrid[5] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //bottom left corner move...
                if (grid[6].Contains(e.Location) && fillGrid[6].Equals('N'))
                {
                    DrawBottomLeftCorner('X');
                    fillGrid[6] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //bottom edge move...
                if (grid[7].Contains(e.Location) && fillGrid[7].Equals('N'))
                {
                    DrawBottomEdge('X');
                    fillGrid[7] = 'X';

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }
                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }

                    currentTurn.Text = "Turn : computer";

                    dumbComputer();
                }

                //bottom right corner move...
                if (grid[8].Contains(e.Location) && fillGrid[8].Equals('N'))
                {
                    DrawBottomRightCorner('X');
                    fillGrid[8] = 'X';

                    currentTurn.Text = "Turn : computer";

                    //check if game is over...
                    int i = IsGameOver('X');
                    if (i.Equals(1))
                    {
                        MessageBox.Show("you win!");
                        Close();
                        return;
                    }

                    if (i.Equals(0))
                    {
                        MessageBox.Show("tie game");
                        Close();
                        return;
                    }
                    dumbComputer();
                }
            }//end pvc

            if (pvp.Checked == true)
            {
                if (grid[0].Contains(e.Location) && fillGrid[0].Equals('N'))
                {
                    DrawTopLeftCorner(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[0] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[0] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[1].Contains(e.Location) && fillGrid[1].Equals('N'))
                {
                    DrawTopEdge(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[1] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[1] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[2].Contains(e.Location) && fillGrid[2].Equals('N'))
                {
                    DrawTopRightCorner(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[2] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[2] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[3].Contains(e.Location) && fillGrid[3].Equals('N'))
                {
                    DrawLeftEdge(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[3] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[3] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[4].Contains(e.Location) && fillGrid[4].Equals('N'))
                {
                    DrawCenter(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[4] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[4] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[5].Contains(e.Location) && fillGrid[5].Equals('N'))
                {
                    DrawRightEdge(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[5] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[5] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[6].Contains(e.Location) && fillGrid[6].Equals('N'))
                {
                    DrawBottomLeftCorner(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[6] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[6] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[7].Contains(e.Location) && fillGrid[7].Equals('N'))
                {
                    DrawBottomEdge(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[7] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[7] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }

                if (grid[8].Contains(e.Location) && fillGrid[8].Equals('N'))
                {
                    DrawBottomRightCorner(pvpPawn);
                    if (pvpPawn == 'X')
                    {
                        fillGrid[8] = 'X';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("you win!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : Opponent";
                        pvpPawn = 'O';
                    }

                    else if (pvpPawn == 'O')
                    {
                        fillGrid[8] = 'O';
                        //check if game is over...
                        int i = IsGameOver(pvpPawn);
                        if (i.Equals(1))
                        {
                            MessageBox.Show("opponent wins!");
                            Close();
                            return;
                        }

                        if (i.Equals(0))
                        {
                            MessageBox.Show("tie game");
                            Close();
                            return;
                        }
                        currentTurn.Text = "Turn : You";
                        pvpPawn = 'X';
                    }
                }//end pvp
            }//end Form1_Click
    }//end Panel_CLick

        //check if someone won
        // 0 tie
        // 1 win
        // -1 game not over
        private int IsGameOver(char pawn)
        {
            if ((fillGrid[0].Equals(pawn) && fillGrid[1].Equals(pawn) && fillGrid[2].Equals(pawn)) ||
               (fillGrid[3].Equals(pawn) && fillGrid[4].Equals(pawn) && fillGrid[5].Equals(pawn)) ||
               (fillGrid[6].Equals(pawn) && fillGrid[7].Equals(pawn) && fillGrid[8].Equals(pawn)) ||
               (fillGrid[0].Equals(pawn) && fillGrid[3].Equals(pawn) && fillGrid[6].Equals(pawn)) ||
               (fillGrid[1].Equals(pawn) && fillGrid[4].Equals(pawn) && fillGrid[7].Equals(pawn)) ||
               (fillGrid[2].Equals(pawn) && fillGrid[5].Equals(pawn) && fillGrid[8].Equals(pawn)) ||
               (fillGrid[0].Equals(pawn) && fillGrid[4].Equals(pawn) && fillGrid[8].Equals(pawn)) ||
               (fillGrid[6].Equals(pawn) && fillGrid[4].Equals(pawn) && fillGrid[2].Equals(pawn)))
            {
                return 1;
            }

            else if (!fillGrid[0].Equals('N') && !fillGrid[1].Equals('N') && !fillGrid[2].Equals('N') &&
                !fillGrid[3].Equals('N') && !fillGrid[4].Equals('N') && !fillGrid[5].Equals('N') &&
                !fillGrid[6].Equals('N') && !fillGrid[7].Equals('N') && !fillGrid[8].Equals('N'))
            {
                return 0;
            }

            return -1;
        }//end IsGameOver

    //decide who goes first
    private void FlipCoin(object sender, EventArgs e)
    {
        if (pvc.Checked == true)
        {
            button1.Enabled = false;
            panel.Enabled = true;
            panel.Update();
            int i = randomize.Next(0, 2);
            currentTurn.Text = "Turn : " + players[i];
            MessageBox.Show(players[i] + " will go first!");

            if (players[i].Equals("computer"))
            {
                Player1.Text = ("Player 1: Computer");
                Player2.Text = ("Player 2: You");
                dumbComputer();
            }
            else
            {
                Player1.Text = ("Player 1: You");
                Player2.Text = ("Player 2: Computer");
            }
        }//end if pvc

        if (pvp.Checked == true)
        {
            button1.Enabled = false;
            panel.Enabled = true;
            panel.Update();
            int i = randomize.Next(0, 2);
            currentTurn.Text = "Turn : " + pvpPlayers[i];
            MessageBox.Show(pvpPlayers[i] + " will go first!");

            if (pvpPlayers[i].Equals("opponent"))
            {
                Player1.Text = ("Player 1: Opponent");
                Player2.Text = ("Player 2: You");
                pvpPawn = 'O';
            }
            else
            {
                Player1.Text = ("Player 1: You");
                Player2.Text = ("Player 2: Opponent");
                pvpPawn = 'X';
            }
        }//end if pvp
    }//end FlipCoin

        //just for fun
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            position.Text = e.Location.X + ":" + e.Location.Y;
        }

        //computer move
        private void dumbComputer()
        {
            Graphics g = panel.CreateGraphics();
            bool endTurn = false;
            while (endTurn.Equals(false))
            {
                int random = randomize.Next(0, 9);
                if (fillGrid[random].Equals('N'))
                {
                    fillGrid[random] = 'O';
                    g.DrawEllipse(penO, circles[random]);
                    endTurn = true;
                }//end if
            }//end while

            int i = IsGameOver('O');
            if (i.Equals(1))
            {
                MessageBox.Show("computer wins");
                Close();
                return;
            }
            if (i.Equals(0))
            {
                MessageBox.Show("tie game");
                Close();
                return;
            }
            currentTurn.Text = "Turn : you";
        }//end dumbcomputer

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe is a simple game that can be played by yourself or with a friend.\nFirst choose a game type then click 'Flip Coin' to start a new game. \nClick anywhere within the game board to place your pawn. \nRepeate the last step till someone wins..." );
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "Would you like to play another game?";
            const string caption = "Play Again?";

            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

     
            e.Cancel = result == DialogResult.Yes;
            restart();
        }//end onFormClosing

        private void restart()
        {
            button1.Enabled = true;

            //no moves yet
            fillGrid[0] = 'N';
            fillGrid[1] = 'N';
            fillGrid[2] = 'N';
            fillGrid[3] = 'N';
            fillGrid[4] = 'N';
            fillGrid[5] = 'N';
            fillGrid[6] = 'N';
            fillGrid[7] = 'N';
            fillGrid[8] = 'N';
            currentTurn.Text = " ";
            panel.Update();
            panel.Enabled = false;           
        }//end restart

        private void DrawTopLeftCorner(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 25, 25, 77, 77);
                g.DrawLine(penX, 25, 77, 77, 25);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[0]);
        }//end draw

        private void DrawTopEdge(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 121, 25, 173, 77);
                g.DrawLine(penX, 121, 77, 173, 25);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[1]);
        }//end draw

        private void DrawTopRightCorner(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 217, 25, 269, 77);
                g.DrawLine(penX, 217, 77, 269, 25);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[2]);
        }//end draw

        private void DrawLeftEdge(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 25, 173, 77, 121);
                g.DrawLine(penX, 25, 121, 77, 173);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[3]);
        }//end draw

        private void DrawCenter(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 122, 173, 174, 121);
                g.DrawLine(penX, 122, 121, 174, 173);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[4]);
        }//end draw

        private void DrawRightEdge(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 218, 173, 270, 121);
                g.DrawLine(penX, 218, 121, 270, 173);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[5]);
        }//end draw

        private void DrawBottomLeftCorner(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 26, 269, 78, 217);
                g.DrawLine(penX, 26, 217, 78, 269);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[6]);
        }//end draw

        private void DrawBottomEdge(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 122, 269, 174, 217);
                g.DrawLine(penX, 122, 217, 174, 269);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[7]);
        }//end draw

        private void DrawBottomRightCorner(char pawn)
        {
            Graphics g = panel.CreateGraphics();
            if (pawn.Equals('X'))
            {
                g.DrawLine(penX, 218, 269, 270, 217);
                g.DrawLine(penX, 218, 217, 270, 269);
            }
            else if (pawn.Equals('O'))
                g.DrawEllipse(penO, circles[8]);
        }//end draw

        private void newPvPGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pvp.Checked = true;
            pvc.Checked = false;
            FlipCoin(sender,e);
        }//end pvp shortcut

        private void newPvCGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pvp.Checked = false;
            pvc.Checked = true;
            FlipCoin(sender, e);
        }//end pvc shortcut

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restart();
        }
    }//end Form1
}// end namespace
