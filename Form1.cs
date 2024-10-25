using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_dom
{
    public partial class Form1 : Form
    {
        List Lista = new List();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int liczba))
            {
                Lista.AddFirst(liczba);
                MessageBox.Show($"Dodano {liczba} na początek listy");
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną liczbe");
            }
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int liczba))
            {
                Lista.AddLast(liczba);
                MessageBox.Show($"Dodano {liczba} na koniec listy");
            }
            else
            {
                MessageBox.Show("Wprowadz poprawną liczbe");
            }
        }

        private void WyswietlListe_Click(object sender, EventArgs e)
        {
            Liczby.Items.Clear();
            Node current = Lista.head;
            if (current == null)
            {
                MessageBox.Show("Lista jest pusta");
                return;
            }
            while (current != null)
            {
                Liczby.Items.Add(current.data);
                current = current.next;
            }
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            if(Lista.count == 0)
            {
                MessageBox.Show("Lista jest pusta");
            }
            else
            {
                Lista.RemoveLast();
                MessageBox.Show("Usunieto ostatni element z listy");
                WyswietlListe_Click(sender, e);
            }
        }

        private void RemoveFirst_Click(object sender, EventArgs e)
        {
            if (Lista.count == 0)
            {
                MessageBox.Show("Lista jest pusta");
            }
            else
            {
                Lista.RemoveFirst();
                MessageBox.Show("Usunieto pierwszy element z listy");
                WyswietlListe_Click(sender, e);
            }
        }
    }
}
