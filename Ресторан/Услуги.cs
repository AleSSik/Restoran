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
    public partial class Услуги : Form
    {
        public Услуги()
        {
            InitializeComponent();
        }

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet);

        }

        private void Услуги_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.ресторанDataSet.Услуги);

        }
    }
}
