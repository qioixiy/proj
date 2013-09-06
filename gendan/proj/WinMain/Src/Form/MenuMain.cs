using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;
using _CUSTOM_CONTROLS._ChatListBox;

namespace MenuMain
{
    public partial class MenuMain : Form
    {
        public Color FromMain_color;

        public MenuMain()
        {
            InitializeComponent();
            FromMain_color = Color.LightGray;
        }
        public Form get_class(string typename = "")
        {
            switch (typename)
            {
                case "订单":
                    return new WindowsFormsTemplete.订单();
                case "打样":
                    return new WindowsFormsTemplete.打样();
                case "生产":
                    return new WindowsFormsTemplete.生产();
                case "出货记录":
                    return new WindowsFormsTemplete.出货记录();
                case "快递记录":
                    return new WindowsFormsTemplete.快递记录();
                case "进度跟踪":
                    return new WindowsFormsTemplete.进度跟踪();
                case "工作日历":
                    return new WindowsFormsTemplete.工作日历();
                case "面料":
                    return new WindowsFormsTemplete.面料();
                case "辅料":
                    return new WindowsFormsTemplete.辅料();
                case "特殊工艺":
                    return new WindowsFormsTemplete.特殊工艺();
                case "客户":
                    return new WindowsFormsTemplete.客户();
                case "服装厂":
                    return new WindowsFormsTemplete.服装厂();
                case "其他厂商":
                    return new WindowsFormsTemplete.其他厂商();
                case "联系人":
                    return new WindowsFormsTemplete.联系人();
                case "文件库":
                    return new WindowsFormsTemplete.文件库();

                default:
                    return new WindowsFormsTemplete.其他厂商();
            }
        }
        public static Image getHeadImage(string name)
        {
            switch (name)
            {
                case "订单":
                    return global::WindowsFormsTemplete.Properties.Resources.其他厂商;
                case "打样":
                    return global::WindowsFormsTemplete.Properties.Resources.打样;
                case "生产":
                    return global::WindowsFormsTemplete.Properties.Resources.生产;
                case "出货记录":
                    return global::WindowsFormsTemplete.Properties.Resources.出货记录;
                case "快递记录":
                    return global::WindowsFormsTemplete.Properties.Resources.快递记录;
                case "进度跟踪":
                    return global::WindowsFormsTemplete.Properties.Resources.进度跟踪;
                case "工作日历":
                    return global::WindowsFormsTemplete.Properties.Resources.工作日历;
                case "面料":
                    return global::WindowsFormsTemplete.Properties.Resources.面料;
                case "辅料":
                    return global::WindowsFormsTemplete.Properties.Resources.辅料;
                case "特殊工艺":
                    return global::WindowsFormsTemplete.Properties.Resources.特殊工艺;
                case "客户":
                    return global::WindowsFormsTemplete.Properties.Resources.客户;
                case "服装厂":
                    return global::WindowsFormsTemplete.Properties.Resources.服装厂;
                case "其他厂商":
                    return global::WindowsFormsTemplete.Properties.Resources.其他厂商;
                case "联系人":
                    return global::WindowsFormsTemplete.Properties.Resources.联系人;
                case "文件库":
                    return global::WindowsFormsTemplete.Properties.Resources.文件库;

                default:
                    return global::WindowsFormsTemplete.Properties.Resources.其他厂商;
            }
        }

        private void MenuMain_Load(object sender, EventArgs e)
        {
            Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            //Width = rect.Width;
            Height = rect.Height - 50;
            this.Location = new Point(10, 40);

            TitleItem temp_item = new TitleItem();
            temp_item.MainTitle = "订单管理";
            temp_item.SubItem.Add("订单");
            temp_item.SubItem.Add("打样");
            temp_item.SubItem.Add("生产");
            temp_item.SubItem.Add("出货记录");
            temp_item.SubItem.Add("快递记录");
            title.Add(temp_item);

            temp_item = new TitleItem();
            temp_item.MainTitle = "任务管理";
            temp_item.SubItem.Add("进度跟踪");
            temp_item.SubItem.Add("工作日历");
            title.Add(temp_item);

            temp_item = new TitleItem();
            temp_item.MainTitle = "物料管理";
            temp_item.SubItem.Add("面料");
            temp_item.SubItem.Add("辅料");
            temp_item.SubItem.Add("特殊工艺");
            title.Add(temp_item);

            temp_item = new TitleItem();
            temp_item.MainTitle = "关系管理";
            temp_item.SubItem.Add("客户");
            temp_item.SubItem.Add("服装厂");
            temp_item.SubItem.Add("其他厂商");
            temp_item.SubItem.Add("联系人");
            title.Add(temp_item);

            temp_item = new TitleItem();
            temp_item.MainTitle = "文件库";
            temp_item.SubItem.Add("文件库");
            title.Add(temp_item);

            button1.Text = "闪动";
            button2.Text = "插入[离开]";
            button3.Text = "大/小图标";

            chatListBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < title.Count; i++)
            {
                ChatListItem item = new ChatListItem(title[i].MainTitle);
                for (int j = 0; j < title[i].SubItem.Count; j++)
                {
                    ChatListSubItem subItem = new ChatListSubItem("", title[i].SubItem[j], "");//注释说明
                    subItem.HeadImage = getHeadImage(title[i].SubItem[j]);
                    subItem.Status = (ChatListSubItem.UserStatus)(j % 6);
                    item.SubItems.AddAccordingToStatus(subItem);
                }
                item.SubItems.Sort();
                chatListBox1.Items.Add(item);
            }
            ChatListItem itema = new ChatListItem("TEST");
            for (int i = 0; i < 5; i++)
            {
                chatListBox1.Items.Add(itema);
            }
            chatListBox1.Items.Remove(itema);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatListBox1.Items[0].SubItems[0].IsTwinkle = !chatListBox1.Items[0].SubItems[0].IsTwinkle;
            chatListBox1.Items[0].SubItems[1].IsTwinkle = !chatListBox1.Items[0].SubItems[1].IsTwinkle;
        }

