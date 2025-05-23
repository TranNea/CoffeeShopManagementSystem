﻿namespace PresentationLayer
{
    partial class FrmCoupons
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
            dgvCoupons = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            usUpdateCoupon1 = new USUpdateCoupon();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtID = new TextBox();
            label5 = new Label();
            txtDes = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            txtValue = new TextBox();
            label7 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 48);
            label1.TabIndex = 1;
            label1.Text = "Coupons";
            // 
            // dgvCoupons
            // 
            dgvCoupons.BackgroundColor = Color.SeaGreen;
            dgvCoupons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupons.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCoupons.Location = new Point(15, 71);
            dgvCoupons.Margin = new Padding(2, 2, 2, 2);
            dgvCoupons.Name = "dgvCoupons";
            dgvCoupons.RowHeadersWidth = 82;
            dgvCoupons.Size = new Size(1178, 319);
            dgvCoupons.TabIndex = 2;
            dgvCoupons.CellContentClick += dgvCoupons_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "description";
            Column2.HeaderText = "Description";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "value";
            Column3.HeaderText = "Value";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // usUpdateCoupon1
            // 
            usUpdateCoupon1.BackColor = Color.SeaGreen;
            usUpdateCoupon1.BorderStyle = BorderStyle.Fixed3D;
            usUpdateCoupon1.Location = new Point(128, 98);
            usUpdateCoupon1.Margin = new Padding(1, 1, 1, 1);
            usUpdateCoupon1.Name = "usUpdateCoupon1";
            usUpdateCoupon1.Size = new Size(629, 337);
            usUpdateCoupon1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(15, 393);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(1178, 180);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Coupon";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(979, 45);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 40);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cat_coupon;
            pictureBox2.Location = new Point(14, 22);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(271, 80);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 2);
            panel1.TabIndex = 30;
            // 
            // txtID
            // 
            txtID.BackColor = Color.SeaGreen;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(272, 56);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(207, 23);
            txtID.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(198, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 28;
            label5.Text = "ID";
            // 
            // txtDes
            // 
            txtDes.BackColor = Color.SeaGreen;
            txtDes.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDes.ForeColor = Color.White;
            txtDes.Location = new Point(612, 56);
            txtDes.Margin = new Padding(2, 2, 2, 2);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(338, 84);
            txtDes.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(500, 56);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 26;
            label6.Text = "Description";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(271, 136);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 2);
            panel3.TabIndex = 25;
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.SeaGreen;
            txtValue.BorderStyle = BorderStyle.None;
            txtValue.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValue.ForeColor = Color.White;
            txtValue.Location = new Point(272, 111);
            txtValue.Margin = new Padding(2, 2, 2, 2);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(207, 23);
            txtValue.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(198, 111);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 23);
            label7.TabIndex = 23;
            label7.Text = "Value";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(979, 111);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(177, 40);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // FrmCoupons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1199, 605);
            Controls.Add(groupBox1);
            Controls.Add(usUpdateCoupon1);
            Controls.Add(dgvCoupons);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmCoupons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coupons";
            Load += FrmCoupons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCoupons;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private USUpdateCoupon usUpdateCoupon1;
        private Button btnAdd;
        private Button btnClear;
        private Label label2;
        private TextBox txtValue;
        private Panel panel2;
        private Label label3;
        private TextBox txtDes;
        private Label label4;
        private TextBox txtID;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel pnAddCoupon;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Panel panel3;
        private TextBox textBox3;
        private Label label7;
        private Button button1;
    }
}