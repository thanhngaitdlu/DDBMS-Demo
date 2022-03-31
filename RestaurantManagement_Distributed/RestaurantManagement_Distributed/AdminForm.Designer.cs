namespace RestaurantManagement_Distributed
{
    partial class AdminForm
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tpCreateAccount = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdQLChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdGiamDoc = new System.Windows.Forms.RadioButton();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdNhanVien = new System.Windows.Forms.RadioButton();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.ctmsAccList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReserPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeactive = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbAccountBranch = new System.Windows.Forms.ComboBox();
            this.cbbBranchAccount = new System.Windows.Forms.ComboBox();
            this.tcAdmin.SuspendLayout();
            this.tpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tpCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ctmsAccList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpEmployee);
            this.tcAdmin.Controls.Add(this.tpCreateAccount);
            this.tcAdmin.Location = new System.Drawing.Point(0, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(801, 435);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.cbbBranch);
            this.tpEmployee.Controls.Add(this.label2);
            this.tpEmployee.Controls.Add(this.label1);
            this.tpEmployee.Controls.Add(this.dgvEmployee);
            this.tpEmployee.Location = new System.Drawing.Point(4, 22);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployee.Size = new System.Drawing.Size(793, 409);
            this.tpEmployee.TabIndex = 0;
            this.tpEmployee.Text = "Nhân viên";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // cbbBranch
            // 
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(313, 8);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(180, 21);
            this.cbbBranch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi nhánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 41);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(782, 365);
            this.dgvEmployee.TabIndex = 0;
            // 
            // tpCreateAccount
            // 
            this.tpCreateAccount.Controls.Add(this.cbbBranchAccount);
            this.tpCreateAccount.Controls.Add(this.btnTaoTK);
            this.tpCreateAccount.Controls.Add(this.groupBox1);
            this.tpCreateAccount.Controls.Add(this.dgvAccountList);
            this.tpCreateAccount.Controls.Add(this.label3);
            this.tpCreateAccount.Controls.Add(this.label4);
            this.tpCreateAccount.Location = new System.Drawing.Point(4, 22);
            this.tpCreateAccount.Name = "tpCreateAccount";
            this.tpCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateAccount.Size = new System.Drawing.Size(793, 409);
            this.tpCreateAccount.TabIndex = 1;
            this.tpCreateAccount.Text = "Tạo tài khoản";
            this.tpCreateAccount.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi nhánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách tài khoản";
            // 
            // rdQLChiNhanh
            // 
            this.rdQLChiNhanh.AutoSize = true;
            this.rdQLChiNhanh.Location = new System.Drawing.Point(121, 126);
            this.rdQLChiNhanh.Name = "rdQLChiNhanh";
            this.rdQLChiNhanh.Size = new System.Drawing.Size(89, 17);
            this.rdQLChiNhanh.TabIndex = 5;
            this.rdQLChiNhanh.TabStop = true;
            this.rdQLChiNhanh.Text = "QL chi nhánh";
            this.rdQLChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdGiamDoc
            // 
            this.rdGiamDoc.AutoSize = true;
            this.rdGiamDoc.Location = new System.Drawing.Point(121, 91);
            this.rdGiamDoc.Name = "rdGiamDoc";
            this.rdGiamDoc.Size = new System.Drawing.Size(71, 17);
            this.rdGiamDoc.TabIndex = 5;
            this.rdGiamDoc.TabStop = true;
            this.rdGiamDoc.Text = "Giám đốc";
            this.rdGiamDoc.UseVisualStyleBackColor = true;
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.ContextMenuStrip = this.ctmsAccList;
            this.dgvAccountList.Location = new System.Drawing.Point(11, 64);
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.Size = new System.Drawing.Size(452, 339);
            this.dgvAccountList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbAccountBranch);
            this.groupBox1.Controls.Add(this.cbbEmployee);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLoginName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdNhanVien);
            this.groupBox1.Controls.Add(this.rdQLChiNhanh);
            this.groupBox1.Controls.Add(this.rdGiamDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(470, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 244);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chọn vai trò";
            // 
            // rdNhanVien
            // 
            this.rdNhanVien.AutoSize = true;
            this.rdNhanVien.Location = new System.Drawing.Point(121, 161);
            this.rdNhanVien.Name = "rdNhanVien";
            this.rdNhanVien.Size = new System.Drawing.Size(74, 17);
            this.rdNhanVien.TabIndex = 5;
            this.rdNhanVien.TabStop = true;
            this.rdNhanVien.Text = "Nhân viên";
            this.rdNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(121, 54);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(179, 20);
            this.txtLoginName.TabIndex = 6;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(121, 20);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(179, 21);
            this.cbbEmployee.TabIndex = 7;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(676, 295);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(94, 23);
            this.btnTaoTK.TabIndex = 8;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            // 
            // ctmsAccList
            // 
            this.ctmsAccList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReserPwd,
            this.tsmiDeactive});
            this.ctmsAccList.Name = "ctmsAccList";
            this.ctmsAccList.Size = new System.Drawing.Size(161, 48);
            // 
            // tsmiReserPwd
            // 
            this.tsmiReserPwd.Name = "tsmiReserPwd";
            this.tsmiReserPwd.Size = new System.Drawing.Size(160, 22);
            this.tsmiReserPwd.Text = "Đặt lại mật khẩu";
            // 
            // tsmiDeactive
            // 
            this.tsmiDeactive.Name = "tsmiDeactive";
            this.tsmiDeactive.Size = new System.Drawing.Size(160, 22);
            this.tsmiDeactive.Text = "Xóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chọn chi nhánh";
            // 
            // cbbAccountBranch
            // 
            this.cbbAccountBranch.Enabled = false;
            this.cbbAccountBranch.FormattingEnabled = true;
            this.cbbAccountBranch.Location = new System.Drawing.Point(121, 195);
            this.cbbAccountBranch.Name = "cbbAccountBranch";
            this.cbbAccountBranch.Size = new System.Drawing.Size(179, 21);
            this.cbbAccountBranch.TabIndex = 7;
            // 
            // cbbBranchAccount
            // 
            this.cbbBranchAccount.Enabled = false;
            this.cbbBranchAccount.FormattingEnabled = true;
            this.cbbBranchAccount.Location = new System.Drawing.Point(122, 12);
            this.cbbBranchAccount.Name = "cbbBranchAccount";
            this.cbbBranchAccount.Size = new System.Drawing.Size(215, 21);
            this.cbbBranchAccount.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAdmin);
            this.Name = "AdminForm";
            this.Text = "Quản trị";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpEmployee.ResumeLayout(false);
            this.tpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tpCreateAccount.ResumeLayout(false);
            this.tpCreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctmsAccList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TabPage tpCreateAccount;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBranchAccount;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbAccountBranch;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdNhanVien;
        private System.Windows.Forms.RadioButton rdQLChiNhanh;
        private System.Windows.Forms.RadioButton rdGiamDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAccountList;
        private System.Windows.Forms.ContextMenuStrip ctmsAccList;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeactive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}