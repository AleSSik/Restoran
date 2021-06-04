using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("admin") & textBox2.Text.Contains("123"))
            {
                Hide();
                Администратор form = new Администратор();
                form.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены не верно!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
