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
    public partial class Сотрудники_админ : Form
    {
        public Сотрудники_админ()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            foreach (DataGridViewRow item in this.сотрудникиDataGridView.SelectedRows)
            {
                if (сотрудникиDataGridView.SelectedRows == null)
                {
                    MessageBox.Show("Заполните");
                }
            }
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet2);
           
           
        }

        private void Сотрудники_админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet2.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.ресторанDataSet2.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = "Должность =\'" + должностьTextBox.Text + "\'";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данные?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.сотрудникиDataGridView.SelectedRows)
                {
                    сотрудникиDataGridView.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
