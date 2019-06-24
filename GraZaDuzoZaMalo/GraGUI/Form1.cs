using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBox_Losuj.Visible = true;
            button_NowaGra.Enabled = false;
            button_Przerwij.Enabled = false;

            groupBox1.Visible = false;
            groupBox_Podsumowanie.Visible = false;

            textBox_Od.Enabled = true;
            textBoxDo.Enabled = true;
            button_Losuj.Enabled = true;
            button_Sprawdz.Enabled = true;

            label1.Text = "";
            textBox_Od.Text = "1";
            textBoxDo.Text = "100";

            label2.Text = "0";
            seconds = 0;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            int a = int.Parse( textBox_Od.Text );
            int b = int.Parse( textBoxDo.Text );

            // utwórz grę
            g = new Gra(a, b);

            textBox_Od.Enabled = false;
            textBoxDo.Enabled = false;
            button_Losuj.Enabled = false;
            button_Przerwij.Enabled = true;

            // wyświetl kolejne elementy formularza
            groupBox1.Visible = true;
            timer1.Start();
        }

        private void button_Sprawdz_Click(object sender, EventArgs e)
        {
            int proposition = int.Parse(textBox_Propozycja.Text);
            Enum response = g.Ocena(proposition);

            if (response.ToString() == "ZaMalo")
            {
                label1.Text = "Za mało!";
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else if (response.ToString() == "ZaDuzo")
            {
                label1.Text = "Za dużo!";
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label1.Text = "Trafiłeś!";
                label1.ForeColor = System.Drawing.Color.Green;

                button_NowaGra.Enabled = true;
                button_Przerwij.Enabled = false;
                showEndGameElements();
            }
        }

        private void showEndGameElements()
        {
            timer1.Stop();

            label3.Text = seconds.ToString();
            label4.Text = g.LicznikRuchow.ToString();
            label5.Text = g.Wylosowana.ToString();

            groupBox_Podsumowanie.Visible = true;
            button_Sprawdz.Enabled = false;
        }

        private void groupBox_Losuj_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Od_TextChanged(object sender, EventArgs e)
        {

        }

        int seconds = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds++;
            label2.Text = seconds.ToString();
        }

        private void button_Przerwij_Click(object sender, EventArgs e)
        {
            showEndGameElements();
            button_NowaGra.Enabled = true;
            button_Przerwij.Enabled = false;
            button_Sprawdz.Enabled = false;
        }

        private void button_Historia_Click(object sender, EventArgs e)
        {
            var myForm = new Form2(g);
            myForm.Show();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            var myForm = new Form3();
            myForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
