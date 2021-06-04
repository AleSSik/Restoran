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
    public partial class Счета_админ : Form
    {
        public Счета_админ()
        {
            InitializeComponent();
        }

        private void оплатаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оплатаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet2);

        }

        private void Счета_админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet2.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.ресторанDataSet2.Оплата);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            оплатаBindingSource.Filter = "Код_оплаты =\'" + textBox1.Text + "\'";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            оплатаBindingSource.Filter = "Дата_оплаты =\'" + textBox2.Text + "\'";
            textBox2.Clear();
        }

    }
}
