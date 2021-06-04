
namespace Ресторан
{
    partial class Столики_клиента
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label дата_бронированияLabel;
            System.Windows.Forms.Label время_бронированияLabel;
            System.Windows.Forms.Label количество_местLabel1;
            System.Windows.Forms.Label ___СтоликаLabel;
            System.Windows.Forms.Label фИО_клиентаLabel;
            this.дата_бронированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.время_бронированияTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.количество_местComboBox = new System.Windows.Forms.ComboBox();
            this.___СтоликаComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.столикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ресторанDataSet = new Ресторан.РесторанDataSet();
            this.столикиTableAdapter = new Ресторан.РесторанDataSetTableAdapters.СтоликиTableAdapter();
            this.tableAdapterManager = new Ресторан.РесторанDataSetTableAdapters.TableAdapterManager();
            this.фИО_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оплатаTableAdapter = new Ресторан.РесторанDataSetTableAdapters.ОплатаTableAdapter();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new Ресторан.РесторанDataSetTableAdapters.УслугиTableAdapter();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Ресторан.РесторанDataSetTableAdapters.ЗаказTableAdapter();
            дата_бронированияLabel = new System.Windows.Forms.Label();
            время_бронированияLabel = new System.Windows.Forms.Label();
            количество_местLabel1 = new System.Windows.Forms.Label();
            ___СтоликаLabel = new System.Windows.Forms.Label();
            фИО_клиентаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.столикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // дата_бронированияLabel
            // 
            дата_бронированияLabel.AutoSize = true;
            дата_бронированияLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_бронированияLabel.Location = new System.Drawing.Point(111, 261);
            дата_бронированияLabel.Name = "дата_бронированияLabel";
            дата_бронированияLabel.Size = new System.Drawing.Size(171, 19);
            дата_бронированияLabel.TabIndex = 5;
            дата_бронированияLabel.Text = "Дата бронирования:";
            // 
            // время_бронированияLabel
            // 
            время_бронированияLabel.AutoSize = true;
            время_бронированияLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            время_бронированияLabel.Location = new System.Drawing.Point(111, 299);
            время_бронированияLabel.Name = "время_бронированияLabel";
            время_бронированияLabel.Size = new System.Drawing.Size(184, 19);
            время_бронированияLabel.TabIndex = 7;
            время_бронированияLabel.Text = "Время бронирования:";
            // 
            // количество_местLabel1
            // 
            количество_местLabel1.AutoSize = true;
            количество_местLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количество_местLabel1.Location = new System.Drawing.Point(128, 224);
            количество_местLabel1.Name = "количество_местLabel1";
            количество_местLabel1.Size = new System.Drawing.Size(146, 19);
            количество_местLabel1.TabIndex = 10;
            количество_местLabel1.Text = "Количество мест:";
            // 
            // ___СтоликаLabel
            // 
            ___СтоликаLabel.AutoSize = true;
            ___СтоликаLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ___СтоликаLabel.Location = new System.Drawing.Point(146, 180);
            ___СтоликаLabel.Name = "___СтоликаLabel";
            ___СтоликаLabel.Size = new System.Drawing.Size(101, 19);
            ___СтоликаLabel.TabIndex = 11;
            ___СтоликаLabel.Text = "№ Столика:";
            // 
            // дата_бронированияDateTimePicker
            // 
            this.дата_бронированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.столикиBindingSource, "Дата_бронирования", true));
            this.дата_бронированияDateTimePicker.Location = new System.Drawing.Point(316, 258);
            this.дата_бронированияDateTimePicker.Name = "дата_бронированияDateTimePicker";
            this.дата_бронированияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_бронированияDateTimePicker.TabIndex = 6;
            // 
            // время_бронированияTextBox
            // 
            this.время_бронированияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.столикиBindingSource, "Время_бронирования", true));
            this.время_бронированияTextBox.Location = new System.Drawing.Point(316, 299);
            this.время_бронированияTextBox.Name = "время_бронированияTextBox";
            this.время_бронированияTextBox.Size = new System.Drawing.Size(100, 22);
            this.время_бронированияTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Location = new System.Drawing.Point(498, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // количество_местComboBox
            // 
            this.количество_местComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.столикиBindingSource, "Количество_мест", true));
            this.количество_местComboBox.FormattingEnabled = true;
            this.количество_местComboBox.Location = new System.Drawing.Point(316, 219);
            this.количество_местComboBox.Name = "количество_местComboBox";
            this.количество_местComboBox.Size = new System.Drawing.Size(121, 24);
            this.количество_местComboBox.TabIndex = 11;
            // 
            // ___СтоликаComboBox
            // 
            this.___СтоликаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.столикиBindingSource, "№ Столика", true));
            this.___СтоликаComboBox.FormattingEnabled = true;
            this.___СтоликаComboBox.Location = new System.Drawing.Point(316, 175);
            this.___СтоликаComboBox.Name = "___СтоликаComboBox";
            this.___СтоликаComboBox.Size = new System.Drawing.Size(121, 24);
            this.___СтоликаComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 92);
            this.label1.TabIndex = 13;
            this.label1.Text = "     Для бронирования столика введите нужную информацию и после вам позвонит адми" +
    "нистратор согласовать вашу бронь.";
            // 
            // столикиBindingSource
            // 
            this.столикиBindingSource.DataMember = "Столики";
            this.столикиBindingSource.DataSource = this.ресторанDataSet;
            // 
            // ресторанDataSet
            // 
            this.ресторанDataSet.DataSetName = "РесторанDataSet";
            this.ресторанDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // столикиTableAdapter
            // 
            this.столикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Ресторан.РесторанDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.МенюTableAdapter = null;
            this.tableAdapterManager.ОплатаTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтоликиTableAdapter = this.столикиTableAdapter;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // фИО_клиентаLabel
            // 
            фИО_клиентаLabel.AutoSize = true;
            фИО_клиентаLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИО_клиентаLabel.Location = new System.Drawing.Point(146, 140);
            фИО_клиентаLabel.Name = "фИО_клиентаLabel";
            фИО_клиентаLabel.Size = new System.Drawing.Size(119, 19);
            фИО_клиентаLabel.TabIndex = 13;
            фИО_клиентаLabel.Text = "ФИО клиента:";
            // 
            // фИО_клиентаTextBox
            // 
            this.фИО_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.столикиBindingSource, "ФИО_клиента", true));
            this.фИО_клиентаTextBox.Location = new System.Drawing.Point(316, 139);
            this.фИО_клиентаTextBox.Name = "фИО_клиентаTextBox";
            this.фИО_клиентаTextBox.Size = new System.Drawing.Size(355, 22);
            this.фИО_клиентаTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Location = new System.Drawing.Point(689, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // оплатаBindingSource
            // 
            this.оплатаBindingSource.DataMember = "Оплата";
            this.оплатаBindingSource.DataSource = this.ресторанDataSet;
            // 
            // оплатаTableAdapter
            // 
            this.оплатаTableAdapter.ClearBeforeFill = true;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.ресторанDataSet;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.ресторанDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // Столики_клиента
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(814, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(фИО_клиентаLabel);
            this.Controls.Add(this.фИО_клиентаTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(___СтоликаLabel);
            this.Controls.Add(this.___СтоликаComboBox);
            this.Controls.Add(количество_местLabel1);
            this.Controls.Add(this.количество_местComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(время_бронированияLabel);
            this.Controls.Add(this.время_бронированияTextBox);
            this.Controls.Add(дата_бронированияLabel);
            this.Controls.Add(this.дата_бронированияDateTimePicker);
            this.Name = "Столики_клиента";
            this.Text = "Столики_клиента";
            this.Load += new System.EventHandler(this.Столики_клиента_Load);
            ((System.ComponentModel.ISupportInitialize)(this.столикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private РесторанDataSet ресторанDataSet;
        private System.Windows.Forms.BindingSource столикиBindingSource;
        private РесторанDataSetTableAdapters.СтоликиTableAdapter столикиTableAdapter;
        private РесторанDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker дата_бронированияDateTimePicker;
        private System.Windows.Forms.TextBox время_бронированияTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox количество_местComboBox;
        private System.Windows.Forms.ComboBox ___СтоликаComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox фИО_клиентаTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource оплатаBindingSource;
        private РесторанDataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private РесторанDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private РесторанDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
    }
}