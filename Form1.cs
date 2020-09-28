using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {

        string name;
        public MainForm()
        {
            InitializeComponent();

           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            else
                return;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size,mines);
            f.Show();
           


        }

       

       
        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            name = UserBox.Text;   
        }

        private void gameCount(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Form f in Application.OpenForms)
            {
                if (f is Form2)
                {
                    count++;
                }
                textBox1.Text = count.ToString();

            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = col = 9;
            mines = 10;
            text = "Easy";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();

        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = col = 16;
            mines = 40;
            text = "Medium";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();

        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = 30;
            col = 16;
            mines = 99;
            text = "Expert";


            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            foreach (Form f in Application.OpenForms)
            {
                if (f is Form2)
                {
                    forms.Add(f);
                }
            }

                foreach(Form f in forms)
                {
                    f.Close();
                }
                
            
        }
    }
}
