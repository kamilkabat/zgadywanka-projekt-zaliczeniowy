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
    public partial class Form2 : Form
    {
        public Form2(Gra g)
        {
            InitializeComponent();
            if (g != null)
            {
                IReadOnlyList<ModelGry.Gra.Ruch> historyRows = g.Historia;
                int index = 1;
                foreach (var historyRow in historyRows)
                {
                    dataGridView1.Rows.Add(index++, historyRow.propozycja, historyRow.odpowiedz, historyRow.kiedy);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
