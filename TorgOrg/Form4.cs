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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void torgovaya_TochkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.torgovaya_TochkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "torgOrgDataSet.Torgovaya_Tochka". При необходимости она может быть перемещена или удалена.
            this.torgovaya_TochkaTableAdapter.Fill(this.torgOrgDataSet.Torgovaya_Tochka);

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.MoveFirst();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            torgovaya_TochkaBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.torgovaya_TochkaBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);
        }
    }
}
