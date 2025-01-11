using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Djikstry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graph graph;
        private int[] result;

        private void runButton_Click(object sender, EventArgs e)
        {
            graph = new Graph(5);
            graph.AddEdge(0, 1, 10);
            graph.AddEdge(0, 2, 3);
            graph.AddEdge(1, 2, 1);
            graph.AddEdge(1, 3, 2);
            graph.AddEdge(2, 3, 8);
            graph.AddEdge(3, 4, 7);

            result = graph.Dijkstra(0);
            MessageBox.Show("Algorytm został stworzony");
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (result == null)
            {
                resultLabel.Text = "Najpierw stwórz algorytm przyciskiem runButton!";
            }
            else
            {
                resultLabel.Text = "Najkrótszy dystans od Node 0:\n";
                for (int i = 0; i < result.Length; i++)
                {
                    resultLabel.Text += $"Do {i}: {result[i]}\n";
                }
            }
        }
    }
}
