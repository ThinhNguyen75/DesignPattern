
namespace quanlyxekhach
{
    partial class AccountManagement
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnChangeDataAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myTextBox1 = new quanlyxekhach.StrateryPattern.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(956, 80);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(770, 85);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(148, 26);
            this.txtFind.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhập thông tin ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(626, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(466, 482);
            this.dataGridView1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.myTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDeleteAcc);
            this.panel1.Controls.Add(this.btnChangeDataAcc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtNameEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(110, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 529);
            this.panel1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaNV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaNV.Location = new System.Drawing.Point(50, 51);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(0, 20);
            this.txtMaNV.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(171, 420);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(306, 303);
            this.btnDeleteAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(112, 35);
            this.btnDeleteAcc.TabIndex = 11;
            this.btnDeleteAcc.Text = "xóa";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            // 
            // btnChangeDataAcc
            // 
            this.btnChangeDataAcc.Location = new System.Drawing.Point(81, 303);
            this.btnChangeDataAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeDataAcc.Name = "btnChangeDataAcc";
            this.btnChangeDataAcc.Size = new System.Drawing.Size(112, 35);
            this.btnChangeDataAcc.TabIndex = 9;
            this.btnChangeDataAcc.Text = "sửa";
            this.btnChangeDataAcc.UseVisualStyleBackColor = true;
            this.btnChangeDataAcc.Click += new System.EventHandler(this.btnChangeDataAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(156, 249);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(244, 26);
            this.txtPass.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 186);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(244, 26);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(156, 128);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(244, 26);
            this.txtPosition.TabIndex = 5;
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Location = new System.Drawing.Point(156, 65);
            this.txtNameEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(244, 26);
            this.txtNameEmp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức vụ ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 17;
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(141, 0);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(212, 26);
            this.myTextBox1.TabIndex = 16;
            this.myTextBox1.validType = quanlyxekhach.StrateryPattern.ValidationType.STRING;
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtMaNV;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnChangeDataAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private StrateryPattern.MyTextBox myTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

