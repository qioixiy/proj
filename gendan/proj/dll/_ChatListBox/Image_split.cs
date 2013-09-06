using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _CUSTOM_CONTROLS._ChatListBox
{

     class pairs_image
     {
         private string name;
         private int x;
         private int y;
         private int wight;
         private int height;

         public pairs_image(string name, int x = 0, int y = 0, int wight = 0, int height = 0)
         {
             this.name = name;
             this.x = x;
             this.y = y;
             this.wight = wight;
             this.height = height;
         }
     };
    class Image_split
    {
        public static Image Draw(int x, int y, int width = 17, int height = 17)
        {
            Bitmap bitmap = new Bitmap(width, height); //保存绘制图的对象
            Graphics graphics = Graphics.FromImage(bitmap);
            GraphicsUnit units = GraphicsUnit.Pixel;
            Rectangle destRect = new Rectangle(0, 0, width, height); //目标矩形,显示图像的位置
            Rectangle srcRect = new Rectangle(x, y, width, height);  //源矩形,显示图像那一部分
            Image bit = global::_CUSTOM_CONTROLS.Properties.Resources.muneBar_icon;// Image.FromFile("muneBar_icon.png");

            graphics.DrawImage(bit, destRect, srcRect, units);
            return bitmap;
        }
    }
}
