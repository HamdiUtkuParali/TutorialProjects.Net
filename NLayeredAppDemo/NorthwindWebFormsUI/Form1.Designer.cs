namespace NorthwindWebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategorySearch = new System.Windows.Forms.GroupBox();
            this.cbxCategorySearch = new System.Windows.Forms.ComboBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.gbxProductNameSearch = new System.Windows.Forms.GroupBox();
            this.tbxProductNameSearch = new System.Windows.Forms.TextBox();
            this.lblProductNameSearch = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.cbxCategoryDelete = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceDelete = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitDelete = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockDelete = new System.Windows.Forms.TextBox();
            this.tbxProductNameDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblQuantityPerUnitDelete = new System.Windows.Forms.Label();
            this.lblUnitsInStockDelete = new System.Windows.Forms.Label();
            this.lblUnitPriceDelete = new System.Windows.Forms.Label();
            this.lblCategoryDelete = new System.Windows.Forms.Label();
            this.lblProductNameDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategorySearch.SuspendLayout();
            this.gbxProductNameSearch.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 230);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategorySearch
            // 
            this.gbxCategorySearch.Controls.Add(this.cbxCategorySearch);
            this.gbxCategorySearch.Controls.Add(this.lblCategorySearch);
            this.gbxCategorySearch.Location = new System.Drawing.Point(6, 14);
            this.gbxCategorySearch.Name = "gbxCategorySearch";
            this.gbxCategorySearch.Size = new System.Drawing.Size(758, 77);
            this.gbxCategorySearch.TabIndex = 1;
            this.gbxCategorySearch.TabStop = false;
            this.gbxCategorySearch.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategorySearch
            // 
            this.cbxCategorySearch.FormattingEnabled = true;
            this.cbxCategorySearch.Location = new System.Drawing.Point(83, 29);
            this.cbxCategorySearch.Name = "cbxCategorySearch";
            this.cbxCategorySearch.Size = new System.Drawing.Size(163, 21);
            this.cbxCategorySearch.TabIndex = 1;
            this.cbxCategorySearch.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.Location = new System.Drawing.Point(6, 32);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(52, 13);
            this.lblCategorySearch.TabIndex = 0;
            this.lblCategorySearch.Text = "Kategori :";
            // 
            // gbxProductNameSearch
            // 
            this.gbxProductNameSearch.Controls.Add(this.tbxProductNameSearch);
            this.gbxProductNameSearch.Controls.Add(this.lblProductNameSearch);
            this.gbxProductNameSearch.Location = new System.Drawing.Point(3, 121);
            this.gbxProductNameSearch.Name = "gbxProductNameSearch";
            this.gbxProductNameSearch.Size = new System.Drawing.Size(761, 77);
            this.gbxProductNameSearch.TabIndex = 2;
            this.gbxProductNameSearch.TabStop = false;
            this.gbxProductNameSearch.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductNameSearch
            // 
            this.tbxProductNameSearch.Location = new System.Drawing.Point(83, 30);
            this.tbxProductNameSearch.Name = "tbxProductNameSearch";
            this.tbxProductNameSearch.Size = new System.Drawing.Size(163, 20);
            this.tbxProductNameSearch.TabIndex = 2;
            this.tbxProductNameSearch.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductNameSearch
            // 
            this.lblProductNameSearch.AutoSize = true;
            this.lblProductNameSearch.Location = new System.Drawing.Point(6, 33);
            this.lblProductNameSearch.Name = "lblProductNameSearch";
            this.lblProductNameSearch.Size = new System.Drawing.Size(54, 13);
            this.lblProductNameSearch.TabIndex = 1;
            this.lblProductNameSearch.Text = "Ürün Adı :";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.gbxAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxAdd.Location = new System.Drawing.Point(6, 14);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(755, 209);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(628, 41);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(108, 20);
            this.tbxUnitsInStockAdd.TabIndex = 13;
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(322, 91);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(118, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 12;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(322, 41);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(118, 20);
            this.tbxUnitPriceAdd.TabIndex = 11;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(64, 91);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(119, 21);
            this.cbxCategoryAdd.TabIndex = 10;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(287, 44);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceAdd.TabIndex = 9;
            this.lblUnitPriceAdd.Text = "Fiyat";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(257, 94);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 7;
            this.lblQuantityPerUnitAdd.Text = "Birim Adedi";
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(563, 44);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStockAdd.TabIndex = 5;
            this.lblUnitsInStockAdd.Text = "Stok Adedi";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(12, 94);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryAdd.TabIndex = 3;
            this.lblCategoryAdd.Text = "Kategori";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(10, 44);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameAdd.TabIndex = 1;
            this.lblProductNameAdd.Text = "Ürün Adı";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(64, 41);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(119, 20);
            this.tbxProductNameAdd.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 273);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 252);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxCategorySearch);
            this.tabPage1.Controls.Add(this.gbxProductNameSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ara";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbxUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 226);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(12, 12);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(742, 211);
            this.gbxUpdate.TabIndex = 0;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(62, 85);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryUpdate.TabIndex = 7;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(313, 40);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(121, 20);
            this.tbxUnitPriceUpdate.TabIndex = 6;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(313, 90);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(121, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 6;
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(615, 40);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(110, 20);
            this.tbxUnitsInStockUpdate.TabIndex = 6;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(62, 40);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(121, 20);
            this.tbxProductNameUpdate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(553, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(248, 93);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(550, 43);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStockUpdate.TabIndex = 3;
            this.lblUnitsInStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(277, 43);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(8, 88);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryUpdate.TabIndex = 1;
            this.lblCategoryUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(8, 43);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbxDelete);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(770, 226);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sil";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.cbxCategoryDelete);
            this.gbxDelete.Controls.Add(this.tbxUnitPriceDelete);
            this.gbxDelete.Controls.Add(this.tbxQuantityPerUnitDelete);
            this.gbxDelete.Controls.Add(this.tbxUnitsInStockDelete);
            this.gbxDelete.Controls.Add(this.tbxProductNameDelete);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Controls.Add(this.lblQuantityPerUnitDelete);
            this.gbxDelete.Controls.Add(this.lblUnitsInStockDelete);
            this.gbxDelete.Controls.Add(this.lblUnitPriceDelete);
            this.gbxDelete.Controls.Add(this.lblCategoryDelete);
            this.gbxDelete.Controls.Add(this.lblProductNameDelete);
            this.gbxDelete.Location = new System.Drawing.Point(14, 8);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(742, 211);
            this.gbxDelete.TabIndex = 1;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Ürün Sil";
            // 
            // cbxCategoryDelete
            // 
            this.cbxCategoryDelete.FormattingEnabled = true;
            this.cbxCategoryDelete.Location = new System.Drawing.Point(62, 85);
            this.cbxCategoryDelete.Name = "cbxCategoryDelete";
            this.cbxCategoryDelete.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryDelete.TabIndex = 7;
            // 
            // tbxUnitPriceDelete
            // 
            this.tbxUnitPriceDelete.Location = new System.Drawing.Point(313, 40);
            this.tbxUnitPriceDelete.Name = "tbxUnitPriceDelete";
            this.tbxUnitPriceDelete.Size = new System.Drawing.Size(121, 20);
            this.tbxUnitPriceDelete.TabIndex = 6;
            // 
            // tbxQuantityPerUnitDelete
            // 
            this.tbxQuantityPerUnitDelete.Location = new System.Drawing.Point(313, 90);
            this.tbxQuantityPerUnitDelete.Name = "tbxQuantityPerUnitDelete";
            this.tbxQuantityPerUnitDelete.Size = new System.Drawing.Size(121, 20);
            this.tbxQuantityPerUnitDelete.TabIndex = 6;
            // 
            // tbxUnitsInStockDelete
            // 
            this.tbxUnitsInStockDelete.Location = new System.Drawing.Point(615, 40);
            this.tbxUnitsInStockDelete.Name = "tbxUnitsInStockDelete";
            this.tbxUnitsInStockDelete.Size = new System.Drawing.Size(110, 20);
            this.tbxUnitsInStockDelete.TabIndex = 6;
            // 
            // tbxProductNameDelete
            // 
            this.tbxProductNameDelete.Location = new System.Drawing.Point(62, 40);
            this.tbxProductNameDelete.Name = "tbxProductNameDelete";
            this.tbxProductNameDelete.Size = new System.Drawing.Size(121, 20);
            this.tbxProductNameDelete.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(553, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblQuantityPerUnitDelete
            // 
            this.lblQuantityPerUnitDelete.AutoSize = true;
            this.lblQuantityPerUnitDelete.Location = new System.Drawing.Point(248, 93);
            this.lblQuantityPerUnitDelete.Name = "lblQuantityPerUnitDelete";
            this.lblQuantityPerUnitDelete.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitDelete.TabIndex = 4;
            this.lblQuantityPerUnitDelete.Text = "Birim Adedi";
            // 
            // lblUnitsInStockDelete
            // 
            this.lblUnitsInStockDelete.AutoSize = true;
            this.lblUnitsInStockDelete.Location = new System.Drawing.Point(550, 43);
            this.lblUnitsInStockDelete.Name = "lblUnitsInStockDelete";
            this.lblUnitsInStockDelete.Size = new System.Drawing.Size(59, 13);
            this.lblUnitsInStockDelete.TabIndex = 3;
            this.lblUnitsInStockDelete.Text = "Stok Adedi";
            // 
            // lblUnitPriceDelete
            // 
            this.lblUnitPriceDelete.AutoSize = true;
            this.lblUnitPriceDelete.Location = new System.Drawing.Point(277, 43);
            this.lblUnitPriceDelete.Name = "lblUnitPriceDelete";
            this.lblUnitPriceDelete.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceDelete.TabIndex = 2;
            this.lblUnitPriceDelete.Text = "Fiyat";
            // 
            // lblCategoryDelete
            // 
            this.lblCategoryDelete.AutoSize = true;
            this.lblCategoryDelete.Location = new System.Drawing.Point(8, 88);
            this.lblCategoryDelete.Name = "lblCategoryDelete";
            this.lblCategoryDelete.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryDelete.TabIndex = 1;
            this.lblCategoryDelete.Text = "Kategori";
            // 
            // lblProductNameDelete
            // 
            this.lblProductNameDelete.AutoSize = true;
            this.lblProductNameDelete.Location = new System.Drawing.Point(8, 43);
            this.lblProductNameDelete.Name = "lblProductNameDelete";
            this.lblProductNameDelete.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameDelete.TabIndex = 0;
            this.lblProductNameDelete.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategorySearch.ResumeLayout(false);
            this.gbxCategorySearch.PerformLayout();
            this.gbxProductNameSearch.ResumeLayout(false);
            this.gbxProductNameSearch.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategorySearch;
        private System.Windows.Forms.ComboBox cbxCategorySearch;
        private System.Windows.Forms.Label lblCategorySearch;
        private System.Windows.Forms.GroupBox gbxProductNameSearch;
        private System.Windows.Forms.TextBox tbxProductNameSearch;
        private System.Windows.Forms.Label lblProductNameSearch;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.ComboBox cbxCategoryDelete;
        private System.Windows.Forms.TextBox tbxUnitPriceDelete;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitDelete;
        private System.Windows.Forms.TextBox tbxUnitsInStockDelete;
        private System.Windows.Forms.TextBox tbxProductNameDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblQuantityPerUnitDelete;
        private System.Windows.Forms.Label lblUnitsInStockDelete;
        private System.Windows.Forms.Label lblUnitPriceDelete;
        private System.Windows.Forms.Label lblCategoryDelete;
        private System.Windows.Forms.Label lblProductNameDelete;
    }
}

