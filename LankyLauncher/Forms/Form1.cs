using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LankyLauncher.Models;
using LankyLauncher.Forms;

namespace LankyLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] validation = textBox1.Text.Split(' ');
            if (validation.Length <= 1)
            {
                MessageBox.Show("Kullanıcı Adları Boşluk İçeremez");
            }
            else
            {
                Account User = new Account { UserName = textBox1.Text };
                MainForm app = new MainForm(User);
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
