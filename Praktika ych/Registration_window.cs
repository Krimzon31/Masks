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
    public partial class Registration_window : Form
    {
        private String form;
        private String material;
        private String complexity;
        private String dop_upgrade;
        private String price;

        public Registration_window(String form, String material, String complexity, String dop_upgrade, String price)
        {
            InitializeComponent();
            this.form = form;
            this.material = material;
            this.complexity = complexity;
            this.dop_upgrade = dop_upgrade;
            this.price = price;

        }

        private void registration_Click(object sender, EventArgs e)
        {
            String SNP = textBox1.Text;
            String PhoneNumber = textBox2.Text;
            String Email = textBox3.Text;

            if (SNP == "" || PhoneNumber == "" || Email == "") {
                MessageBox.Show("Заполните пожалуйста все поля",
                                "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter("D:\\Order\\Order.txt");
                    streamWriter.WriteLine("ФИО: " + SNP);
                    streamWriter.WriteLine("Номер телефона: " + PhoneNumber);
                    streamWriter.WriteLine("Электронная почта: " + Email);
                    streamWriter.WriteLine("Форма маски: " + form);
                    streamWriter.WriteLine("Материал: " + material);
                    streamWriter.WriteLine("Сложность дизайна (дитализация): " + complexity);
                    streamWriter.WriteLine("Дополнительные улучшения: " + dop_upgrade);
                    streamWriter.WriteLine("Цена: " + price);
                    streamWriter.Close();

                    MessageBox.Show("Ваш заказ был оформлен, вскоре с вами свяжется наш менеджер",
                                       "Успешно", MessageBoxButtons.OK);
                }
                catch (Exception x)
                {
                    Console.WriteLine("Exception: " + x.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }

            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Creation_wondow form = new Creation_wondow();
            form.Show();
        }

        private void back_main_Click(object sender, EventArgs e)
        {
            this.Close();
            Window_choose form1 = new Window_choose();
            form1.Show();
        }
    }
}
