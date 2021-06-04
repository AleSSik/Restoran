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
    public partial class Меню_админ : Form
    {
        public Меню_админ()
        {
            InitializeComponent();
        }

        private void менюBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.менюBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet2);

        }

        private void Меню_админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet2.Меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.ресторанDataSet2.Меню);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            менюBindingSource.Filter = "Наименование =\'" + textBox1.Text + "\'";
            textBox1.Clear();
        }
    }
}
