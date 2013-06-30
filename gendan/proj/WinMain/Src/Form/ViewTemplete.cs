using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace WindowsFormsTemplete
{
    public partial class ViewTemplete : Form
    {
        public Color FromMain_color;
        public string type_name = "";
        private static Point p_Base = new Point(0,0);
        private static Point p_Form = new Point(0, 0);

        public ViewTemplete(String typename)
        {
            this.type_name = typename;
            set_typename(typename);
            InitializeComponent();
            set_pictureBox_typenameBackgroundImage();
            label_typename.Text = typename;
            FromMain_color = Color.LightGray;
        }

        public Form get_class(string typename = "")
        {
            switch (typename)
            {
                case "订单":
                    return new 订单();
                case "打样":
                    return new 打样();
                case "生产":
                    return new 生产();
                case "出货记录":
                    return new 出货记录();
                case "快递记录":
                    return new 快递记录(); 
                case "进度跟踪":
                    return new 进度跟踪(); 
                case "工作日历":
                    return new 工作日历(); 
                case "面料":
                    return new 面料(); 
                case "辅料":
                    return new 辅料(); 
                case "特殊工艺":
                    return new 特殊工艺(); 
                case "客户":
                    return new 客户();
                case "服装厂":
                    return new 服装厂(); 
                case "其他厂商":
                    return new 其他厂商(); 
                case "联系人":
                    return new 联系人();  
                case "文件库":
                    return new 文件库(); 

                default:
                    return new 其他厂商();
            }    
        }

        private void ViewTemplete_Load(object sender, EventArgs e)
        {
            Form frm = get_class(type_name);
            frm.TopLevel = false; //设置窗体为非顶级窗体
            frm.FormBorderStyle = FormBorderStyle.None;  //设置窗体没有边框

            this.panelfrom.Controls.Add(frm);
            frm.Show();

            this.panelfrom.Size = new System.Drawing.Size(frm.Width, frm.Height);
            Point point_s = this.panelfrom.PointToScreen(new Point(0, 0));
            Point point_p = this.PointToScreen(new Point(0, 0));
            int dx = point_s.X - point_p.X;
            int dy = point_s.Y - point_p.Y;

            //重新设置panel大小
            this.panelfrom.Width = frm.Width;
            this.panelfrom.Height = frm.Height;

            //重新设置窗口大小
            this.Width = 2 * dx + this.panelfrom.Width;
            this.Height = dy + dx + this.panelfrom.Height;

            //重置pictureBox_back大小
            Point point_s1 = this.pictureBox_back.PointToScreen(new Point(0, 0));
            Point point_p1 = this.PointToScreen(new Point(0, 0));
            int dx1 = point_s1.X - point_p1.X;
            int dy1 = point_s1.Y - point_p1.Y;
            this.pictureBox_back.Width = this.Width - 5;
            this.pictureBox_back.Height = this.Height - dy1 - 3;

            //重新设置close在窗口的位置
            this.button_close.Location = (new Point(this.Width - this.button_close.Width - 5, 5));

            //重定位窗口位置
            //
            this.Location = new Point(point_s.X + p_Form.X + p_Base.X,
                                        p_Form.Y +p_Base.Y);
            p_Form.X += 10;
            p_Form.Y += 10;

            if (p_Form.X > 300) {
                p_Form.X = 0;
                p_Base.X += 5;
            }

            if (p_Form.Y > 50) {
                p_Form.Y = 0;
                p_Base.Y += 7;
            }
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewTemplete_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            mouse_offset = new Point(cur.X - this.Left, cur.Y - this.Top);

            mouse_push_status = true;
        }

        private void ViewTemplete_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_push_status)
            {
                Point point = new Point(MousePosition.X - mouse_offset.X, MousePosition.Y - mouse_offset.Y);
                this.Location = point;
            }
        }

        private void ViewTemplete_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_offset = MousePosition;
            mouse_push_status = false;
        }

        private void ViewTemplete_MouseLeave(object sender, EventArgs e)
        {
            mouse_push_status = false;
        }

        private GraphicsPath setPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            myPath.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            myPath.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            myPath.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            myPath.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            myPath.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            myPath.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            myPath.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);

            return myPath;
        }

        private void ViewTemplete_Paint(object sender, PaintEventArgs e)
        {
            pictureBox_typename.BackColor = FromMain_color;
            label_typename.BackColor = FromMain_color;
            this.TransparencyKey = BackColor;


            int cornerRadius = 5;//圆弧半径
            GraphicsPath myPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            Color temp = Color.FromArgb(FromMain_color.A - 20, FromMain_color.R - 30, FromMain_color.G - 30, FromMain_color.B- 30);

            myPath = setPath(rect, cornerRadius);
            e.Graphics.FillPath(new SolidBrush(temp), myPath);

            rect = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            myPath = setPath(rect, cornerRadius);
            e.Graphics.FillPath(new SolidBrush(FromMain_color), myPath);
        }

        private void panelfrom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
