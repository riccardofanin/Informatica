using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esDelegate4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double Del(double num1, double num2);

        private void btnMex_Click(object sender, EventArgs e)
        {
        }

        public double Media(double num1, double num2) 
        {
            return (num1 + num2) / 2;
        }

        public double Max(double num1, double num2)
        {
            if(num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }            
        }

        public double Ipotenusa(double num1, double num2)
        {
            return Math.Sqrt((Math.Pow(num1, 2)+ (Math.Pow(num2, 2))));
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Del del1 = Media;
            MessageBox.Show("L'operazione di " + del1.Method.Name + " tra " + tbNum1.Text + " e " + tbNum2.Text + " risulta " + del1(Convert.ToDouble(tbNum1.Text), Convert.ToDouble(tbNum2.Text)));
        }

        private void btnMulticast_Click(object sender, EventArgs e)
        {
            Del del1 = Media;
            del1 += Max;
            del1 += Ipotenusa;

            foreach (Del item in del1.GetInvocationList())
            {
                MessageBox.Show("L'operazione di " + item.Method.Name + " tra " + tbNum1.Text + " e " + tbNum2.Text + " risulta " + item(Convert.ToDouble(tbNum1.Text), Convert.ToDouble(tbNum2.Text)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
