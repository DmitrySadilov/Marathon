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
    public partial class Login : Form
    {
        public static MarADO db = new MarADO();
        public static User USR { get; set; }
        public static Login LOG { get; set; }
        public bool logged = false;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Нужно задать логин и пароль!");
                    return;
                }

                User usr = db.User.Find(textBox1.Text);
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Нужно задать логин и пароль!");
                    return;
                }



                if ((usr != null) && (usr.Password == textBox2.Text))
                {

                    USR = usr;


                    LOG = this;


                    if (usr.RoleId == "A")
                    {
                        AdminMenu am = new AdminMenu();
                        am.Show();
                        this.Close();
                        logged = true;
                    }
                    else if (usr.RoleId == "R")
                    {
                        RunnerMenu rm = new RunnerMenu();
                        rm.Show();
                        this.Close();
                        logged = true;
                    }
                    else if (usr.RoleId == "C")
                    {
                        CoordinatorMenu cm = new CoordinatorMenu();
                        cm.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином и паролем нет!");
                    return;
                }
            
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.Text = "Пожалуйста, авторизируйтесь в системе, используя ваш адрес электронной почты";
            label3.Text = "и пароль.";
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
    }
}
