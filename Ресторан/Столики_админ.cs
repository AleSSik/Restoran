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
    public partial class Столики_админ : Form
    {
        public Столики_админ()
        {
            InitializeComponent();
        }

        private void столикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.столикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet2);

        }

        private void Столики_админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet2.Столики". При необходимости она может быть перемещена или удалена.
            this.столикиTableAdapter.Fill(this.ресторанDataSet2.Столики);

        }
    }
}
