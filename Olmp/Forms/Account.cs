using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        public static string email;
        private void Account_Load(object sender, EventArgs e)
        {
           
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            lbl_hi.Text = "Добро";
            if (hours > 6 && hours < 12)
                lbl_hi.Text += "е утро";
            else if (hours > 12 && hours < 18)
                lbl_hi.Text += "го дня";
            else if (hours > 18 && hours < 22)
                lbl_hi.Text += "го вечера";
            else
                lbl_hi.Text += "ой ночи";
            lbl_hi.Text += ", " + email;

            //Random rnd = new Random();
            //string str = String.Empty;
            //int r;
            //char[] ch4r = "abcdefghijklmnopqrstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            //for (int i = 0; i < 64; i++)
            //{
            //    r = rnd.Next(ch4r.Length);
            //    str += ch4r[r];
            //}
            //MessageBox.Show(str);
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = email;
            Main.SignIN = true;
            main.Show();
            this.Close();
        }

        private void btn_applist_Click(object sender, EventArgs e)
        {

        }

        private void btn_addapp_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.SignIN = false;
            main.Show();
            this.Close();
        }
    }
}
