using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olmp.Forms;

namespace Olmp.Forms
{
    public partial class viewApp : Form
    {
        public viewApp()
        {
            InitializeComponent();
        }
        public static string email;
        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = email;
            Main.SignIN = true;
            main.Show();
            this.Close();
        }

        private void viewApp_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.appList(email);
            DataTable dt = new DataTable();
            //dt.Load(reader);
            if(gridListApp.Rows.Count != 0)
            {
                gridListApp.Visible = true;
                gridListApp.DataSource = dt;
                gridListApp.Update();
            }
        }
    }
}
