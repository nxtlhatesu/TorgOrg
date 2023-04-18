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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sellersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "torgOrgDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.torgOrgDataSet.Sellers);

        }

        private void iD_ProdavecTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_ProdavecLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           sellersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveNext();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveLast();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellersBindingSource.AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sellersBindingSource.RemoveCurrent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.sellersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }
    }
}
