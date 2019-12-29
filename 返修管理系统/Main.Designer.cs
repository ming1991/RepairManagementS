namespace 返修管理系统
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看备用机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备用机出入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看备用机出入库记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datacontMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.更改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.datacontMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.datacontMS;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 461);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "精确查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(170, 14);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(186, 21);
            this.queryBox.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "模糊查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "查询条件";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.修改表ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 21);
            this.toolStripMenuItem1.Text = "返修表";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "添加返修记录";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "查看返修表";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看备用机ToolStripMenuItem,
            this.备用机出入库ToolStripMenuItem,
            this.查看备用机出入库记录ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 21);
            this.toolStripMenuItem2.Text = "备用机";
            // 
            // 查看备用机ToolStripMenuItem
            // 
            this.查看备用机ToolStripMenuItem.Name = "查看备用机ToolStripMenuItem";
            this.查看备用机ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.查看备用机ToolStripMenuItem.Text = "查看备用机";
            this.查看备用机ToolStripMenuItem.Click += new System.EventHandler(this.查看备用机ToolStripMenuItem_Click);
            // 
            // 备用机出入库ToolStripMenuItem
            // 
            this.备用机出入库ToolStripMenuItem.Name = "备用机出入库ToolStripMenuItem";
            this.备用机出入库ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.备用机出入库ToolStripMenuItem.Text = "备用机出\\入库";
            this.备用机出入库ToolStripMenuItem.Click += new System.EventHandler(this.备用机出入库ToolStripMenuItem_Click);
            // 
            // 查看备用机出入库记录ToolStripMenuItem
            // 
            this.查看备用机出入库记录ToolStripMenuItem.Name = "查看备用机出入库记录ToolStripMenuItem";
            this.查看备用机出入库记录ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.查看备用机出入库记录ToolStripMenuItem.Text = "查看备用机出入库记录";
            this.查看备用机出入库记录ToolStripMenuItem.Click += new System.EventHandler(this.查看备用机出入库记录ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.queryBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 45);
            this.panel1.TabIndex = 18;
            // 
            // datacontMS
            // 
            this.datacontMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.datacontMS.Name = "datacontMS";
            this.datacontMS.Size = new System.Drawing.Size(181, 70);
            // 
            // 更改ToolStripMenuItem
            // 
            this.更改ToolStripMenuItem.Name = "更改ToolStripMenuItem";
            this.更改ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.更改ToolStripMenuItem.Text = "更改";
            this.更改ToolStripMenuItem.Click += new System.EventHandler(this.更改ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 修改表ToolStripMenuItem
            // 
            this.修改表ToolStripMenuItem.Name = "修改表ToolStripMenuItem";
            this.修改表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改表ToolStripMenuItem.Text = "修改返修表";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.datacontMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 查看备用机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备用机出入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看备用机出入库记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip datacontMS;
        private System.Windows.Forms.ToolStripMenuItem 更改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改表ToolStripMenuItem;
    }
}