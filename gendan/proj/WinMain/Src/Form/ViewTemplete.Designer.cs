namespace WindowsFormsTemplete
{
    partial class ViewTemplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTemplete));
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox_typename = new System.Windows.Forms.PictureBox();
            this.label_typename = new System.Windows.Forms.Label();
            this.panelfrom = new System.Windows.Forms.Panel();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_typename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_close.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.Black;
            this.button_close.Location = new System.Drawing.Point(632, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(31, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox_typename
            // 
            this.pictureBox_typename.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_typename.BackgroundImage")));
            this.pictureBox_typename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_typename.Location = new System.Drawing.Point(3, 7);
            this.pictureBox_typename.Name = "pictureBox_typename";
            this.pictureBox_typename.Size = new System.Drawing.Size(32, 23);
            this.pictureBox_typename.TabIndex = 2;
            this.pictureBox_typename.TabStop = false;
            // 
            // label_typename
            // 
            this.label_typename.AutoSize = true;
            this.label_typename.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(150)));
            this.label_typename.Location = new System.Drawing.Point(37, 6);
            this.label_typename.Name = "label_typename";
            this.label_typename.Size = new System.Drawing.Size(79, 15);
            this.label_typename.TabIndex = 3;
            this.label_typename.Text = "typename";
            // 
            // panelfrom
            // 
            this.panelfrom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelfrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelfrom.Location = new System.Drawing.Point(12, 46);
            this.panelfrom.Name = "panelfrom";
            this.panelfrom.Size = new System.Drawing.Size(651, 299);
            this.panelfrom.TabIndex = 4;
            this.panelfrom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfrom_Paint);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_back.Location = new System.Drawing.Point(2, 30);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(670, 320);
            this.pictureBox_back.TabIndex = 5;
            this.pictureBox_back.TabStop = false;
            // 
            // ViewTemplete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(674, 357);
            this.Controls.Add(this.panelfrom);
            this.Controls.Add(this.label_typename);
            this.Controls.Add(this.pictureBox_typename);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox_back);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTemplete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTemplete";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.ViewTemplete_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewTemplete_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewTemplete_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ViewTemplete_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewTemplete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewTemplete_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_typename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Drawing.Point mouse_offset;
        private bool mouse_push_status = false;
        private System.Windows.Forms.PictureBox pictureBox_typename;
        private System.Windows.Forms.Label label_typename;
        public string typename;
        public void set_typename(string str)
        {
            typename = str;
        }
        public void set_pictureBox_typenameBackgroundImage()
        {
            this.pictureBox_typename.BackgroundImage = FormMain.FormMain.getHeadImage(this.typename);
        }

        private System.Windows.Forms.Panel panelfrom;
        private System.Windows.Forms.PictureBox pictureBox_back;
    }
}