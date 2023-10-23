using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vhod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string name = "Liliya";
        string pas = "123456789";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == name && textBox2.Text == pas)
            {
                MessageBox.Show("Вярно име!");
                Form2 forma2 = new Form2();
                Form1 forma1 = new Form1();
              
                forma2.Show();
                forma1.Close();

            }
            else
            { 

                Form3 forma3 = new Form3();
                forma3.Show();
                MessageBox.Show("ГРЕШНО ИМЕ!");
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
