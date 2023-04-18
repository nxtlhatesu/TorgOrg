
namespace TorgOrg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_ProdavecLabel;
            System.Windows.Forms.Label iD_TorgTochkaLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label residentialaddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.torgOrgDataSet = new TorgOrg.TorgOrgDataSet();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new TorgOrg.TorgOrgDataSetTableAdapters.SellersTableAdapter();
            this.tableAdapterManager = new TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager();
            this.sellersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sellersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ProdavecTextBox = new System.Windows.Forms.TextBox();
            this.iD_TorgTochkaTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.date_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.residentialaddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            iD_ProdavecLabel = new System.Windows.Forms.Label();
            iD_TorgTochkaLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            residentialaddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingNavigator)).BeginInit();
            this.sellersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ProdavecLabel
            // 
            iD_ProdavecLabel.AutoSize = true;
            iD_ProdavecLabel.BackColor = System.Drawing.Color.Transparent;
            iD_ProdavecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ProdavecLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_ProdavecLabel.Location = new System.Drawing.Point(295, 109);
            iD_ProdavecLabel.Name = "iD_ProdavecLabel";
            iD_ProdavecLabel.Size = new System.Drawing.Size(117, 20);
            iD_ProdavecLabel.TabIndex = 1;
            iD_ProdavecLabel.Text = "Код продавца";
            iD_ProdavecLabel.Click += new System.EventHandler(this.iD_ProdavecLabel_Click);
            // 
            // iD_TorgTochkaLabel
            // 
            iD_TorgTochkaLabel.AutoSize = true;
            iD_TorgTochkaLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TorgTochkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TorgTochkaLabel.ForeColor = System.Drawing.Color.Yellow;
            iD_TorgTochkaLabel.Location = new System.Drawing.Point(251, 145);
            iD_TorgTochkaLabel.Name = "iD_TorgTochkaLabel";
            iD_TorgTochkaLabel.Size = new System.Drawing.Size(161, 20);
            iD_TorgTochkaLabel.TabIndex = 3;
            iD_TorgTochkaLabel.Text = "Код Торговой точки";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.BackColor = System.Drawing.Color.Transparent;
            postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postLabel.ForeColor = System.Drawing.Color.Yellow;
            postLabel.Location = new System.Drawing.Point(295, 186);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(95, 20);
            postLabel.TabIndex = 5;
            postLabel.Text = "Должность";
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.BackColor = System.Drawing.Color.Transparent;
            date_of_birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_birthLabel.ForeColor = System.Drawing.Color.Yellow;
            date_of_birthLabel.Location = new System.Drawing.Point(283, 229);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(129, 20);
            date_of_birthLabel.TabIndex = 7;
            date_of_birthLabel.Text = "Дата Рождения";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.BackColor = System.Drawing.Color.Transparent;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sexLabel.ForeColor = System.Drawing.Color.Yellow;
            sexLabel.Location = new System.Drawing.Point(329, 274);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(40, 20);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Пол";
            // 
            // residentialaddressLabel
            // 
            residentialaddressLabel.AutoSize = true;
            residentialaddressLabel.BackColor = System.Drawing.Color.Transparent;
            residentialaddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            residentialaddressLabel.ForeColor = System.Drawing.Color.Yellow;
            residentialaddressLabel.Location = new System.Drawing.Point(259, 319);
            residentialaddressLabel.Name = "residentialaddressLabel";
            residentialaddressLabel.Size = new System.Drawing.Size(153, 20);
            residentialaddressLabel.TabIndex = 11;
            residentialaddressLabel.Text = "Адрес проживания";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityLabel.ForeColor = System.Drawing.Color.Yellow;
            cityLabel.Location = new System.Drawing.Point(329, 356);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(56, 20);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "Город";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.BackColor = System.Drawing.Color.Transparent;
            phone_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_NumberLabel.ForeColor = System.Drawing.Color.Yellow;
            phone_NumberLabel.Location = new System.Drawing.Point(270, 404);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(142, 20);
            phone_NumberLabel.TabIndex = 15;
            phone_NumberLabel.Text = "Номер телефона";
            // 
            // torgOrgDataSet
            // 
            this.torgOrgDataSet.DataSetName = "TorgOrgDataSet";
            this.torgOrgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.torgOrgDataSet;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderOfSuppliersTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = this.sellersTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.Torgovaya_TochkaTableAdapter = null;
            this.tableAdapterManager.Trade_organizationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TorgOrg.TorgOrgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sellersBindingNavigator
            // 
            this.sellersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sellersBindingNavigator.BindingSource = this.sellersBindingSource;
            this.sellersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sellersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sellersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sellersBindingNavigatorSaveItem});
            this.sellersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sellersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sellersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sellersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sellersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sellersBindingNavigator.Name = "sellersBindingNavigator";
            this.sellersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sellersBindingNavigator.Size = new System.Drawing.Size(981, 25);
            this.sellersBindingNavigator.TabIndex = 0;
            this.sellersBindingNavigator.Text = "bindingNavigator1";
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
            // sellersBindingNavigatorSaveItem
            // 
            this.sellersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sellersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sellersBindingNavigatorSaveItem.Image")));
            this.sellersBindingNavigatorSaveItem.Name = "sellersBindingNavigatorSaveItem";
            this.sellersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sellersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sellersBindingNavigatorSaveItem.Click += new System.EventHandler(this.sellersBindingNavigatorSaveItem_Click);
            // 
            // iD_ProdavecTextBox
            // 
            this.iD_ProdavecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "ID_Prodavec", true));
            this.iD_ProdavecTextBox.Location = new System.Drawing.Point(418, 111);
            this.iD_ProdavecTextBox.Name = "iD_ProdavecTextBox";
            this.iD_ProdavecTextBox.Size = new System.Drawing.Size(211, 20);
            this.iD_ProdavecTextBox.TabIndex = 2;
            this.iD_ProdavecTextBox.TextChanged += new System.EventHandler(this.iD_ProdavecTextBox_TextChanged);
            // 
            // iD_TorgTochkaTextBox
            // 
            this.iD_TorgTochkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "ID_TorgTochka", true));
            this.iD_TorgTochkaTextBox.Location = new System.Drawing.Point(418, 147);
            this.iD_TorgTochkaTextBox.Name = "iD_TorgTochkaTextBox";
            this.iD_TorgTochkaTextBox.Size = new System.Drawing.Size(211, 20);
            this.iD_TorgTochkaTextBox.TabIndex = 4;
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(418, 186);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(211, 20);
            this.postTextBox.TabIndex = 6;
            // 
            // date_of_birthDateTimePicker
            // 
            this.date_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sellersBindingSource, "Date of birth", true));
            this.date_of_birthDateTimePicker.Location = new System.Drawing.Point(418, 229);
            this.date_of_birthDateTimePicker.Name = "date_of_birthDateTimePicker";
            this.date_of_birthDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.date_of_birthDateTimePicker.TabIndex = 8;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexComboBox.Location = new System.Drawing.Point(418, 273);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(211, 21);
            this.sexComboBox.TabIndex = 10;
            // 
            // residentialaddressTextBox
            // 
            this.residentialaddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "Residentialaddress", true));
            this.residentialaddressTextBox.Location = new System.Drawing.Point(418, 319);
            this.residentialaddressTextBox.Name = "residentialaddressTextBox";
            this.residentialaddressTextBox.Size = new System.Drawing.Size(211, 20);
            this.residentialaddressTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(418, 356);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(211, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // phone_NumberMaskedTextBox
            // 
            this.phone_NumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellersBindingSource, "Phone Number", true));
            this.phone_NumberMaskedTextBox.Location = new System.Drawing.Point(418, 406);
            this.phone_NumberMaskedTextBox.Name = "phone_NumberMaskedTextBox";
            this.phone_NumberMaskedTextBox.Size = new System.Drawing.Size(211, 20);
            this.phone_NumberMaskedTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(368, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Добавление продавцов";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(285, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(399, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(521, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(643, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(399, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 33);
            this.button5.TabIndex = 22;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(521, 520);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 23;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(385, 591);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 33);
            this.button7.TabIndex = 24;
            this.button7.Text = "Сохранить изменения";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
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
            this.Controls.Add(this.label1);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberMaskedTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(residentialaddressLabel);
            this.Controls.Add(this.residentialaddressTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(this.date_of_birthDateTimePicker);
            this.Controls.Add(postLabel);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(iD_TorgTochkaLabel);
            this.Controls.Add(this.iD_TorgTochkaTextBox);
            this.Controls.Add(iD_ProdavecLabel);
            this.Controls.Add(this.iD_ProdavecTextBox);
            this.Controls.Add(this.sellersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Продавцы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.torgOrgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingNavigator)).EndInit();
            this.sellersBindingNavigator.ResumeLayout(false);
            this.sellersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TorgOrgDataSet torgOrgDataSet;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private TorgOrgDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private TorgOrgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sellersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sellersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ProdavecTextBox;
        private System.Windows.Forms.TextBox iD_TorgTochkaTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.DateTimePicker date_of_birthDateTimePicker;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox residentialaddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.MaskedTextBox phone_NumberMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

