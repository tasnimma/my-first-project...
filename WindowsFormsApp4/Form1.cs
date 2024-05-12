using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool t = true;
        int t_count = 0;
        static string name1, name2;
        private void btns_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (t)
                b.Text = "X";
            else
                b.Text = "O";
            t = !t;
            b.Enabled = false;
            t_count++;
            checkwinner();
        }
        private void checkwinner()
        {
            bool i = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                i = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {
                i = true;
            }



            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                i = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!c3.Enabled))
            {
                i = true;
            }



            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
            {
                i = true;
            }


            if (i)
            {
                string s;
                if (t)
                {
                    int a = Convert.ToInt32(O.Text);
                    a++;
                    O.Text = a.ToString();
                    s = player2.Text;
                    enabledbuttons();
                }
                else
                {
                    int a = Convert.ToInt32(X.Text);
                    a++;
                    X.Text = a.ToString();
                    s = player1.Text;
                    enabledbuttons();
                }
                MessageBox.Show(s + "win!");
                t_count = 0;
            }
            if (t_count == 9)
            {
                MessageBox.Show("draw");
                t_count = 0;
                enabledbuttons();
                int a = Convert.ToInt32(d.Text);
                a++;
                d.Text = a.ToString();

            }
        }
        private void enabledbuttons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch
                {

                }


            }
        }

        private void c3_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((t) && (b.Enabled))
                b.Text = "X";
            if ((t == false) && (b.Enabled))
                b.Text = "O";

        }

        private void c3_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enabledbuttons();
            O.Text = "0";
            d.Text = "0";
            X.Text = "0";
            t_count = 0;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void player2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();

            player1.Text = name1;
            player2.Text = name2;
        }

        public static void playernames(string n1, string n2)
        {
            name1 = n1;
            name2 = n2;

        }






    }
}






