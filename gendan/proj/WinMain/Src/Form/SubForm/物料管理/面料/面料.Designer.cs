namespace WindowsFormsTemplete
{
    partial class 面料
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("款式图1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "款式图2",
            "a",
            "b"}, "(无)");
            this.mianliao_splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.mianliao_splitContainer_right = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mianliao_label_kehu = new System.Windows.Forms.Label();
            this.mianliao_label_search = new System.Windows.Forms.Label();
            this.mianliao_linkLabel_search = new System.Windows.Forms.LinkLabel();
            this.mianliao_textBox_searchedit = new System.Windows.Forms.TextBox();
            this.mianliao_button_search = new System.Windows.Forms.Button();
            this.mianliao_listView_all = new System.Windows.Forms.ListView();
            this.columnHeader_kuanshi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_fenlei = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_jijie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_xilie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_pinming = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mianliao_button_new = new System.Windows.Forms.Button();
            this.mianliao_label_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mianliao_splitContainer_main)).BeginInit();
            this.mianliao_splitContainer_main.Panel1.SuspendLayout();
            this.mianliao_splitContainer_main.Panel2.SuspendLayout();
            this.mianliao_splitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mianliao_splitContainer_right)).BeginInit();
            this.mianliao_splitContainer_right.Panel1.SuspendLayout();
            this.mianliao_splitContainer_right.Panel2.SuspendLayout();
            this.mianliao_splitContainer_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // mianliao_splitContainer_main
            // 
            this.mianliao_splitContainer_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mianliao_splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mianliao_splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mianliao_splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.mianliao_splitContainer_main.Name = "mianliao_splitContainer_main";
            // 
            // mianliao_splitContainer_main.Panel1
            // 
            this.mianliao_splitContainer_main.Panel1.Controls.Add(this.mianliao_splitContainer_right);
            // 
            // mianliao_splitContainer_main.Panel2
            // 
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.mianliao_listView_all);
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.button4);
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.button3);
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.button2);
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.mianliao_button_new);
            this.mianliao_splitContainer_main.Panel2.Controls.Add(this.mianliao_label_status);
            this.mianliao_splitContainer_main.Size = new System.Drawing.Size(697, 423);
            this.mianliao_splitContainer_main.SplitterDistance = 198;
            this.mianliao_splitContainer_main.TabIndex = 0;
            // 
            // mianliao_splitContainer_right
            // 
            this.mianliao_splitContainer_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mianliao_splitContainer_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mianliao_splitContainer_right.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mianliao_splitContainer_right.Location = new System.Drawing.Point(0, 0);
            this.mianliao_splitContainer_right.Name = "mianliao_splitContainer_right";
            this.mianliao_splitContainer_right.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mianliao_splitContainer_right.Panel1
            // 
            this.mianliao_splitContainer_right.Panel1.Controls.Add(this.treeView1);
            this.mianliao_splitContainer_right.Panel1.Controls.Add(this.mianliao_label_kehu);
            // 
            // mianliao_splitContainer_right.Panel2
            // 
            this.mianliao_splitContainer_right.Panel2.Controls.Add(this.mianliao_label_search);
            this.mianliao_splitContainer_right.Panel2.Controls.Add(this.mianliao_linkLabel_search);
            this.mianliao_splitContainer_right.Panel2.Controls.Add(this.mianliao_textBox_searchedit);
            this.mianliao_splitContainer_right.Panel2.Controls.Add(this.mianliao_button_search);
            this.mianliao_splitContainer_right.Size = new System.Drawing.Size(198, 423);
            this.mianliao_splitContainer_right.SplitterDistance = 181;
            this.mianliao_splitContainer_right.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(2, 23);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "节点1";
            treeNode2.Name = "节点2";
            treeNode2.Text = "节点2";
            treeNode3.Name = "节点0";
            treeNode3.Text = "节点0";
            treeNode4.Name = "节点6";
            treeNode4.Text = "节点6";
            treeNode5.Name = "节点7";
            treeNode5.Text = "节点7";
            treeNode6.Name = "节点3";
            treeNode6.Text = "节点3";
            treeNode7.Name = "节点8";
            treeNode7.Text = "节点8";
            treeNode8.Name = "节点9";
            treeNode8.Text = "节点9";
            treeNode9.Name = "节点4";
            treeNode9.Text = "节点4";
            treeNode10.Name = "节点10";
            treeNode10.Text = "节点10";
            treeNode11.Name = "节点11";
            treeNode11.Text = "节点11";
            treeNode12.Name = "节点5";
            treeNode12.Text = "节点5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(191, 151);
            this.treeView1.TabIndex = 1;
            // 
            // mianliao_label_kehu
            // 
            this.mianliao_label_kehu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mianliao_label_kehu.AutoSize = true;
            this.mianliao_label_kehu.BackColor = System.Drawing.SystemColors.Control;
            this.mianliao_label_kehu.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mianliao_label_kehu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mianliao_label_kehu.Location = new System.Drawing.Point(84, 8);
            this.mianliao_label_kehu.Name = "mianliao_label_kehu";
            this.mianliao_label_kehu.Size = new System.Drawing.Size(31, 12);
            this.mianliao_label_kehu.TabIndex = 0;
            this.mianliao_label_kehu.Text = "客户";
            // 
            // mianliao_label_search
            // 
            this.mianliao_label_search.AutoSize = true;
            this.mianliao_label_search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mianliao_label_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mianliao_label_search.Location = new System.Drawing.Point(86, 4);
            this.mianliao_label_search.Name = "mianliao_label_search";
            this.mianliao_label_search.Size = new System.Drawing.Size(31, 12);
            this.mianliao_label_search.TabIndex = 3;
            this.mianliao_label_search.Text = "搜索";
            // 
            // mianliao_linkLabel_search
            // 
            this.mianliao_linkLabel_search.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.mianliao_linkLabel_search.AutoSize = true;
            this.mianliao_linkLabel_search.Location = new System.Drawing.Point(84, 58);
            this.mianliao_linkLabel_search.Name = "mianliao_linkLabel_search";
            this.mianliao_linkLabel_search.Size = new System.Drawing.Size(53, 12);
            this.mianliao_linkLabel_search.TabIndex = 2;
            this.mianliao_linkLabel_search.TabStop = true;
            this.mianliao_linkLabel_search.Text = "高级搜索";
            // 
            // mianliao_textBox_searchedit
            // 
            this.mianliao_textBox_searchedit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mianliao_textBox_searchedit.Location = new System.Drawing.Point(3, 21);
            this.mianliao_textBox_searchedit.Name = "mianliao_textBox_searchedit";
            this.mianliao_textBox_searchedit.Size = new System.Drawing.Size(190, 21);
            this.mianliao_textBox_searchedit.TabIndex = 1;
            // 
            // mianliao_button_search
            // 
            this.mianliao_button_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mianliao_button_search.Location = new System.Drawing.Point(2, 48);
            this.mianliao_button_search.Name = "mianliao_button_search";
            this.mianliao_button_search.Size = new System.Drawing.Size(75, 23);
            this.mianliao_button_search.TabIndex = 0;
            this.mianliao_button_search.Text = "搜索";
            this.mianliao_button_search.UseVisualStyleBackColor = true;
            // 
            // mianliao_listView_all
            // 
            this.mianliao_listView_all.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.mianliao_listView_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mianliao_listView_all.CheckBoxes = true;
            this.mianliao_listView_all.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_kuanshi,
            this.columnHeader_number,
            this.columnHeader_fenlei,
            this.columnHeader_jijie,
            this.columnHeader_xilie,
            this.columnHeader_total,
            this.columnHeader_pinming});
            this.mianliao_listView_all.FullRowSelect = true;
            this.mianliao_listView_all.GridLines = true;
            this.mianliao_listView_all.HotTracking = true;
            this.mianliao_listView_all.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.mianliao_listView_all.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.mianliao_listView_all.Location = new System.Drawing.Point(8, 54);
            this.mianliao_listView_all.Name = "mianliao_listView_all";
            this.mianliao_listView_all.Size = new System.Drawing.Size(482, 364);
            this.mianliao_listView_all.TabIndex = 3;
            this.mianliao_listView_all.UseCompatibleStateImageBehavior = false;
            this.mianliao_listView_all.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_kuanshi
            // 
            this.columnHeader_kuanshi.Text = "款式图";
            this.columnHeader_kuanshi.Width = 82;
            // 
            // columnHeader_number
            // 
            this.columnHeader_number.Text = "面料编号";
            this.columnHeader_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_number.Width = 78;
            // 
            // columnHeader_fenlei
            // 
            this.columnHeader_fenlei.Text = "面料分类";
            this.columnHeader_fenlei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_fenlei.Width = 77;
            // 
            // columnHeader_jijie
            // 
            this.columnHeader_jijie.Text = "面料季节";
            this.columnHeader_jijie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_jijie.Width = 83;
            // 
            // columnHeader_xilie
            // 
            this.columnHeader_xilie.Text = "系列名称";
            this.columnHeader_xilie.Width = 77;
            // 
            // columnHeader_total
            // 
            this.columnHeader_total.Text = "面料数量";
            this.columnHeader_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader_pinming
            // 
            this.columnHeader_pinming.Text = "品名";
            this.columnHeader_pinming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(233, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "设置列项";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(158, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(83, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "复制";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mianliao_button_new
            // 
            this.mianliao_button_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mianliao_button_new.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mianliao_button_new.Location = new System.Drawing.Point(8, 24);
            this.mianliao_button_new.Name = "mianliao_button_new";
            this.mianliao_button_new.Size = new System.Drawing.Size(75, 23);
            this.mianliao_button_new.TabIndex = 1;
            this.mianliao_button_new.Text = "新建";
            this.mianliao_button_new.UseVisualStyleBackColor = true;
            // 
            // mianliao_label_status
            // 
            this.mianliao_label_status.AutoSize = true;
            this.mianliao_label_status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mianliao_label_status.Location = new System.Drawing.Point(6, 8);
            this.mianliao_label_status.Name = "mianliao_label_status";
            this.mianliao_label_status.Size = new System.Drawing.Size(119, 12);
            this.mianliao_label_status.TabIndex = 0;
            this.mianliao_label_status.Text = "显示所有面料，共0条";
            this.mianliao_label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 面料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(697, 423);
            this.Controls.Add(this.mianliao_splitContainer_main);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "面料";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "面料";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.Load += new System.EventHandler(this.面料_Load);
            this.mianliao_splitContainer_main.Panel1.ResumeLayout(false);
            this.mianliao_splitContainer_main.Panel2.ResumeLayout(false);
            this.mianliao_splitContainer_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mianliao_splitContainer_main)).EndInit();
            this.mianliao_splitContainer_main.ResumeLayout(false);
            this.mianliao_splitContainer_right.Panel1.ResumeLayout(false);
            this.mianliao_splitContainer_right.Panel1.PerformLayout();
            this.mianliao_splitContainer_right.Panel2.ResumeLayout(false);
            this.mianliao_splitContainer_right.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mianliao_splitContainer_right)).EndInit();
            this.mianliao_splitContainer_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mianliao_splitContainer_main;
        private System.Windows.Forms.SplitContainer mianliao_splitContainer_right;
        private System.Windows.Forms.Label mianliao_label_kehu;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox mianliao_textBox_searchedit;
        private System.Windows.Forms.Button mianliao_button_search;
        private System.Windows.Forms.LinkLabel mianliao_linkLabel_search;
        private System.Windows.Forms.Label mianliao_label_search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mianliao_button_new;
        private System.Windows.Forms.Label mianliao_label_status;
        private System.Windows.Forms.ListView mianliao_listView_all;
        public System.Windows.Forms.ColumnHeader columnHeader_kuanshi;
        private System.Windows.Forms.ColumnHeader columnHeader_number;
        private System.Windows.Forms.ColumnHeader columnHeader_fenlei;
        private System.Windows.Forms.ColumnHeader columnHeader_jijie;
        private System.Windows.Forms.ColumnHeader columnHeader_xilie;
        private System.Windows.Forms.ColumnHeader columnHeader_total;
        private System.Windows.Forms.ColumnHeader columnHeader_pinming;



    }
}