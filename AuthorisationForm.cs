using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ElectronicBusStation
{
    public partial class AuthorisationForm : Form
    {
        ApplicationContext appdb;
        public AuthorisationForm()
        {
            InitializeComponent();
            appdb = new ApplicationContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            String loginUser = loginBox.Text;
            String passUser = passBox.Text;

            List<User> users1=appdb.users.ToList<User>();
            var y = users1.Find(x => x.Email == loginUser && x.Password == passUser);
            if (y == null) MessageBox.Show("Логин или пароль неверные");
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            String loginUser = loginBox.Text;
            String passUser = passBox.Text;

            List<User> users3 = appdb.users.ToList<User>();
            var p = users3.Find(x => x.Email == loginUser);
            if (p != null) MessageBox.Show("Эта почта уже используется");
            else
            {
                this.Hide();
                appdb.users.Add(new User { Name = "NoName", Surname = "NoSurname", Email = loginUser, Password = passUser });
                appdb.SaveChanges();
                List<User> users2 = appdb.users.ToList<User>();
                var z = users2.Find(x => x.Email == loginUser);
                if (z != null) MessageBox.Show("Успешно!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void VOAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void AuthorisationForm_Load(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
