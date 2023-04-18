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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void trade_organizationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trade_organizationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "torgOrgDataSet.Trade_organization". При необходимости она может быть перемещена или удалена.
            this.trade_organizationTableAdapter.Fill(this.torgOrgDataSet.Trade_organization);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trade_organizationBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.trade_organizationBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);
        }
    }
}
