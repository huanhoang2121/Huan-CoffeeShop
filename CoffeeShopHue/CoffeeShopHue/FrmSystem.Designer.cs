namespace CoffeeShopHue
{
    partial class FrmSystem
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
            this.MenuSystem = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.bntChuyenban = new System.Windows.Forms.Button();
            this.nudDissCount = new System.Windows.Forms.NumericUpDown();
            this.btnDissCount = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.udFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCatelogy = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuSystem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDissCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSystem
            // 
            this.MenuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.MenuSystem.Location = new System.Drawing.Point(0, 0);
            this.MenuSystem.Name = "MenuSystem";
            this.MenuSystem.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuSystem.Size = new System.Drawing.Size(1077, 24);
            this.MenuSystem.TabIndex = 0;
            this.MenuSystem.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagerToolStripMenuItem,
            this.loggingSystemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // accountManagerToolStripMenuItem
            // 
            this.accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            this.accountManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountManagerToolStripMenuItem.Text = "Account Manager";
            this.accountManagerToolStripMenuItem.Click += new System.EventHandler(this.accountManagerToolStripMenuItem_Click);
            // 
            // loggingSystemToolStripMenuItem
            // 
            this.loggingSystemToolStripMenuItem.Name = "loggingSystemToolStripMenuItem";
            this.loggingSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loggingSystemToolStripMenuItem.Text = "System Manager";
            this.loggingSystemToolStripMenuItem.Click += new System.EventHandler(this.loggingSystemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(560, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 354);
            this.panel2.TabIndex = 3;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewBill.GridLines = true;
            this.listViewBill.Location = new System.Drawing.Point(5, 5);
            this.listViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(497, 344);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Food";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.bntChuyenban);
            this.panel3.Controls.Add(this.nudDissCount);
            this.panel3.Controls.Add(this.btnDissCount);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Location = new System.Drawing.Point(560, 462);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 98);
            this.panel3.TabIndex = 4;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(5, 58);
            this.cbChuyenBan.Margin = new System.Windows.Forms.Padding(4);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(120, 24);
            this.cbChuyenBan.TabIndex = 4;
            // 
            // bntChuyenban
            // 
            this.bntChuyenban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChuyenban.Location = new System.Drawing.Point(5, 18);
            this.bntChuyenban.Margin = new System.Windows.Forms.Padding(4);
            this.bntChuyenban.Name = "bntChuyenban";
            this.bntChuyenban.Size = new System.Drawing.Size(120, 32);
            this.bntChuyenban.TabIndex = 6;
            this.bntChuyenban.Text = "Chuyển bàn";
            this.bntChuyenban.UseVisualStyleBackColor = true;
            // 
            // nudDissCount
            // 
            this.nudDissCount.Location = new System.Drawing.Point(197, 56);
            this.nudDissCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudDissCount.Name = "nudDissCount";
            this.nudDissCount.Size = new System.Drawing.Size(120, 22);
            this.nudDissCount.TabIndex = 4;
            this.nudDissCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDissCount
            // 
            this.btnDissCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDissCount.Location = new System.Drawing.Point(197, 18);
            this.btnDissCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDissCount.Name = "btnDissCount";
            this.btnDissCount.Size = new System.Drawing.Size(120, 32);
            this.btnDissCount.TabIndex = 5;
            this.btnDissCount.Text = "Giảm giá";
            this.btnDissCount.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(382, 18);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 60);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.udFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCatelogy);
            this.panel4.Location = new System.Drawing.Point(560, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 69);
            this.panel4.TabIndex = 5;
            // 
            // udFoodCount
            // 
            this.udFoodCount.Location = new System.Drawing.Point(440, 23);
            this.udFoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.udFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udFoodCount.Name = "udFoodCount";
            this.udFoodCount.Size = new System.Drawing.Size(63, 22);
            this.udFoodCount.TabIndex = 3;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(313, 4);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(120, 60);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(5, 38);
            this.cbFood.Margin = new System.Windows.Forms.Padding(4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(300, 24);
            this.cbFood.TabIndex = 1;
            // 
            // cbCatelogy
            // 
            this.cbCatelogy.FormattingEnabled = true;
            this.cbCatelogy.Location = new System.Drawing.Point(5, 4);
            this.cbCatelogy.Margin = new System.Windows.Forms.Padding(4);
            this.cbCatelogy.Name = "cbCatelogy";
            this.cbCatelogy.Size = new System.Drawing.Size(300, 24);
            this.cbCatelogy.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 33);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(541, 527);
            this.flpTable.TabIndex = 6;
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 563);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuSystem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuSystem;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSystem_FormClosing);
            this.MenuSystem.ResumeLayout(false);
            this.MenuSystem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDissCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSystem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown udFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCatelogy;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button bntChuyenban;
        private System.Windows.Forms.NumericUpDown nudDissCount;
        private System.Windows.Forms.Button btnDissCount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

