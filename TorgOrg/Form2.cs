using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorgOrg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "torgOrgDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.torgOrgDataSet.Suppliers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.suppliersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);
        }
    }
}
