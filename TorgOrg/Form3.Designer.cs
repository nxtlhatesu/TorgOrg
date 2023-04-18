
namespace TorgOrg
{
    partial class Form3
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
            System.Windows.Forms.Label iD_OrderLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label iD_SupplierLabel;
            System.Windows.Forms.Label iD_TorgTochkaLabel;
            System.Windows.Forms.Label date_of_orderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.torgOrgDataSet = new TorgOrg.TorgOrgDataSet();
            this.orderOfSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderOfSuppliersTableAdapter = new TorgOrg.TorgOrgDataSetTableAdapters.OrderOfSuppliersTableAdapter();
            this.tableAdapterManager = new TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager();
            this.orderOfSuppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderOfSuppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_OrderTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.iD_SupplierTextBox = new System.Windows.Forms.TextBox();
            this.iD_TorgTochkaTextBox = new System.Windows.Forms.TextBox();
            this.date_of_orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            iD_OrderLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            iD_SupplierLabel = new System.Windows.Forms.Label();
            iD_TorgTochkaLabel = new System.Windows.Forms.Label();
            date_of_orderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOfSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOfSuppliersBindingNavigator)).BeginInit();
            this.orderOfSuppliersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_OrderLabel
            // 
            iD_OrderLabel.AutoSize = true;
            iD_OrderLabel.BackColor = System.Drawing.Color.Transparent;
            iD_OrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            iD_OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_OrderLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_OrderLabel.Location = new System.Drawing.Point(296, 152);
            iD_OrderLabel.Name = "iD_OrderLabel";
            iD_OrderLabel.Size = new System.Drawing.Size(94, 20);
            iD_OrderLabel.TabIndex = 1;
            iD_OrderLabel.Text = "Код заказа";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.ForeColor = System.Drawing.Color.Yellow;
            priceLabel.Location = new System.Drawing.Point(333, 307);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Цена";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = System.Drawing.Color.Transparent;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantityLabel.ForeColor = System.Drawing.Color.Yellow;
            quantityLabel.Location = new System.Drawing.Point(290, 344);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(100, 20);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Количество";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.BackColor = System.Drawing.Color.Transparent;
            product_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_NameLabel.ForeColor = System.Drawing.Color.Yellow;
            product_NameLabel.Location = new System.Drawing.Point(242, 379);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(158, 20);
            product_NameLabel.TabIndex = 7;
            product_NameLabel.Text = "Название продукта";
            // 
            // iD_SupplierLabel
            // 
            iD_SupplierLabel.AutoSize = true;
            iD_SupplierLabel.BackColor = System.Drawing.Color.Transparent;
            iD_SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_SupplierLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_SupplierLabel.Location = new System.Drawing.Point(265, 194);
            iD_SupplierLabel.Name = "iD_SupplierLabel";
            iD_SupplierLabel.Size = new System.Drawing.Size(135, 20);
            iD_SupplierLabel.TabIndex = 9;
            iD_SupplierLabel.Text = "Код поставщика";
            // 
            // iD_TorgTochkaLabel
            // 
            iD_TorgTochkaLabel.AutoSize = true;
            iD_TorgTochkaLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TorgTochkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TorgTochkaLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_TorgTochkaLabel.Location = new System.Drawing.Point(239, 228);
            iD_TorgTochkaLabel.Name = "iD_TorgTochkaLabel";
            iD_TorgTochkaLabel.Size = new System.Drawing.Size(161, 20);
            iD_TorgTochkaLabel.TabIndex = 11;
            iD_TorgTochkaLabel.Text = "Код торговой точки";
            // 
            // date_of_orderLabel
            // 
            date_of_orderLabel.AutoSize = true;
            date_of_orderLabel.BackColor = System.Drawing.Color.Transparent;
            date_of_orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_orderLabel.ForeColor = System.Drawing.Color.Yellow;
            date_of_orderLabel.Location = new System.Drawing.Point(287, 275);
            date_of_orderLabel.Name = "date_of_orderLabel";
            date_of_orderLabel.Size = new System.Drawing.Size(103, 20);
            date_of_orderLabel.TabIndex = 13;
            date_of_orderLabel.Text = "Дата заказа";
            // 
            // torgOrgDataSet
            // 
            this.torgOrgDataSet.DataSetName = "TorgOrgDataSet";
            this.torgOrgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderOfSuppliersBindingSource
            // 
            this.orderOfSuppliersBindingSource.DataMember = "OrderOfSuppliers";
            this.orderOfSuppliersBindingSource.DataSource = this.torgOrgDataSet;
            // 
            // orderOfSuppliersTableAdapter
            // 
            this.orderOfSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderOfSuppliersTableAdapter = this.orderOfSuppliersTableAdapter;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.Torgovaya_TochkaTableAdapter = null;
            this.tableAdapterManager.Trade_organizationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderOfSuppliersBindingNavigator
            // 
            this.orderOfSuppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderOfSuppliersBindingNavigator.BindingSource = this.orderOfSuppliersBindingSource;
            this.orderOfSuppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderOfSuppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderOfSuppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderOfSuppliersBindingNavigatorSaveItem});
            this.orderOfSuppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderOfSuppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderOfSuppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderOfSuppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderOfSuppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderOfSuppliersBindingNavigator.Name = "orderOfSuppliersBindingNavigator";
            this.orderOfSuppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderOfSuppliersBindingNavigator.Size = new System.Drawing.Size(981, 25);
            this.orderOfSuppliersBindingNavigator.TabIndex = 0;
            this.orderOfSuppliersBindingNavigator.Text = "bindingNavigator1";
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
            // orderOfSuppliersBindingNavigatorSaveItem
            // 
            this.orderOfSuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderOfSuppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderOfSuppliersBindingNavigatorSaveItem.Image")));
            this.orderOfSuppliersBindingNavigatorSaveItem.Name = "orderOfSuppliersBindingNavigatorSaveItem";
            this.orderOfSuppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderOfSuppliersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderOfSuppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderOfSuppliersBindingNavigatorSaveItem_Click);
            // 
            // iD_OrderTextBox
            // 
            this.iD_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "ID_Order", true));
            this.iD_OrderTextBox.Location = new System.Drawing.Point(406, 152);
            this.iD_OrderTextBox.Name = "iD_OrderTextBox";
            this.iD_OrderTextBox.Size = new System.Drawing.Size(237, 20);
            this.iD_OrderTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(406, 309);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(237, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(406, 344);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(237, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "Product Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(406, 379);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(237, 20);
            this.product_NameTextBox.TabIndex = 8;
            // 
            // iD_SupplierTextBox
            // 
            this.iD_SupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "ID_Supplier", true));
            this.iD_SupplierTextBox.Location = new System.Drawing.Point(406, 194);
            this.iD_SupplierTextBox.Name = "iD_SupplierTextBox";
            this.iD_SupplierTextBox.Size = new System.Drawing.Size(237, 20);
            this.iD_SupplierTextBox.TabIndex = 10;
            // 
            // iD_TorgTochkaTextBox
            // 
            this.iD_TorgTochkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderOfSuppliersBindingSource, "ID_TorgTochka", true));
            this.iD_TorgTochkaTextBox.Location = new System.Drawing.Point(406, 230);
            this.iD_TorgTochkaTextBox.Name = "iD_TorgTochkaTextBox";
            this.iD_TorgTochkaTextBox.Size = new System.Drawing.Size(237, 20);
            this.iD_TorgTochkaTextBox.TabIndex = 12;
            // 
            // date_of_orderDateTimePicker
            // 
            this.date_of_orderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderOfSuppliersBindingSource, "Date of order", true));
            this.date_of_orderDateTimePicker.Location = new System.Drawing.Point(406, 274);
            this.date_of_orderDateTimePicker.Name = "date_of_orderDateTimePicker";
            this.date_of_orderDateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.date_of_orderDateTimePicker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(366, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Заказы поставщикам";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(388, 574);
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
            this.button6.Location = new System.Drawing.Point(534, 498);
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
            this.button5.Location = new System.Drawing.Point(417, 498);
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
            this.button4.Location = new System.Drawing.Point(650, 445);
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
            this.button3.Location = new System.Drawing.Point(534, 445);
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
            this.button2.Location = new System.Drawing.Point(417, 445);
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
            this.button1.Location = new System.Drawing.Point(306, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Yellow;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(868, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 46);
            this.button8.TabIndex = 34;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 636);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(date_of_orderLabel);
            this.Controls.Add(this.date_of_orderDateTimePicker);
            this.Controls.Add(iD_TorgTochkaLabel);
            this.Controls.Add(this.iD_TorgTochkaTextBox);
            this.Controls.Add(iD_SupplierLabel);
            this.Controls.Add(this.iD_SupplierTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(iD_OrderLabel);
            this.Controls.Add(this.iD_OrderTextBox);
            this.Controls.Add(this.orderOfSuppliersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Заказы поставщикам";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOfSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderOfSuppliersBindingNavigator)).EndInit();
            this.orderOfSuppliersBindingNavigator.ResumeLayout(false);
            this.orderOfSuppliersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TorgOrgDataSet torgOrgDataSet;
        private System.Windows.Forms.BindingSource orderOfSuppliersBindingSource;
        private TorgOrgDataSetTableAdapters.OrderOfSuppliersTableAdapter orderOfSuppliersTableAdapter;
        private TorgOrgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderOfSuppliersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderOfSuppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_OrderTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox iD_SupplierTextBox;
        private System.Windows.Forms.TextBox iD_TorgTochkaTextBox;
        private System.Windows.Forms.DateTimePicker date_of_orderDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
    }
}