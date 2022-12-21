using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_ych
{
    

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)//Кнопка выхода
        {
            this.Close();
        }

        private void create_mask_button_Click(object sender, EventArgs e)//Кнопка создания маски
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void order_button1_Click(object sender, EventArgs e)//Кнопка оформления заказа 1
        {
            Form3 form3 = new Form3("Полная", "Папье маше", "Высокая", "Усиленое крепление", "3000");
            form3.Show();
            this.Hide();
        }

        private void order_button2_Click(object sender, EventArgs e)//Кнопка оформления заказа 2
        {
            Form3 form3 = new Form3("gg", "ss", "rr", "tt", "1500");
            form3.Show();
            this.Hide();
        }

        private void order_button3_Click(object sender, EventArgs e)//Кнопка оформления заказа 3
        {
            Form3 form3 = new Form3("gg", "ss", "rr", "tt", "1500");
            form3.Show();
            this.Hide();
        }

        private void order_button4_Click(object sender, EventArgs e)//Кнопка оформления заказа 4
        {
            Form3 form3 = new Form3("gg", "ss", "rr", "tt", "1500");
            form3.Show();
            this.Hide();
        }    

    }
}
