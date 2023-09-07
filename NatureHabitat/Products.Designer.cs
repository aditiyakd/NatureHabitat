namespace NatureHabitat
{
    partial class Products
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
            txtPCode = new TextBox();
            txtPName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBStatus = new ComboBox();
            BtnAdd = new Button();
            label3 = new Label();
            btnDelete = new Button();
            dataGridProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // txtPCode
            // 
            txtPCode.Location = new Point(9, 66);
            txtPCode.Margin = new Padding(3, 4, 3, 4);
            txtPCode.Name = "txtPCode";
            txtPCode.Size = new Size(165, 24);
            txtPCode.TabIndex = 1;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(180, 66);
            txtPName.Margin = new Padding(3, 4, 3, 4);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(165, 24);
            txtPName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 1;
            label1.Text = "Product Code";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(180, 35);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // comboBStatus
            // 
            comboBStatus.FormattingEnabled = true;
            comboBStatus.Items.AddRange(new object[] { "Active", "Deactive" });
            comboBStatus.Location = new Point(351, 66);
            comboBStatus.Name = "comboBStatus";
            comboBStatus.Size = new Size(165, 25);
            comboBStatus.TabIndex = 3;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.LightGray;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdd.Location = new Point(641, 57);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(91, 43);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(351, 35);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 1;
            label3.Text = "Status";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Open Sans Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(544, 57);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.AllowUserToAddRows = false;
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridProducts.Location = new Point(22, 128);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.RowTemplate.Height = 25;
            dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProducts.Size = new Size(800, 289);
            dataGridProducts.TabIndex = 4;
            dataGridProducts.CellContentClick += dataGridView1_CellContentClick;
            dataGridProducts.MouseDoubleClick += dataGridProducts_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Code";
            Column1.Name = "Column1";
            Column1.Width = 335;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            // 
            // Products
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(837, 522);
            Controls.Add(dataGridProducts);
            Controls.Add(btnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(comboBStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPName);
            Controls.Add(txtPCode);
            Font = new Font("Open Sans Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPCode;
        private TextBox txtPName;
        private Label label1;
        private Label label2;
        private ComboBox comboBStatus;
        private Button BtnAdd;
        private Label label3;
        private Button btnDelete;
        private DataGridView dataGridProducts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}