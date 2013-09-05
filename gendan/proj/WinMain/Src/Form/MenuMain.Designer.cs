using System.Collections.Generic;

namespace MenuMain
{
    partial class MenuMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMain));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbox_mini = new System.Windows.Forms.PictureBox();
            this.chatListBox1 = new _CUSTOM_CONTROLS.ChatListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_mini)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(68, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "大/小图标";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(68, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "插入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(4, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "闪烁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_menu.ForeColor = System.Drawing.Color.Black;
            this.label_menu.Location = new System.Drawing.Point(40, 10);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(43, 13);
            this.label_menu.TabIndex = 7;
            this.label_menu.Text = "主菜单";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsTemplete.Properties.Resources.logo_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // picbox_mini
            // 
            this.picbox_mini.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbox_mini.Location = new System.Drawing.Point(150, 4);
            this.picbox_mini.Name = "picbox_mini";
            this.picbox_mini.Size = new System.Drawing.Size(25, 25);
            this.picbox_mini.TabIndex = 10;
            this.picbox_mini.TabStop = false;
            this.picbox_mini.Click += new System.EventHandler(this.picbox_mini_Click);
            this.picbox_mini.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_mini_Paint);
            this.picbox_mini.MouseEnter += new System.EventHandler(this.picbox_mini_MouseEnter);
            this.picbox_mini.MouseLeave += new System.EventHandler(this.picbox_mini_MouseLeave);
            // 
            // chatListBox1
            // 
            this.chatListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chatListBox1.ArrowColor = System.Drawing.Color.Black;
            this.chatListBox1.BackColor = System.Drawing.Color.White;
            this.chatListBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chatListBox1.ItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chatListBox1.Location = new System.Drawing.Point(3, 33);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.ScrollArrowBackColor = System.Drawing.Color.WhiteSmoke;
            this.chatListBox1.ScrollSliderDefaultColor = System.Drawing.Color.Silver;
            this.chatListBox1.ScrollSliderDownColor = System.Drawing.Color.DimGray;
            this.chatListBox1.Size = new System.Drawing.Size(172, 549);
            this.chatListBox1.TabIndex = 2;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_DoubleClickSubItem);
            this.chatListBox1.MouseEnterHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseEnterHead);
            this.chatListBox1.MouseLeaveHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseLeaveHead);
            this.chatListBox1.Click += new System.EventHandler(this.chatListBox1_Click);
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(183, 595);
            this.Controls.Add(this.picbox_mini);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.chatListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MenuMain";
            this.ShowInTaskbar = false;
            this.Text = "跟单主菜单";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.MenuMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuMain_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MenuMain_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuMain_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_mini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CUSTOM_CONTROLS.ChatListBox chatListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

        class TitleItem
        {
            public string MainTitle = "";
            public List<string> SubItem = new List<string>();
            public TitleItem()
            {

            }
        }

        private List<TitleItem> title = new List<TitleItem>();
        private bool mouse_push_status = false;
        private System.Drawing.Point mouse_offset;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Color col_enter_picbox_close = System.Drawing.Color.PaleGreen;
        private System.Drawing.Color col_leave_picbox_close = System.Drawing.Color.Teal;

        private bool mouse_enter_picbox_mini = false;
        private System.Windows.Forms.PictureBox picbox_mini;
        private System.Drawing.Color col_enter_picbox_mini = System.Drawing.Color.PaleGreen;
        private System.Drawing.Color col_leave_picbox_mini = System.Drawing.Color.Teal;
    }
}

