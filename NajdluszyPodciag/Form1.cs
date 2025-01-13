using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NajdluszyPodciag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sequence1 = textBox1.Text;
            string sequence2 = textBox2.Text;

            string nwpResult = FindNwp(sequence1, sequence2);
            textBox3.Text = "NWP: " + nwpResult;
        }

        private string FindNwp(string sequence1, string sequence2)
        {
            int dlugosc1 = sequence1.Length;
            int dlugosc2 = sequence2.Length;
            int[,] dot = new int[dlugosc1 + 1, dlugosc2 + 1];

            for (int i = 1; i <= dlugosc1; i++)
            {
                for (int j = 1; j <= dlugosc2; j++)
                {
                    if (sequence1[i - 1] == sequence2[j - 1])
                    {
                        dot[i, j] = dot[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dot[i, j] = Math.Max(dot[i - 1, j], dot[i, j - 1]);
                    }
                }
            }

            int index = dot[dlugosc1, dlugosc2];
            char[] nwp = new char[index];
            int x = dlugosc1, y = dlugosc2;


            while (x > 0 && y > 0)
            {
                if (sequence1[x - 1] == sequence2[y - 1])
                {
                    nwp[--index] = sequence1[x - 1];
                    x--;
                    y--;
                }
                else if (dot[x - 1, y] > dot[x, y - 1])
                {
                    x--;
                }
                else
                {
                    y--;
                }
            }
            return new string(nwp);
        }
    }
}
