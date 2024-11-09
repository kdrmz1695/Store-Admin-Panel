namespace KocTasMall
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.comboBoxShortby = new System.Windows.Forms.ComboBox();
            this.pCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kocTasDbDataSet = new KocTasMall.KocTasDbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategoryList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListP = new System.Windows.Forms.Button();
            this.buttonPUp = new System.Windows.Forms.Button();
            this.buttonPDel = new System.Windows.Forms.Button();
            this.buttonPAdd = new System.Windows.Forms.Button();
            this.textBoxPCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.kocTasDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDataScreen = new System.Windows.Forms.GroupBox();
            this.dataGridViewScreen = new System.Windows.Forms.DataGridView();
            this.pCategoriesTableAdapter = new KocTasMall.KocTasDbDataSetTableAdapters.PCategoriesTableAdapter();
            this.groupBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocTasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocTasDbDataSetBindingSource)).BeginInit();
            this.groupBoxDataScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.comboBoxShortby);
            this.groupBoxPanel.Controls.Add(this.label6);
            this.groupBoxPanel.Controls.Add(this.label5);
            this.groupBoxPanel.Controls.Add(this.comboBoxCategoryList);
            this.groupBoxPanel.Controls.Add(this.label2);
            this.groupBoxPanel.Controls.Add(this.textBoxSearch);
            this.groupBoxPanel.Controls.Add(this.textBoxPID);
            this.groupBoxPanel.Controls.Add(this.label1);
            this.groupBoxPanel.Controls.Add(this.buttonListP);
            this.groupBoxPanel.Controls.Add(this.buttonPUp);
            this.groupBoxPanel.Controls.Add(this.buttonPDel);
            this.groupBoxPanel.Controls.Add(this.buttonPAdd);
            this.groupBoxPanel.Controls.Add(this.textBoxPCat);
            this.groupBoxPanel.Controls.Add(this.label4);
            this.groupBoxPanel.Controls.Add(this.textBoxPPrice);
            this.groupBoxPanel.Controls.Add(this.label3);
            this.groupBoxPanel.Controls.Add(this.textBoxPName);
            this.groupBoxPanel.Controls.Add(this.labelPName);
            this.groupBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(1019, 325);
            this.groupBoxPanel.TabIndex = 0;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Product Panel";
            // 
            // comboBoxShortby
            // 
            this.comboBoxShortby.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pCategoriesBindingSource, "CategoryName", true));
            this.comboBoxShortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShortby.FormattingEnabled = true;
            this.comboBoxShortby.Items.AddRange(new object[] {
            "A to Z",
            "Z to A",
            "Lowest Price",
            "Highest Price"});
            this.comboBoxShortby.Location = new System.Drawing.Point(258, 291);
            this.comboBoxShortby.Name = "comboBoxShortby";
            this.comboBoxShortby.Size = new System.Drawing.Size(144, 28);
            this.comboBoxShortby.TabIndex = 19;
            this.comboBoxShortby.SelectedIndexChanged += new System.EventHandler(this.comboBoxShortby_SelectedIndexChanged);
            // 
            // pCategoriesBindingSource
            // 
            this.pCategoriesBindingSource.DataMember = "PCategories";
            this.pCategoriesBindingSource.DataSource = this.kocTasDbDataSet;
            // 
            // kocTasDbDataSet
            // 
            this.kocTasDbDataSet.DataSetName = "KocTasDbDataSet";
            this.kocTasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Short by:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "List Category:";
            // 
            // comboBoxCategoryList
            // 
            this.comboBoxCategoryList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pCategoriesBindingSource, "CategoryName", true));
            this.comboBoxCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryList.FormattingEnabled = true;
            this.comboBoxCategoryList.Location = new System.Drawing.Point(258, 244);
            this.comboBoxCategoryList.Name = "comboBoxCategoryList";
            this.comboBoxCategoryList.Size = new System.Drawing.Size(144, 28);
            this.comboBoxCategoryList.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(258, 197);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(144, 26);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxPID
            // 
            this.textBoxPID.Location = new System.Drawing.Point(258, 22);
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(144, 26);
            this.textBoxPID.TabIndex = 13;
            this.textBoxPID.TextChanged += new System.EventHandler(this.textBoxPID_TextChanged);
            this.textBoxPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onlynumbers);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product ID:";
            // 
            // buttonListP
            // 
            this.buttonListP.Location = new System.Drawing.Point(658, 41);
            this.buttonListP.Name = "buttonListP";
            this.buttonListP.Size = new System.Drawing.Size(116, 63);
            this.buttonListP.TabIndex = 11;
            this.buttonListP.Text = "List All Products";
            this.buttonListP.UseVisualStyleBackColor = true;
            this.buttonListP.Click += new System.EventHandler(this.buttonListP_Click);
            // 
            // buttonPUp
            // 
            this.buttonPUp.Location = new System.Drawing.Point(503, 234);
            this.buttonPUp.Name = "buttonPUp";
            this.buttonPUp.Size = new System.Drawing.Size(116, 63);
            this.buttonPUp.TabIndex = 10;
            this.buttonPUp.Text = "Update";
            this.buttonPUp.UseVisualStyleBackColor = true;
            this.buttonPUp.Click += new System.EventHandler(this.buttonPUp_Click);
            // 
            // buttonPDel
            // 
            this.buttonPDel.Location = new System.Drawing.Point(503, 133);
            this.buttonPDel.Name = "buttonPDel";
            this.buttonPDel.Size = new System.Drawing.Size(116, 63);
            this.buttonPDel.TabIndex = 9;
            this.buttonPDel.Text = "Delete";
            this.buttonPDel.UseVisualStyleBackColor = true;
            this.buttonPDel.Click += new System.EventHandler(this.buttonPDel_Click);
            // 
            // buttonPAdd
            // 
            this.buttonPAdd.Location = new System.Drawing.Point(503, 41);
            this.buttonPAdd.Name = "buttonPAdd";
            this.buttonPAdd.Size = new System.Drawing.Size(116, 63);
            this.buttonPAdd.TabIndex = 8;
            this.buttonPAdd.Text = "Add";
            this.buttonPAdd.UseVisualStyleBackColor = true;
            this.buttonPAdd.Click += new System.EventHandler(this.buttonPAdd_Click);
            // 
            // textBoxPCat
            // 
            this.textBoxPCat.Location = new System.Drawing.Point(258, 155);
            this.textBoxPCat.Name = "textBoxPCat";
            this.textBoxPCat.Size = new System.Drawing.Size(144, 26);
            this.textBoxPCat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category:";
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(258, 113);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(144, 26);
            this.textBoxPPrice.TabIndex = 5;
            this.textBoxPPrice.TextChanged += new System.EventHandler(this.textBoxPPrice_TextChanged);
            this.textBoxPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(258, 71);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(144, 26);
            this.textBoxPName.TabIndex = 3;
            // 
            // labelPName
            // 
            this.labelPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPName.Location = new System.Drawing.Point(1, 71);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(155, 33);
            this.labelPName.TabIndex = 2;
            this.labelPName.Text = "Product Name:";
            // 
            // kocTasDbDataSetBindingSource
            // 
            this.kocTasDbDataSetBindingSource.DataSource = this.kocTasDbDataSet;
            this.kocTasDbDataSetBindingSource.Position = 0;
            // 
            // groupBoxDataScreen
            // 
            this.groupBoxDataScreen.Controls.Add(this.dataGridViewScreen);
            this.groupBoxDataScreen.Location = new System.Drawing.Point(5, 343);
            this.groupBoxDataScreen.Name = "groupBoxDataScreen";
            this.groupBoxDataScreen.Size = new System.Drawing.Size(1196, 368);
            this.groupBoxDataScreen.TabIndex = 9;
            this.groupBoxDataScreen.TabStop = false;
            this.groupBoxDataScreen.Text = "Shows:";
            // 
            // dataGridViewScreen
            // 
            this.dataGridViewScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScreen.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewScreen.Name = "dataGridViewScreen";
            this.dataGridViewScreen.RowHeadersWidth = 62;
            this.dataGridViewScreen.RowTemplate.Height = 28;
            this.dataGridViewScreen.Size = new System.Drawing.Size(1190, 343);
            this.dataGridViewScreen.TabIndex = 0;
            this.dataGridViewScreen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewScreen.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pCategoriesTableAdapter
            // 
            this.pCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 710);
            this.Controls.Add(this.groupBoxDataScreen);
            this.Controls.Add(this.groupBoxPanel);
            this.Name = "Form1";
            this.Text = "Koctas Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocTasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocTasDbDataSetBindingSource)).EndInit();
            this.groupBoxDataScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.TextBox textBoxPPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.TextBox textBoxPCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDataScreen;
        private System.Windows.Forms.DataGridView dataGridViewScreen;
        private System.Windows.Forms.Button buttonPUp;
        private System.Windows.Forms.Button buttonPDel;
        private System.Windows.Forms.Button buttonPAdd;
        private System.Windows.Forms.Button buttonListP;
        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategoryList;
        private KocTasDbDataSet kocTasDbDataSet;
        private System.Windows.Forms.BindingSource kocTasDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource pCategoriesBindingSource;
        private KocTasDbDataSetTableAdapters.PCategoriesTableAdapter pCategoriesTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxShortby;
        private System.Windows.Forms.Label label6;
    }
}

