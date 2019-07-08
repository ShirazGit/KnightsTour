using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moveSmart_CheckedChanged(object sender, EventArgs e)
        {
            if (moveSmart.Checked)
            {
                Board.smart = true;
            }
        }

        private void moveDumb_CheckedChanged(object sender, EventArgs e)
        {
            if (moveDumb.Checked)
            {
                Board.smart = false;
            }

        }

        private void selectColumn_ValueChanged(object sender, EventArgs e)
        {
        }

        private void selectRow_ValueChanged(object sender, EventArgs e)
        {
        }

        private void selectNumTours_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int startingRow = Convert.ToInt32(selectRow.Value); //which row the piece will start in
            int startingColumn = Convert.ToInt32(selectColumn.Value); //which row the piece will end in
            int trials = Convert.ToInt32(selectNumTours.Value);
            Board.i = startingColumn;
            Board.j = startingRow;
            String textToFile = "";
            String filename;
            String boardDisplay = "";
            if (Board.smart)
            {
                filename = "shirazHeuristicsMethod.txt";
            }
            else
            {
                filename = "shirazNonIntelligentMethod.txt";
            }

            Boxes[,] board = Board.createBoard();
            Board.setBoard(board);

            for (int k = 1; k <= trials; k++)
            {
                System.Threading.Thread.Sleep(100);
                if (Board.smart == true)
                {
                    for (int x = 0; x <= 64; x++)
                    { //64 total boxes
                        Board.autoMove(board);
                    }
                }
                else
                {
                    Random rand = new Random();
                    do
                    {
                        Board.movement = rand.Next(8);
                        Board.autoMove(board);
                    }
                    while (Board.moveAttempts <= 20);//since there is at most 8 possible moves, if at any point there is 20 attempts to move a piece without success, it will exit the loop
                }
                textToFile += "Trial " + k + ": The Knight was able to successfully touch " + board[Board.i, Board.j].counter + " squares.\n";
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(textToFile);
                }
                if (trials == 1)
                {
                    //Board.printBoard(board);
                    boardDisplay = String.Concat(textToFile, Board.showBoard(board, boardDisplay));
                    MessageBox.Show(String.Format("{0,-4}", boardDisplay), "Tour");
                }
                Board.clearBoard(board);
                Board.i = startingColumn;
                Board.j = startingRow;
                Board.setBoard(board);
            }
            if (trials > 1)
            {
                MessageBox.Show(textToFile, "Tour Results");
            }
        }
    }
}
