using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esEvent1
{
    public partial class Form1 : Form
    {
        private int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GestisciErrore(object sender, System.EventArgs e)
        {
            MessageBox.Show("Errore: Età non numerica");
        }


        public event EventHandler Errore;

        private void button1_Click(object sender, EventArgs e)
        {
            EventHandler evento = Errore;

            evento += GestisciErrore;

            if(int.TryParse(tbEta.Text, out num) != true)
            {
                evento?.Invoke(sender, e);
            }
        }
    }
}
