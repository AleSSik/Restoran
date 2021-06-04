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
    public partial class Клиент : Form
    {
        public Клиент()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Главная form = new Главная();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Меню form = new Меню();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Услуги form = new Услуги();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Столики_клиента form = new Столики_клиента();
            form.Show();
        }
    }
    
}
