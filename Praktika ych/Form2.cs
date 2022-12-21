using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktika_ych
{
    public partial class Form2 : Form
    {
        private String form_mask;
        private String material;
        private String complexity;
        private String dop_upgrade;
        private String priceText;
        private double price;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void order_button_Click(object sender, EventArgs e)//Кнопка перехода в окно оформление заказа
        {
            if (comboBox1.SelectedIndex > -1 || comboBox2.SelectedIndex > -1 || comboBox3.SelectedIndex > -1 || comboBox4.SelectedIndex > -1)//проверка на выбор элемента ComboBox
            {
                form_mask = comboBox1.SelectedItem.ToString();
                material = comboBox3.SelectedItem.ToString();
                complexity = comboBox2.SelectedItem.ToString();
                dop_upgrade = comboBox4.SelectedItem.ToString();

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        price += 500;
                        break;
                    case 1:
                        price += 1000;
                        break;
                    case 2:
                        price += 1500;
                        break;
                }

                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        price += 1500;
                        break;
                    case 1:
                        price += 1000;
                        break;
                    case 2:
                        price += 200;
                        break;
                }

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        price += 500;
                        break;
                    case 1:
                        price += 1000;
                        break;
                    case 2:
                        price += 1500;
                        break;
                }

                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        price += 500;
                        break;
                    case 1:
                        price += 300;
                        break;
                    case 2:
                        price += 200;
                        break;
                    case 3:
                        price += 0;
                        break;
                }

                priceText = Convert.ToString(price);

                Form3 form3 = new Form3(form_mask, material, complexity, dop_upgrade, priceText);
                form3.Show();
                this.Close();
            }
            else if (comboBox1.SelectedIndex < 1 || comboBox2.SelectedIndex < 1 || comboBox3.SelectedIndex < 1 || comboBox4.SelectedIndex < 1)
            {
                MessageBox.Show("Выберите пожалуйста все составляющие", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void back_button_Click(object sender, EventArgs e)//Кнопка назад
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Calculation_Click(object sender, EventArgs e)//Кнопка подсчёта цены маски
        {
            if (comboBox1.SelectedIndex > -1 || comboBox2.SelectedIndex > -1 || comboBox3.SelectedIndex > -1 || comboBox4.SelectedIndex > -1)//проверка на выбор элемента ComboBox
            {
                double priceCalcul = 0;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        priceCalcul += 500;
                        break;
                    case 1:
                        priceCalcul += 1000;
                        break;
                    case 2:
                        priceCalcul += 1500;
                        break;
                }

                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        priceCalcul += 1500;
                        break;
                    case 1:
                        priceCalcul += 1000;
                        break;
                    case 2:
                        priceCalcul += 200;
                        break;
                }

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        priceCalcul += 500;
                        break;
                    case 1:
                        priceCalcul += 1000;
                        break;
                    case 2:
                        priceCalcul += 1500;
                        break;
                }

                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        priceCalcul += 500;
                        break;
                    case 1:
                        priceCalcul += 300;
                        break;
                    case 2:
                        priceCalcul += 200;
                        break;
                    case 3:
                        priceCalcul += 0;
                        break;
                }

                String priceCalculText = Convert.ToString(priceCalcul);

                textBox1.Text = priceCalculText;
            }
            else if (comboBox1.SelectedIndex < 1 || comboBox2.SelectedIndex < 1 || comboBox3.SelectedIndex < 1 || comboBox4.SelectedIndex < 1)
            {
                MessageBox.Show("Выберите пожалуйста все составляющие", "Ошибка", MessageBoxButtons.OK);
            }
        }

    }
}
