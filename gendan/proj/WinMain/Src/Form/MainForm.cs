﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MenuMain;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menumain = new MenuMain.MenuMain();

            menumain.TopMost = true;
            menumain.Show();
        }

        public MenuMain.MenuMain menumain;
    }
}
