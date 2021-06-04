﻿using System;
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
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void менюBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.менюBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ресторанDataSet);

        }

        private void Меню_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet.Меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.ресторанDataSet.Меню);

        }
    }
}
