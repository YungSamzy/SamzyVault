﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI;
using MetroSet_UI.Forms;

namespace SamzyVault
{
    public partial class Login : MetroSetForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void SamzyVault_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            string bruh = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string shhhh = File.ReadAllText($@"{bruh}/9e5197fbc04c87701ce8d84a0b679c34");
            if (metroSetTextBox1.Text == AES.shhhh(shhhh))
            {
                MessageBox.Show("Logged In Successfully!", "SamzyVault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Viewer f1 = new Viewer();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password!", "SamzyVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Silver;
        }
    }
}