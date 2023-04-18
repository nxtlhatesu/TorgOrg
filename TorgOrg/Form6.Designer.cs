
namespace TorgOrg
{
    partial class Form6
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
            System.Windows.Forms.Label iD_TorgOrgLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label fIOdirectorLabel;
            System.Windows.Forms.Label nalogoviyNomerLabel;
            System.Windows.Forms.Label nameTorgOrgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.torgOrgDataSet = new TorgOrg.TorgOrgDataSet();
            this.trade_organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trade_organizationTableAdapter = new TorgOrg.TorgOrgDataSetTableAdapters.Trade_organizationTableAdapter();
            this.tableAdapterManager = new TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager();
            this.trade_organizationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trade_organizationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TorgOrgTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.fIOdirectorTextBox = new System.Windows.Forms.TextBox();
            this.nalogoviyNomerTextBox = new System.Windows.Forms.TextBox();
            this.nameTorgOrgTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_TorgOrgLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            fIOdirectorLabel = new System.Windows.Forms.Label();
            nalogoviyNomerLabel = new System.Windows.Forms.Label();
            nameTorgOrgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade_organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade_organizationBindingNavigator)).BeginInit();
            this.trade_organizationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TorgOrgLabel
            // 
            iD_TorgOrgLabel.AutoSize = true;
            iD_TorgOrgLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TorgOrgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TorgOrgLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_TorgOrgLabel.Location = new System.Drawing.Point(152, 183);
            iD_TorgOrgLabel.Name = "iD_TorgOrgLabel";
            iD_TorgOrgLabel.Size = new System.Drawing.Size(213, 20);
            iD_TorgOrgLabel.TabIndex = 36;
            iD_TorgOrgLabel.Text = "Код торговой организации";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.Color.Yellow;
            addressLabel.Location = new System.Drawing.Point(302, 223);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(57, 20);
            addressLabel.TabIndex = 37;
            addressLabel.Text = "Адрес";
            // 
            // fIOdirectorLabel
            // 
            fIOdirectorLabel.AutoSize = true;
            fIOdirectorLabel.BackColor = System.Drawing.Color.Transparent;
            fIOdirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIOdirectorLabel.ForeColor = System.Drawing.Color.Yellow;
            fIOdirectorLabel.Location = new System.Drawing.Point(225, 265);
            fIOdirectorLabel.Name = "fIOdirectorLabel";
            fIOdirectorLabel.Size = new System.Drawing.Size(134, 20);
            fIOdirectorLabel.TabIndex = 38;
            fIOdirectorLabel.Text = "ФИО Директора";
            // 
            // nalogoviyNomerLabel
            // 
            nalogoviyNomerLabel.AutoSize = true;
            nalogoviyNomerLabel.BackColor = System.Drawing.Color.Transparent;
            nalogoviyNomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nalogoviyNomerLabel.ForeColor = System.Drawing.Color.Yellow;
            nalogoviyNomerLabel.Location = new System.Drawing.Point(214, 301);
            nalogoviyNomerLabel.Name = "nalogoviyNomerLabel";
            nalogoviyNomerLabel.Size = new System.Drawing.Size(145, 20);
            nalogoviyNomerLabel.TabIndex = 39;
            nalogoviyNomerLabel.Text = "Налоговый номер";
            // 
            // nameTorgOrgLabel
            // 
            nameTorgOrgLabel.AutoSize = true;
            nameTorgOrgLabel.BackColor = System.Drawing.Color.Transparent;
            nameTorgOrgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameTorgOrgLabel.ForeColor = System.Drawing.Color.Yellow;
            nameTorgOrgLabel.Location = new System.Drawing.Point(108, 339);
            nameTorgOrgLabel.Name = "nameTorgOrgLabel";
            nameTorgOrgLabel.Size = new System.Drawing.Size(257, 20);
            nameTorgOrgLabel.TabIndex = 40;
            nameTorgOrgLabel.Text = "Название торговой организации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(234, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Работа с торговыми организациями";
            // 
            // torgOrgDataSet
            // 
            this.torgOrgDataSet.DataSetName = "TorgOrgDataSet";
            this.torgOrgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trade_organizationBindingSource
            // 
            this.trade_organizationBindingSource.DataMember = "Trade organization";
            this.trade_organizationBindingSource.DataSource = this.torgOrgDataSet;
            // 
            // trade_organizationTableAdapter
            // 
            this.trade_organizationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderOfSuppliersTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.Torgovaya_TochkaTableAdapter = null;
            this.tableAdapterManager.Trade_organizationTableAdapter = this.trade_organizationTableAdapter;
            this.tableAdapterManager.UpdateOrder = TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trade_organizationBindingNavigator
            // 
            this.trade_organizationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trade_organizationBindingNavigator.BindingSource = this.trade_organizationBindingSource;
            this.trade_organizationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trade_organizationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trade_organizationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.trade_organizationBindingNavigatorSaveItem});
            this.trade_organizationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trade_organizationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trade_organizationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trade_organizationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trade_organizationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trade_organizationBindingNavigator.Name = "trade_organizationBindingNavigator";
            this.trade_organizationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trade_organizationBindingNavigator.Size = new System.Drawing.Size(981, 25);
            this.trade_organizationBindingNavigator.TabIndex = 36;
            this.trade_organizationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // trade_organizationBindingNavigatorSaveItem
            // 
            this.trade_organizationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trade_organizationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trade_organizationBindingNavigatorSaveItem.Image")));
            this.trade_organizationBindingNavigatorSaveItem.Name = "trade_organizationBindingNavigatorSaveItem";
            this.trade_organizationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.trade_organizationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.trade_organizationBindingNavigatorSaveItem.Click += new System.EventHandler(this.trade_organizationBindingNavigatorSaveItem_Click);
            // 
            // iD_TorgOrgTextBox
            // 
            this.iD_TorgOrgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trade_organizationBindingSource, "ID_TorgOrg", true));
            this.iD_TorgOrgTextBox.Location = new System.Drawing.Point(371, 183);
            this.iD_TorgOrgTextBox.Name = "iD_TorgOrgTextBox";
            this.iD_TorgOrgTextBox.Size = new System.Drawing.Size(282, 20);
            this.iD_TorgOrgTextBox.TabIndex = 37;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trade_organizationBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(371, 223);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(282, 20);
            this.addressTextBox.TabIndex = 38;
            // 
            // fIOdirectorTextBox
            // 
            this.fIOdirectorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trade_organizationBindingSource, "FIOdirector", true));
            this.fIOdirectorTextBox.Location = new System.Drawing.Point(371, 265);
            this.fIOdirectorTextBox.Name = "fIOdirectorTextBox";
            this.fIOdirectorTextBox.Size = new System.Drawing.Size(282, 20);
            this.fIOdirectorTextBox.TabIndex = 39;
            // 
            // nalogoviyNomerTextBox
            // 
            this.nalogoviyNomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trade_organizationBindingSource, "NalogoviyNomer", true));
            this.nalogoviyNomerTextBox.Location = new System.Drawing.Point(371, 301);
            this.nalogoviyNomerTextBox.Name = "nalogoviyNomerTextBox";
            this.nalogoviyNomerTextBox.Size = new System.Drawing.Size(282, 20);
            this.nalogoviyNomerTextBox.TabIndex = 40;
            // 
            // nameTorgOrgTextBox
            // 
            this.nameTorgOrgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trade_organizationBindingSource, "NameTorgOrg", true));
            this.nameTorgOrgTextBox.Location = new System.Drawing.Point(371, 339);
            this.nameTorgOrgTextBox.Name = "nameTorgOrgTextBox";
            this.nameTorgOrgTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTorgOrgTextBox.TabIndex = 41;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(362, 544);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 33);
            this.button7.TabIndex = 48;
            this.button7.Text = "Сохранить изменения";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(513, 479);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 47;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(396, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 33);
            this.button5.TabIndex = 46;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(629, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 45;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(513, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 44;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(396, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 43;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(285, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 636);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameTorgOrgLabel);
            this.Controls.Add(this.nameTorgOrgTextBox);
            this.Controls.Add(nalogoviyNomerLabel);
            this.Controls.Add(this.nalogoviyNomerTextBox);
            this.Controls.Add(fIOdirectorLabel);
            this.Controls.Add(this.fIOdirectorTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(iD_TorgOrgLabel);
            this.Controls.Add(this.iD_TorgOrgTextBox);
            this.Controls.Add(this.trade_organizationBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Торговая организация";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade_organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade_organizationBindingNavigator)).EndInit();
            this.trade_organizationBindingNavigator.ResumeLayout(false);
            this.trade_organizationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TorgOrgDataSet torgOrgDataSet;
        private System.Windows.Forms.BindingSource trade_organizationBindingSource;
        private TorgOrgDataSetTableAdapters.Trade_organizationTableAdapter trade_organizationTableAdapter;
        private TorgOrgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator trade_organizationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton trade_organizationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TorgOrgTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox fIOdirectorTextBox;
        private System.Windows.Forms.TextBox nalogoviyNomerTextBox;
        private System.Windows.Forms.TextBox nameTorgOrgTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}