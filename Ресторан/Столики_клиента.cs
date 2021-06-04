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
    public partial class Столики_клиента : Form
    {
        public Столики_клиента()
        {
            InitializeComponent();
        }

        private void столикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.столикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet);

        }

        private void Столики_клиента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.ресторанDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.ресторанDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.ресторанDataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Столики". При необходимости она может быть перемещена или удалена.
            this.столикиTableAdapter.Fill(this.ресторанDataSet.Столики);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Клиент form = new Клиент();
            form.Show();
        }
    }
}
