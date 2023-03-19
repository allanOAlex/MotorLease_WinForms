using MotorLease.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MotorLease.Client.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            BackgroundImage = Properties.Resources.Background_Main;
            InitializeComponent();
            BackgroundImage = Properties.Resources.Background_Main;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //AppExtension.CompleteAsync();
        }

        private void Login(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new Login();
            login.Show();
            //Hide();
        }

    }
}
