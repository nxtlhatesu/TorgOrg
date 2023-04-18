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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void orderOfSuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderOfSuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "torgOrgDataSet.OrderOfSuppliers". При необходимости она может быть перемещена или удалена.
            this.orderOfSuppliersTableAdapter.Fill(this.torgOrgDataSet.OrderOfSuppliers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.orderOfSuppliersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 l = new Form8();
            l.Visible = true;
            this.Hide();
        }
    }
}
