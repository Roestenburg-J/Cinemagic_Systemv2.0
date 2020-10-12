﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RandomProj;

namespace Cinemagic
{
    public partial class Form1 : Form
    {
        private const string USER_NAME = "Admin";
        private const string PASSWORD = "C!n3M@giK";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            try
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                if (username != USER_NAME || password != PASSWORD)
                {
                     MessageBox.Show("Invalid Username or Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You will be redirected to the Main Systems Form", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main sys_form = new Main();
                    sys_form.ShowDialog();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
           

