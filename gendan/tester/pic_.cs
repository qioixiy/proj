using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tester
{
    public partial class pic_ : Form
    {
        public pic_()
        {
            InitializeComponent();
        }


        public Image Draw(int x, int y, int width = 17, int height = 17)
        {
            Bitmap bitmap = new Bitmap(width, height); //保存绘制图的对象
            Graphics graphics = Graphics.FromImage(bitmap);
            GraphicsUnit units = GraphicsUnit.Pixel;
            Rectangle destRect = new Rectangle(0, 0, width, height); //目标矩形,显示图像的位置
            Rectangle srcRect = new Rectangle(x, y, width, height);  //源矩形,显示图像那一部分
            Image bit = Image.FromFile("muneBar_icon.png");

            graphics.DrawImage(bit, destRect, srcRect, units);
            return bitmap;
        }
        int x = 0;
        int y = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Draw(x,y);
            y+=18;
            ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Draw(17, 17);
        }
    }
}
