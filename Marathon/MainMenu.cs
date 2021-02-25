using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class MainMenu : Form
    {
        string currenttime = "Москва, Россия " + DateTime.Now.Day + " февраля "+ DateTime.Now.Year;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label4.Text = currenttime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu rm = new RunnerMenu();
            rm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }
    }
}