        private void chatListBox1_MouseEnterHead(object sender, ChatListEventArgs e)
        {
            this.Text = e.MouseOnSubItem.DisplayName;
        }

        private void chatListBox1_MouseLeaveHead(object sender, ChatListEventArgs e)
        {
            this.Text = "Null";
        }

        private void chatListBox1_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            //MessageBox.Show(e.SelectSubItem.DisplayName);
            WindowsFormsTemplete.ViewTemplete from = new WindowsFormsTemplete.ViewTemplete(e.SelectSubItem.DisplayName);
            from.Hide();
            from.WindowState = FormWindowState.Normal;
            from.Show();

            //Form form = get_class(e.SelectSubItem.DisplayName);
            //form.Show();
        }

        //插入subitem
        private void button2_Click(object sender, EventArgs e)
        {
            //AddAccordingToStatus根据状态自己插入到正确位置
            //Add就是默认的添加
            //当然也可以用Add添加 然后用SubItem.Sort()进行一个排序
            chatListBox1.Items[0].SubItems.AddAccordingToStatus(
                new ChatListSubItem(
                    123, "nicname", "displayname", "personal message",
                    ChatListSubItem.UserStatus.Away, new Bitmap("head/1 (0).png"))
                );
        }
        //图标类型，大？小？
        private void button3_Click(object sender, EventArgs e)
        {
            if (chatListBox1.IconSizeMode == ChatListItemIcon.Large)
                chatListBox1.IconSizeMode = ChatListItemIcon.Small;
            else
                chatListBox1.IconSizeMode = ChatListItemIcon.Large;
        }

        private void chatListBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            mouse_offset = new Point(cur.X - this.Left, cur.Y - this.Top);

            mouse_push_status = true;
        }

        private void MenuMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_offset = MousePosition;
            mouse_push_status = false;
        }

        private void MenuMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_push_status)
            {
                Point point = new Point(MousePosition.X - mouse_offset.X, MousePosition.Y - mouse_offset.Y);
                this.Location = point;
            }
        }

        private void MenuMain_MouseLeave(object sender, EventArgs e)
        {
            mouse_push_status = false;
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void MenuMain_Paint(object sender, PaintEventArgs e)
        {
            //this.BackColor = Color.Green;

            pictureBox1.BackColor = FromMain_color;
            label_menu.BackColor = FromMain_color;
            this.TransparencyKey = BackColor;

            GraphicsPath myPath = new GraphicsPath();
            int cornerRadius = 4;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            myPath.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            myPath.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            myPath.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            myPath.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            myPath.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            myPath.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            myPath.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            myPath.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);

            Brush brush = new SolidBrush(FromMain_color);
            e.Graphics.FillPath(brush, myPath);
        }

        private void MenuMain_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picbox_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picbox_mini_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter_picbox_mini = true;//进入标志
            this.picbox_mini.Refresh();
        }

        private void picbox_mini_MouseLeave(object sender, EventArgs e)
        {
            mouse_enter_picbox_mini = false;
            this.picbox_mini.Refresh();
        }

        private void picbox_mini_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (mouse_enter_picbox_mini)
            {
                g.Clear(Color.SlateGray);
            }
            else
            {
                g.Clear(FromMain_color);
            }

            Brush b = new SolidBrush(Color.DarkSlateGray);
            g.FillRectangle(b,
                5, this.picbox_mini.Height / 2 - 2,
                this.picbox_mini.Width - 10, 4);
        }
    }
}
