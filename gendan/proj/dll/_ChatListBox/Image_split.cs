using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _CUSTOM_CONTROLS._ChatListBox
{
    class paris
    {
        public string name;
        public int x;
        public int y;
        public int wight;
        public int height;

        public paris(string name = "", int x = 0, int y = 0, int wight = 17, int height = 17)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.wight = wight;
            this.height = height;
         }
    };

    class pairs_image
    {
        paris[] pariss;

        public pairs_image()
        {
            int width = 18;
            pariss = new paris[] {new paris("订单", 0, width*0), 
            new paris("打样", width*2, 0), 
            new paris("生产", width*4, 0), 
            new paris("出货记录", width*5, 0), 
            new paris("快递记录", width*6, 0), 
            new paris("进度跟踪", width*15, 0), 
            new paris("工作日历", width*21, 0), 
            new paris("面料", width*13, 0), 
            new paris("辅料", width*14, 0), 
            new paris("特殊工艺", width*7, 0), 
            new paris("客户", width*8, 0), 
            new paris("服装厂", width*9, 0), 
            new paris("其他厂商", width*10, 0), 
            new paris("联系人", width*11, 0), 
            new paris("文件库", width*12, 0), 
            };
        }

        //通过名字获取image位置偏移
        public Image get_image_from_name(string name)
        {
            int i = 0;
 
            for (; i < pariss.Length; i++)
            {
                if (pariss[i].name.Equals(name))
                {
                    break;
                }
            }
            return Image_split.DrawOn_muneBar_icon(pariss[i].x, pariss[i].y);
        }
     };

    class Image_split
    {
        public static Image DrawOn_muneBar_icon(int x, int y, int width = 17, int height = 17)
        {
            return Draw(global::_CUSTOM_CONTROLS.Properties.Resources.muneBar_icon, x, y, width, height);
        }

        public static Image DrawOn_table_icon(int x, int y, int width = 7, int height = 7)
        {
            return Draw(global::_CUSTOM_CONTROLS.Properties.Resources.table_icon, x, y, width, height);
        }

        public static Image Draw(Image bm, int x = 0, int y = 0, int width = 17, int height = 17)
        {
            Bitmap bitmap = new Bitmap(width, height); //保存绘制图的对象
            Graphics graphics = Graphics.FromImage(bitmap);
            GraphicsUnit units = GraphicsUnit.Pixel;
            Rectangle destRect = new Rectangle(0, 0, width, height); //目标矩形,显示图像的位置
            Rectangle srcRect = new Rectangle(x, y, width, height);  //源矩形,显示图像那一部分            
            Image bit = bm;

            graphics.DrawImage(bit, destRect, srcRect, units);
            return bitmap;
        }
    }
}