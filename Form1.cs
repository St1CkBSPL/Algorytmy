using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int> {2,1,5,9,7,4,6 };
            BubbleSort(lista);
            MessageBox.Show("Posortowana lista babelkowo: " + string.Join(", ", lista));

        }

        private void BubbleSort(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int ilość = (int)numericUpDown.Value;
            listBoxLiczby.Items.Clear();
            List<int> liczby = new List<int>();
            Random random = new Random();

            for (int i = 0; i < ilość; i++)
            {
                liczby.Add(random.Next(1, 100)); // Generuje losowe liczby od 1 do 100
            }

            foreach (int liczba in liczby)
            {
                listBoxLiczby.Items.Add(liczba);
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            List<int> lista = listBoxLiczby.Items.Cast<int>().ToList();

            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }

            listBoxLiczby.Items.Clear();
            foreach (int liczba in lista)
            {
                listBoxLiczby.Items.Add(liczba);
            }
        }

        private void btnInsertSort_Click(object sender, EventArgs e)
        {
            List<int> lista = listBoxLiczby.Items.Cast<int>().ToList();

            for (int i = 1; i < lista.Count; i++)
            {
                int key = lista[i];
                int j = i - 1;

                while (j >= 0 && lista[j] > key)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = key;
            }

            listBoxLiczby.Items.Clear();
            foreach (int liczba in lista)
            {
                listBoxLiczby.Items.Add(liczba);
            }
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            List<int> lista = listBoxLiczby.Items.Cast<int>().ToList();
            lista = MergeSort(lista);

            listBoxLiczby.Items.Clear();
            foreach (int liczba in lista)
            {
                listBoxLiczby.Items.Add(liczba);
            }
        }

        private List<int> MergeSort(List<int> lista)
        {
            if (lista.Count <= 1)
                return lista;

            int mid = lista.Count / 2;
            List<int> left = lista.GetRange(0, mid);
            List<int> right = lista.GetRange(mid, lista.Count - mid);

            return Merge(MergeSort(left), MergeSort(right));
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            List<int> lista = listBoxLiczby.Items.Cast<int>().ToList();

            for (int i = 0; i < lista.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[minIndex])
                        minIndex = j;
                }

                int temp = lista[minIndex];
                lista[minIndex] = lista[i];
                lista[i] = temp;
            }

         
            listBoxLiczby.Items.Clear();
            foreach (int liczba in lista)
            {
                listBoxLiczby.Items.Add(liczba);
            }
        }

    }
}
