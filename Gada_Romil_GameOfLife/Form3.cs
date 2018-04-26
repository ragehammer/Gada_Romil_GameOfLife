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
    public partial class Form3 : Form
    {
        public Color[] colors = new Color[3];
        public int time = 1;
        public int cellsWide = 1;
        public int cellsHigh = 1;
        public int mode = 0;

        public Form3()
        {
            InitializeComponent();


            Form1 asdf = Application.OpenForms["Form1"] as Form1;
            colors[0] = asdf.gridColor;
            colors[1] = asdf.BackColor;
            colors[2] = asdf.cellColor;

            button3.BackColor = colors[0];
            button4.BackColor = colors[1];
            button5.BackColor = colors[2];

            numericUpDown1.Value = asdf.timer.Interval;
            numericUpDown2.Value = Form1.universe.GetLength(0);
            numericUpDown3.Value = Form1.universe.GetLength(1);

            if (asdf.mode == 1)
            {
                mode = 1;
                radioButton1.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = button3.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                colors[0] = dlg.Color;
            }

            button3.BackColor = colors[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = button4.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                colors[1] = dlg.Color;
            }

            button4.BackColor = colors[1];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = button5.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                colors[2] = dlg.Color;
            }

            button5.BackColor = colors[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = (int)numericUpDown1.Value;
            cellsWide = (int)numericUpDown2.Value;
            cellsHigh = (int)numericUpDown3.Value;
            if (radioButton2.Checked)
                mode = 0;
            else
                mode = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


