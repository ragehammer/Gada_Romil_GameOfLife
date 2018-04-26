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

namespace Gada_Romil_GameOfLife
{
    public partial class Form1 : Form
    {
        // The universe array
        public static bool[,] universe = new bool[Properties.Settings.Default.universeW, Properties.Settings.Default.universeH];
        bool hudVisible = true;
        bool gridVisible = true;
        string hudText;
        bool numOfNeighboursb = true;
        public int mode;
        public int[,] countNeighbor = new int[universe.GetLength(0), universe.GetLength(1)];

        // Drawing colors
        public Color gridColor = Color.Black;
        public Color cellColor = Color.Gray;

        // The Timer class
        public Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();
            BackColor = Properties.Settings.Default.backgroundColor;
            gridColor = Properties.Settings.Default.borderColor;
            cellColor = Properties.Settings.Default.cellColor;
            //neighborCountVisible = Properties.Settings.Default.viewNeighbor;
            //gridVisible = Properties.Settings.Default.viewGrid;
            //hudVisible = Properties.Settings.Default.viewHUD;
            mode = Properties.Settings.Default.boundaryType;
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {

            int aliveCells = 0;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y] == true)
                        aliveCells++;
                }
            }

            this.Text = "GOL - Romil Gada" + " Generations: " +  generations + " Cells Alive: "+ aliveCells +
                " Universe Width & Height: " + universe.GetLength(0) + ", " + universe.GetLength(1);


            // The width and height of each cell in pixels
            float cellWidth = panel1.ClientSize.Width / (float)universe.GetLength(0);
            float cellHeight = panel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            Brush cellBrush = new SolidBrush(cellColor);
            Brush cellBrush2 = new SolidBrush(Color.DarkRed);
            Brush brush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));

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
                    if (gridVisible)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }

                    if (countNeighbor[x, y] != 0 && numOfNeighboursb)
                    {
                        Font myFont = new Font("Times New Roman", (int)(cellRect.Height * 0.4));
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        RectangleF rectangle = new RectangleF(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                        e.Graphics.DrawString(countNeighbor[x, y].ToString(), myFont, Brushes.Red, rectangle, stringFormat);
                    }
                }
            }

            if (hudVisible)
            {
                Rectangle rect = new Rectangle(0, 0, 120, 40);
                e.Graphics.FillRectangle(brush, rect);
                hudText =
                      "Generations: " + generations + '\n'
                    + "Cell count: " + aliveCells + '\n'
                    /*+ "Boundary type: " + "implement" + '\n'*/
                    + "Universe Size: " + universe.GetLength(0) + " x " + universe.GetLength(1);
                e.Graphics.DrawString(hudText, this.Font, cellBrush2, rect);
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        bool isValid(int x, int y)
        {
            if (x < 0 || x >= universe.GetLength(y))
                return false;
            return true;
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
                                if (mode == 0)
                                {
                                    if (!(a == 0 && b == 0))
                                    {
                                        if (!(x + a > universe.GetLength(0) - 1 || x + a < 0 ||
                                            y + b > universe.GetLength(1) - 1 || y + b < 0))
                                        {
                                            countNeighbor[x + a, b + y]++;
                                        }
                                    }
                                }
                                else //TOROIDAL
                                {
                                    if (!(a == 0 && b == 0))
                                    {
                                        int XX = x + a;
                                        int YY = y + b;

                                        if (x + a < 0)
                                            XX = universe.GetLength(0) - 1;

                                        if (x + a > universe.GetLength(0) - 1)
                                            XX = 0;

                                        if (y + b < 0)
                                            YY = universe.GetLength(1) - 1;

                                        if (y + b > universe.GetLength(1) - 1)
                                            YY = 0;

                                        bool temp = universe[XX, YY];
                                        if (temp = true)
                                        {
                                            countNeighbor[XX, YY]++;
                                        }
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
                    if (countNeighbor[x, y] == 1 || countNeighbor[x, y] > 3)
                    {
                        scratch[x, y] = false;
                    }
                    
                    else if (countNeighbor[x, y] == 3)
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
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void toolStripButton_Next_Click(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {

            timer.Start();

        }

        private void toolStripButton_Pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void toolStripButton_New_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    countNeighbor[x, y] = 0;
                    universe[x, y] = false;
                }
            }
            generations = 0;
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
            timer.Start();

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Random rand = new Random((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    bool asdf = false;
                    if (rand.Next() % 2 == 0)
                    {
                        asdf = true;

                    }
                    universe[x, y] = asdf;
                }
            }
            generations = 0;
            Refresh();
        }

        private void fromSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                Random rand = new Random(form2.SeedResult());
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        bool asdf = false;
                        if (rand.Next() % 2 == 0)
                        {
                            asdf = true;

                        }
                        universe[x, y] = asdf;
                    }
                }
                generations = 0;
                Refresh();
            }
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            saveFileDialog.Filter = "All Files|*.*|Cells|*.cells";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.WriteLine("!Created by Romil Gada's Game of Life");
                // Iterate through the universe in the y, top to bottom
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String row = string.Empty;
                    // Iterate through the universe in the x, left to right
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            row += "O";
                        }
                        else
                        {
                            row += ".";
                        }
                    }
                    sw.WriteLine(row);
                }
                sw.Close();
            }
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            timer.Stop();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog.Filter = "All Files|*.*|Cells|*.cells";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Clear();

                //for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String row = string.Empty;
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {

                    }
                }

                StreamReader sr = new StreamReader(openFileDialog.FileName);
                int yCount = 0;
                int maxX = 0;
                int maxY = 0;
                bool error = false;
                //While there is still contents in our file 
                while (!sr.EndOfStream)
                {
                    //Create a copy of the current line
                    string curLine = sr.ReadLine();
                    if (curLine[0] == '!')
                        continue;
                    //If the line has cells
                    else if (curLine[0] == '.' || curLine[0] == 'O')
                        maxY++;
                    //Else, the file isn't valid according to the file format
                    else
                    {
                        MessageBox.Show("Error reading file! Is it in the correct format?");
                        error = true;
                    }
                    if (curLine.Length > maxX)
                        maxX = curLine.Length;
                }

                universe = new bool[maxX, maxY];
                for (int y = 0; y < maxY; y++)
                {
                    for (int x = 0; x < maxX; x++)
                    {
                        universe[x, y] = new bool();
                    }
                }

                //Reset our reader to default position
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                //While there is still contents in our file 
                while (!sr.EndOfStream && !error)
                {
                    //Create a copy of the current line
                    string curLine = sr.ReadLine();
                    //If the line is a comment, show it
                    if (curLine[0] == '!' && curLine.Length > 1)
                        MessageBox.Show(curLine);
                    //If the line has cells, set our cells to match
                    else if (curLine[0] == '.' || curLine[0] == 'O')
                    {
                        for (int i = 0; i < curLine.Length; i++)
                        {
                            if (curLine[i] == 'O')
                                universe[i, yCount] = true;
                            else
                                universe[i, yCount]= false;
                        }
                        yCount++;
                    }


                }

                //Close our reader for cleanliness
                sr.Close();
            }
            //Refresh our graphics to show the changes
            Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_Save_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_Open_Click(sender, e);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            //Create our instance of an open file dialog and set its properties
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog.Filter = "All Files|*.*|Cells|*.cells";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Clear();

                {
                    String row = string.Empty;
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {

                    }
                }

                StreamReader sr = new StreamReader(openFileDialog.FileName);
                int yCount = 0;
                while (!sr.EndOfStream)
                {
                    //Create a copy of the current line
                    string curLine = sr.ReadLine();
                    //If the line is a comment, show it
                    if (curLine[0] == '!')
                        MessageBox.Show(curLine);
                    //If the line has cells, set our cells to match
                    else if (curLine[0] == '.' || curLine[0] == 'O')
                    {
                        //For every character in the current line
                        for (int i = 0; i < curLine.Length; i++)
                        {
                            //If there is room in the universe
                            if (i < universe.GetLength(0) && yCount < universe.GetLength(1))
                            {
                                if (curLine[i] == '.')
                                {
                                    universe[i, yCount]= false;
                                }
                                else
                                {
                                    universe[i, yCount]= true;
                                }
                            }
                        }
                        //Prepare for our next line in the next iteration, if there is one
                        yCount++;
                    }
                    //Else, the file isn't valid according to the file format
                    else
                        MessageBox.Show("Error reading file! Is it in the correct format?");
                }
                //Close our reader for cleanliness
                sr.Close();
            }
            //Refresh our graphics to show the changes
            Refresh();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                gridColor = form3.colors[0];
                BackColor = form3.colors[1];
                cellColor = form3.colors[2];

                bool[,] tempUni = universe;
                universe = new bool[form3.cellsWide, form3.cellsHigh];
                countNeighbor = new int[form3.cellsWide, form3.cellsHigh];

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        universe[x, y] = false;

                        if (x < tempUni.GetLength(0) && y < tempUni.GetLength(1))
                        {
                            universe[x, y] = tempUni[x, y];
                        }

                    }
                }
                timer.Interval = form3.time;
                mode = form3.mode;
            }
            Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.borderColor = gridColor;
            Properties.Settings.Default.backgroundColor = BackColor;
            Properties.Settings.Default.cellColor = cellColor;
            Properties.Settings.Default.timeInterval = timer.Interval;
            Properties.Settings.Default.universeW = universe.GetLength(0);
            Properties.Settings.Default.universeH = universe.GetLength(1);
            Properties.Settings.Default.boundaryType = mode;
            Properties.Settings.Default.Save();
        }

        private void gridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridVisible = gridVisibleToolStripMenuItem.Checked;
            panel1.Invalidate();
        }

        private void headsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hudVisible = headsToolStripMenuItem.Checked;
            panel1.Invalidate();

        }

        private void neighbourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numOfNeighboursb = neighbourToolStripMenuItem.Checked;
            panel1.Invalidate();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.borderColor = Color.Black;
            Properties.Settings.Default.backgroundColor = Color.White;
            Properties.Settings.Default.cellColor = Color.Gray;
            Properties.Settings.Default.timeInterval = 200;
            Properties.Settings.Default.universeW = 20;
            Properties.Settings.Default.universeH = 20;
            Properties.Settings.Default.viewNeighbor = true;
            Properties.Settings.Default.viewGrid = true;
            Properties.Settings.Default.viewHUD = true;
            Properties.Settings.Default.boundaryType = 0;

            reloadToolStripMenuItem_Click(sender, e);
            Refresh();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            BackColor = Properties.Settings.Default.backgroundColor;
            gridColor = Properties.Settings.Default.borderColor;
            cellColor = Properties.Settings.Default.cellColor;
            timer.Interval = Properties.Settings.Default.timeInterval;
            numOfNeighboursb = Properties.Settings.Default.viewNeighbor;
            gridVisible = Properties.Settings.Default.viewGrid;
            hudVisible = Properties.Settings.Default.viewHUD;
            bool[,] tempUni = universe;
            universe = new bool[Properties.Settings.Default.universeW, Properties.Settings.Default.universeH];
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;

                    if (x < tempUni.GetLength(0) && y < tempUni.GetLength(1))
                    {
                        universe[x, y] = tempUni[x, y];
                    }
                }
            }

            Refresh();
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void nextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nextGen();
            panel1.Invalidate();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            optionsToolStripMenuItem_Click(sender, e);
        }
    }
}
