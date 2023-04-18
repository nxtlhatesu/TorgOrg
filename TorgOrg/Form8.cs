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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void orderOfSuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderOfSuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.torgOrgDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.orderOfSuppliersTableAdapter.Fill(this.torgOrgDataSet.OrderOfSuppliers);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn COL = new System.Windows.Forms.DataGridViewColumn();
 switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
                orderOfSuppliersDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                orderOfSuppliersDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.Filter = "NAME='" + comboBox1.Text + "'";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderOfSuppliersBindingSource.Filter = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < orderOfSuppliersDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < orderOfSuppliersDataGridView.RowCount - 1; j++)
                {
                    orderOfSuppliersDataGridView[i, j].Style.BackColor = Color.White;
                    orderOfSuppliersDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < orderOfSuppliersDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < orderOfSuppliersDataGridView.RowCount - 1; j++)
                {
                    if (orderOfSuppliersDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        orderOfSuppliersDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        orderOfSuppliersDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

