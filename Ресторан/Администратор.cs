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
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Меню_админ form = new Меню_админ();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Услуги_адм form = new Услуги_адм();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказы_админ form = new Заказы_админ();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Сотрудники_админ form = new Сотрудники_админ();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Столики_админ form = new Столики_админ();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Счета_админ form = new Счета_админ();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Главная form = new Главная();
            form.Show();
        }
    }
}
