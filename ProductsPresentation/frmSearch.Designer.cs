namespace ProductsPresentation
{
    partial class frmSearch
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
            label1 = new Label();
            txtName = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(85, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 27);
            txtName.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(277, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 34);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 20;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(705, 230);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(95, 34);
            btnSelect.TabIndex = 21;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 284);
            Controls.Add(btnSelect);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search For Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnSelect;
    }
}