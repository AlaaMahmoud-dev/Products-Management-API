namespace ProductsPresentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ll = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTax = new TextBox();
            label7 = new Label();
            lblID = new Label();
            lblTotal = new Label();
            lblCreatedAt = new Label();
            btnSearch = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(103, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 88);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ll.Location = new Point(24, 122);
            ll.Name = "ll";
            ll.Size = new Size(73, 21);
            ll.TabIndex = 4;
            ll.Text = "Quantity:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(103, 86);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(158, 27);
            txtPrice.TabIndex = 5;
            txtPrice.TextChanged += txtPrice_TextChanged_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(103, 122);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(158, 27);
            txtQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 224);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 10;
            label4.Text = "CreatedAt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 190);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 156);
            label6.Name = "label6";
            label6.Size = new Size(34, 21);
            label6.TabIndex = 8;
            label6.Text = "Tax:";
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(103, 158);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(158, 27);
            txtTax.TabIndex = 7;
            txtTax.TextChanged += txtTax_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 20);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 13;
            label7.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(103, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(48, 21);
            lblID.TabIndex = 14;
            lblID.Text = "[????]";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(103, 194);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 21);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "[????]";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedAt.Location = new Point(103, 224);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(48, 21);
            lblCreatedAt.TabIndex = 16;
            lblCreatedAt.Text = "[????]";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(93, 279);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 34);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(174, 279);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(74, 34);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblTotal);
            Controls.Add(lblID);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtTax);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(ll);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label ll;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTax;
        private Label label7;
        private Label lblID;
        private Label lblTotal;
        private Label lblCreatedAt;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dataGridView1;
    }
}
