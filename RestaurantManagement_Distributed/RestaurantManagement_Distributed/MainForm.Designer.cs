
namespace RestaurantManagement_Distributed
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lvBillDetail = new System.Windows.Forms.ListView();
            this.lvcFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbbTableList = new System.Windows.Forms.ComboBox();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBranch = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslGroup = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(473, 44);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(267, 21);
            this.cbbCategory.TabIndex = 1;
            // 
            // cbbFood
            // 
            this.cbbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(473, 71);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(267, 21);
            this.cbbFood.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Location = new System.Drawing.Point(746, 64);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(80, 30);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Location = new System.Drawing.Point(746, 44);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(80, 20);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvBillDetail
            // 
            this.lvBillDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcFood,
            this.lvcUnit,
            this.lvcQuantity,
            this.lvcUnitPrice,
            this.lvcAmount});
            this.lvBillDetail.HideSelection = false;
            this.lvBillDetail.Location = new System.Drawing.Point(473, 108);
            this.lvBillDetail.Name = "lvBillDetail";
            this.lvBillDetail.Size = new System.Drawing.Size(353, 362);
            this.lvBillDetail.TabIndex = 4;
            this.lvBillDetail.UseCompatibleStateImageBehavior = false;
            this.lvBillDetail.View = System.Windows.Forms.View.Details;
            // 
            // lvcFood
            // 
            this.lvcFood.Text = "Tên món";
            this.lvcFood.Width = 100;
            // 
            // lvcUnit
            // 
            this.lvcUnit.Text = "ĐVT";
            this.lvcUnit.Width = 50;
            // 
            // lvcQuantity
            // 
            this.lvcQuantity.Text = "Số lượng";
            // 
            // lvcUnitPrice
            // 
            this.lvcUnitPrice.Text = "Đơn giá";
            // 
            // lvcAmount
            // 
            this.lvcAmount.Text = "Thành tiền";
            this.lvcAmount.Width = 80;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.Location = new System.Drawing.Point(754, 469);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(79, 42);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(634, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "% Giảm giá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDiscount.Location = new System.Drawing.Point(712, 491);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(43, 20);
            this.nudDiscount.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(634, 471);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbTableList
            // 
            this.cbbTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTableList.FormattingEnabled = true;
            this.cbbTableList.Location = new System.Drawing.Point(473, 492);
            this.cbbTableList.Name = "cbbTableList";
            this.cbbTableList.Size = new System.Drawing.Size(103, 21);
            this.cbbTableList.TabIndex = 1;
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeTable.Location = new System.Drawing.Point(473, 471);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(103, 21);
            this.btnMergeTable.TabIndex = 2;
            this.btnMergeTable.Text = "Chuyển/Gộp bàn";
            this.btnMergeTable.UseVisualStyleBackColor = true;
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmiAdmin.Text = "Admin";
            this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountInfo,
            this.tsmiLogOut});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // tsmiAccountInfo
            // 
            this.tsmiAccountInfo.Name = "tsmiAccountInfo";
            this.tsmiAccountInfo.Size = new System.Drawing.Size(177, 22);
            this.tsmiAccountInfo.Text = "Thông tin tài khoản";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(177, 22);
            this.tsmiLogOut.Text = "Đăng xuất";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clUnit,
            this.clPrice,
            this.clCategory});
            this.dgvFoodList.Location = new System.Drawing.Point(12, 44);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.Size = new System.Drawing.Size(455, 447);
            this.dgvFoodList.TabIndex = 7;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Tên món ăn";
            this.clName.Name = "clName";
            this.clName.Width = 180;
            // 
            // clUnit
            // 
            this.clUnit.DataPropertyName = "Unit";
            this.clUnit.HeaderText = "ĐVT";
            this.clUnit.Name = "clUnit";
            this.clUnit.Width = 50;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Đơn giá";
            this.clPrice.Name = "clPrice";
            this.clPrice.Width = 80;
            // 
            // clCategory
            // 
            this.clCategory.DataPropertyName = "CategoryID";
            this.clCategory.HeaderText = "Nhóm";
            this.clCategory.Name = "clCategory";
            this.clCategory.Width = 80;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLoginName,
            this.tsslBranch,
            this.tsslGroup});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslLoginName
            // 
            this.tsslLoginName.Image = ((System.Drawing.Image)(resources.GetObject("tsslLoginName.Image")));
            this.tsslLoginName.Name = "tsslLoginName";
            this.tsslLoginName.Size = new System.Drawing.Size(107, 17);
            this.tsslLoginName.Text = "Tên đăng nhập: ";
            // 
            // tsslBranch
            // 
            this.tsslBranch.Image = ((System.Drawing.Image)(resources.GetObject("tsslBranch.Image")));
            this.tsslBranch.Name = "tsslBranch";
            this.tsslBranch.Size = new System.Drawing.Size(84, 17);
            this.tsslBranch.Text = "Chi nhánh: ";
            // 
            // tsslGroup
            // 
            this.tsslGroup.Image = ((System.Drawing.Image)(resources.GetObject("tsslGroup.Image")));
            this.tsslGroup.Name = "tsslGroup";
            this.tsslGroup.Size = new System.Drawing.Size(63, 17);
            this.tsslGroup.Text = "Nhóm: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 523);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lvBillDetail);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnMergeTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.cbbTableList);
            this.Controls.Add(this.cbbFood);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý nhà hàng ABC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.ComboBox cbbFood;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.NumericUpDown nudQuantity;
		private System.Windows.Forms.ListView lvBillDetail;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown nudDiscount;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.ComboBox cbbTableList;
		private System.Windows.Forms.Button btnMergeTable;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiAccountInfo;
		private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ColumnHeader lvcFood;
		private System.Windows.Forms.ColumnHeader lvcUnit;
		private System.Windows.Forms.ColumnHeader lvcQuantity;
		private System.Windows.Forms.ColumnHeader lvcUnitPrice;
		private System.Windows.Forms.ColumnHeader lvcAmount;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslLoginName;
        private System.Windows.Forms.ToolStripStatusLabel tsslBranch;
        private System.Windows.Forms.ToolStripStatusLabel tsslGroup;
    }
}