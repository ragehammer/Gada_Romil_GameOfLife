using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gada_Romil_GameOfLife
{
    public partial class Form1 : Form
    {
        // The universe array
        static bool[,] universe = new bool[20, 20];
        int[,] countNeighbor = new int[universe.GetLength(0), universe.GetLength(1)];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // The width and height of each cell in pixels
            float cellWidth = panel1.ClientSize.Width / (float)universe.GetLength(0);
            float cellHeight = panel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            Brush cellBrush = new SolidBrush(cellColor);

            numOfNeighbours();


            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    if (countNeighbor[x, y] != 0)
                    {
                        Font myFont = new Font("Times New Roman", cellRect.Height - 6);
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        RectangleF rectangle = new RectangleF(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                        e.Graphics.DrawString(countNeighbor[x, y].ToString(), myFont, Brushes.Red, rectangle, stringFormat);
                    }
                }
            }
            // Cleaning up pens and brushes
            gridPen.Dispose();
        }

        private void numOfNeighbours()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    countNeighbor[x, y] = 0;
                }
            }

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y])
                    {
                        for (int a = -1; a <= 1; a++)
                        {
                            for (int b = -1; b <= 1; b++)
                            {
                                if (!(a == 0 && b == 0))
                                {
                                    if (!(x + a > universe.GetLength(0) - 1 || x + a < 0 || y + b > universe.GetLength(1) - 1 || y + b < 0))
                                    {
                                        countNeighbor[x + a, b + y]++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }

        private void nextGen()
        {
            generations++;
            bool[,] scratch = new bool[universe.GetLength(0) + 2, universe.GetLength(1) + 2];
            scratch = universe;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if(countNeighbor[x,y] == 1 || countNeighbor[x,y]>3)
                    {
                        scratch[x, y] = false;
                    }
                    else if(countNeighbor[x,y]==3)
                    {
                        scratch[x, y] = true;
                    }
                }
            }
            universe = scratch;
            numOfNeighbours();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                float cellWidth = panel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = panel1.ClientSize.Height / (float)universe.GetLength(1);
                int x = (int)(e.X / cellWidth);
                int y = (int)(e.Y / cellHeight);

                universe[x, y] = !universe[x, y];

                panel1.Invalidate();
            }
        }
        

        private void toolStripButton_Next_Click(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void toolStripButton_Pause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void toolStripButton_New_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear ()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    countNeighbor[x, y] = 0;
                    universe[x, y] = false;
                }
            }
            panel1.Invalidate();
        }
       

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;

        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }
    }
}
