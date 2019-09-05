using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Стоимость_аренды_автомобиля
{
    public partial class Form1 : Form
    {
        int timing, price;
        string autotype;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <= '9')||(e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            else
            {
               e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                timing = Convert.ToInt32(textBox1.Text);
                autotype = Convert.ToString(comboBox1.SelectedItem);
                switch(autotype)
                {
                    case "такси":
                        price = 500 * timing;
                        break;
                    case "микроавтобус":
                        price = 1000 * timing;
                        break;
                    case "автобус":
                        price = 1500 * timing;
                        break;
                }
                label3.Text = "Стоимость аренды составит: " + price + "рублей";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Укажите время аренды", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
