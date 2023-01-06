using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var num1 = int.Parse(numero1.Text);
            var num2 = int.Parse(numero2.Text);
            var oClient = new MiSoap.Service1Client();
            var suma = oClient.GetSuma(num1, num2, 1);
            MessageBox.Show(suma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(numero1.Text);
            var num2 = int.Parse(numero2.Text);
            var oClient = new MiSoap.Service1Client();
            var suma = oClient.GetSuma(num1, num2, 2);
            MessageBox.Show(suma);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(numero1.Text);
            var num2 = int.Parse(numero2.Text);
            var oClient = new MiSoap.Service1Client();
            var suma = oClient.GetSuma(num1, num2, 3);
            MessageBox.Show(suma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(numero1.Text);
            var num2 = int.Parse(numero2.Text);
            var oClient = new MiSoap.Service1Client();
            var suma = oClient.GetSuma(num1, num2, 4);
            MessageBox.Show(suma);
        }
    }
}
