using System.Collections.Generic;

namespace FormMain
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chatListBox1 = new _CUSTOM_CONTROLS.ChatListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(166, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "大/小图标";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(166, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
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
            this.button1.Location = new System.Drawing.Point(166, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "闪烁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_mini.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.Black;
            this.btn_mini.Location = new System.Drawing.Point(186, 3);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(23, 23);
            this.btn_mini.TabIndex = 5;
            this.btn_mini.Text = "--";
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(212, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_menu.ForeColor = System.Drawing.Color.Black;
            this.label_menu.Location = new System.Drawing.Point(50, 9);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(65, 12);
            this.label_menu.TabIndex = 7;
            this.label_menu.Text = "跟单主菜单";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsTemplete.Properties.Resources.logo_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.chatListBox1.Location = new System.Drawing.Point(3, 30);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.ScrollArrowBackColor = System.Drawing.Color.WhiteSmoke;
            this.chatListBox1.ScrollSliderDefaultColor = System.Drawing.Color.Silver;
            this.chatListBox1.ScrollSliderDownColor = System.Drawing.Color.DimGray;
            this.chatListBox1.Size = new System.Drawing.Size(238, 507);
            this.chatListBox1.TabIndex = 2;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_DoubleClickSubItem);
            this.chatListBox1.MouseEnterHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseEnterHead);
            this.chatListBox1.MouseLeaveHead += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_MouseLeaveHead);
            this.chatListBox1.Click += new System.EventHandler(this.chatListBox1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(247, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_mini);
            this.Controls.Add(this.chatListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "跟单主菜单";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormMain_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_close;
        private bool mouse_push_status = false;
        private System.Drawing.Point mouse_offset;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

