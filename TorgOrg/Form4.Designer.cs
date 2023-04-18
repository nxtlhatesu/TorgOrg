
namespace TorgOrg
{
    partial class Form4
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
            System.Windows.Forms.Label iD_TorgTochkaLabel;
            System.Windows.Forms.Label nameTorgTochkaLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label iD_TorgOrgLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label fIOzavedushegoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.torgOrgDataSet = new TorgOrg.TorgOrgDataSet();
            this.torgovaya_TochkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torgovaya_TochkaTableAdapter = new TorgOrg.TorgOrgDataSetTableAdapters.Torgovaya_TochkaTableAdapter();
            this.tableAdapterManager = new TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager();
            this.torgovaya_TochkaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.torgovaya_TochkaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TorgTochkaTextBox = new System.Windows.Forms.TextBox();
            this.nameTorgTochkaTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TorgOrgTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.fIOzavedushegoTextBox = new System.Windows.Forms.TextBox();
            iD_TorgTochkaLabel = new System.Windows.Forms.Label();
            nameTorgTochkaLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            iD_TorgOrgLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            fIOzavedushegoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torgovaya_TochkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torgovaya_TochkaBindingNavigator)).BeginInit();
            this.torgovaya_TochkaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TorgTochkaLabel
            // 
            iD_TorgTochkaLabel.AutoSize = true;
            iD_TorgTochkaLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TorgTochkaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            iD_TorgTochkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TorgTochkaLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_TorgTochkaLabel.Location = new System.Drawing.Point(249, 184);
            iD_TorgTochkaLabel.Name = "iD_TorgTochkaLabel";
            iD_TorgTochkaLabel.Size = new System.Drawing.Size(161, 20);
            iD_TorgTochkaLabel.TabIndex = 35;
            iD_TorgTochkaLabel.Text = "Код торговой точки";
            // 
            // nameTorgTochkaLabel
            // 
            nameTorgTochkaLabel.AutoSize = true;
            nameTorgTochkaLabel.BackColor = System.Drawing.Color.Transparent;
            nameTorgTochkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameTorgTochkaLabel.ForeColor = System.Drawing.Color.Yellow;
            nameTorgTochkaLabel.Location = new System.Drawing.Point(205, 258);
            nameTorgTochkaLabel.Name = "nameTorgTochkaLabel";
            nameTorgTochkaLabel.Size = new System.Drawing.Size(205, 20);
            nameTorgTochkaLabel.TabIndex = 36;
            nameTorgTochkaLabel.Text = "Название торговой точки";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = System.Drawing.Color.Transparent;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            typeLabel.ForeColor = System.Drawing.Color.Yellow;
            typeLabel.Location = new System.Drawing.Point(252, 294);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(158, 20);
            typeLabel.TabIndex = 37;
            typeLabel.Text = "Тип торговой точки";
            // 
            // iD_TorgOrgLabel
            // 
            iD_TorgOrgLabel.AutoSize = true;
            iD_TorgOrgLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TorgOrgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TorgOrgLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_TorgOrgLabel.Location = new System.Drawing.Point(197, 221);
            iD_TorgOrgLabel.Name = "iD_TorgOrgLabel";
            iD_TorgOrgLabel.Size = new System.Drawing.Size(213, 20);
            iD_TorgOrgLabel.TabIndex = 38;
            iD_TorgOrgLabel.Text = "Код торговой организации";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.ForeColor = System.Drawing.Color.Yellow;
            addressLabel.Location = new System.Drawing.Point(338, 334);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(57, 20);
            addressLabel.TabIndex = 39;
            addressLabel.Text = "Адрес";
            // 
            // fIOzavedushegoLabel
            // 
            fIOzavedushegoLabel.AutoSize = true;
            fIOzavedushegoLabel.BackColor = System.Drawing.Color.Transparent;
            fIOzavedushegoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIOzavedushegoLabel.ForeColor = System.Drawing.Color.Yellow;
            fIOzavedushegoLabel.Location = new System.Drawing.Point(252, 373);
            fIOzavedushegoLabel.Name = "fIOzavedushegoLabel";
            fIOzavedushegoLabel.Size = new System.Drawing.Size(145, 20);
            fIOzavedushegoLabel.TabIndex = 40;
            fIOzavedushegoLabel.Text = "ФИО Заведущего";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(367, 563);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 33);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить изменения";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(518, 498);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 32;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(401, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 33);
            this.button5.TabIndex = 31;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(634, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(518, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(401, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(290, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(395, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Торговые точки";
            // 
            // torgOrgDataSet
            // 
            this.torgOrgDataSet.DataSetName = "TorgOrgDataSet";
            this.torgOrgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torgovaya_TochkaBindingSource
            // 
            this.torgovaya_TochkaBindingSource.DataMember = "Torgovaya Tochka";
            this.torgovaya_TochkaBindingSource.DataSource = this.torgOrgDataSet;
            // 
            // torgovaya_TochkaTableAdapter
            // 
            this.torgovaya_TochkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderOfSuppliersTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.Torgovaya_TochkaTableAdapter = this.torgovaya_TochkaTableAdapter;
            this.tableAdapterManager.Trade_organizationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // torgovaya_TochkaBindingNavigator
            // 
            this.torgovaya_TochkaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.torgovaya_TochkaBindingNavigator.BindingSource = this.torgovaya_TochkaBindingSource;
            this.torgovaya_TochkaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.torgovaya_TochkaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.torgovaya_TochkaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.torgovaya_TochkaBindingNavigatorSaveItem});
            this.torgovaya_TochkaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.torgovaya_TochkaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.torgovaya_TochkaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.torgovaya_TochkaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.torgovaya_TochkaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.torgovaya_TochkaBindingNavigator.Name = "torgovaya_TochkaBindingNavigator";
            this.torgovaya_TochkaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.torgovaya_TochkaBindingNavigator.Size = new System.Drawing.Size(981, 25);
            this.torgovaya_TochkaBindingNavigator.TabIndex = 35;
            this.torgovaya_TochkaBindingNavigator.Text = "bindingNavigator1";
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
            // torgovaya_TochkaBindingNavigatorSaveItem
            // 
            this.torgovaya_TochkaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.torgovaya_TochkaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("torgovaya_TochkaBindingNavigatorSaveItem.Image")));
            this.torgovaya_TochkaBindingNavigatorSaveItem.Name = "torgovaya_TochkaBindingNavigatorSaveItem";
            this.torgovaya_TochkaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.torgovaya_TochkaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.torgovaya_TochkaBindingNavigatorSaveItem.Click += new System.EventHandler(this.torgovaya_TochkaBindingNavigatorSaveItem_Click);
            // 
            // iD_TorgTochkaTextBox
            // 
            this.iD_TorgTochkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "ID_TorgTochka", true));
            this.iD_TorgTochkaTextBox.Location = new System.Drawing.Point(416, 184);
            this.iD_TorgTochkaTextBox.Name = "iD_TorgTochkaTextBox";
            this.iD_TorgTochkaTextBox.Size = new System.Drawing.Size(206, 20);
            this.iD_TorgTochkaTextBox.TabIndex = 36;
            // 
            // nameTorgTochkaTextBox
            // 
            this.nameTorgTochkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "NameTorgTochka", true));
            this.nameTorgTochkaTextBox.Location = new System.Drawing.Point(416, 258);
            this.nameTorgTochkaTextBox.Name = "nameTorgTochkaTextBox";
            this.nameTorgTochkaTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTorgTochkaTextBox.TabIndex = 37;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Оптовая",
            "Розничная"});
            this.typeComboBox.Location = new System.Drawing.Point(416, 294);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(206, 21);
            this.typeComboBox.TabIndex = 38;
            // 
            // iD_TorgOrgTextBox
            // 
            this.iD_TorgOrgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "ID_TorgOrg", true));
            this.iD_TorgOrgTextBox.Location = new System.Drawing.Point(416, 221);
            this.iD_TorgOrgTextBox.Name = "iD_TorgOrgTextBox";
            this.iD_TorgOrgTextBox.Size = new System.Drawing.Size(206, 20);
            this.iD_TorgOrgTextBox.TabIndex = 39;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(416, 334);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(206, 20);
            this.addressTextBox.TabIndex = 40;
            // 
            // fIOzavedushegoTextBox
            // 
            this.fIOzavedushegoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.torgovaya_TochkaBindingSource, "FIOzavedushego", true));
            this.fIOzavedushegoTextBox.Location = new System.Drawing.Point(416, 373);
            this.fIOzavedushegoTextBox.Name = "fIOzavedushegoTextBox";
            this.fIOzavedushegoTextBox.Size = new System.Drawing.Size(206, 20);
            this.fIOzavedushegoTextBox.TabIndex = 41;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 636);
            this.Controls.Add(fIOzavedushegoLabel);
            this.Controls.Add(this.fIOzavedushegoTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(iD_TorgOrgLabel);
            this.Controls.Add(this.iD_TorgOrgTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(nameTorgTochkaLabel);
            this.Controls.Add(this.nameTorgTochkaTextBox);
            this.Controls.Add(iD_TorgTochkaLabel);
            this.Controls.Add(this.iD_TorgTochkaTextBox);
            this.Controls.Add(this.torgovaya_TochkaBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Торговая точка";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torgovaya_TochkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torgovaya_TochkaBindingNavigator)).EndInit();
            this.torgovaya_TochkaBindingNavigator.ResumeLayout(false);
            this.torgovaya_TochkaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private TorgOrgDataSet torgOrgDataSet;
        private System.Windows.Forms.BindingSource torgovaya_TochkaBindingSource;
        private TorgOrgDataSetTableAdapters.Torgovaya_TochkaTableAdapter torgovaya_TochkaTableAdapter;
        private TorgOrgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator torgovaya_TochkaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton torgovaya_TochkaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TorgTochkaTextBox;
        private System.Windows.Forms.TextBox nameTorgTochkaTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox iD_TorgOrgTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox fIOzavedushegoTextBox;
    }
}