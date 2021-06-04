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
    public partial class Заказы_админ : Form
    {
        public Заказы_админ()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet2);

        }

        private void Заказы_админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet2.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.ресторанDataSet2.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "№Заказа=\'" + textBox2.Text + "\'";
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "Дата_посещения =\'" + textBox1.Text + "\'";
            textBox1.Clear();
        }
    }
}
