using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Calc
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }
        Database _database;

        // Конструктор класса
        private void FormAuto_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            _database = new Database();
        }

        // Метод для выхода из программы
        private void llExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти", 
                "Выход из приложения",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        bool _isAddedLogin;
        bool _isAddedPassword;

        // Метод для очистки поля по клику
        private void tbLogin_Click(object sender, EventArgs e)
        {
            if(_isAddedLogin == false)
            {
                _isAddedLogin = true;
                tbLogin.Text = String.Empty;
            }      
        }

        // Метод для очистки поля по клику
        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (_isAddedPassword == false)
            {
                _isAddedLogin = true;
                tbPassword.Text = String.Empty;
                tbPassword.PasswordChar = '•';
            }
        }

        // Метод для очистки поля по клику
        private void btnReg_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.ShowDialog();
        }

        // Метод для обработки функционала авторизации
        private void btnAuto_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = _database.Login(tbLogin.Text, tbPassword.Text);
            if (isLoggedIn)
            {
                User.login = tbLogin.Text;
                Database.login = tbLogin.Text;
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные введены неверно","Ошибка авторизации",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Асинхронный метод для демонстрации введенного пароля на короткий промежуток времени
        async private void btnEye_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            for (int i = 0; i < 15; i++, await Task.Delay(50))
            {
                if(i % 2 == 0) 
                {
                    btnEye.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    btnEye.ForeColor = System.Drawing.Color.Red;
                }
            }
            btnEye.ForeColor = System.Drawing.Color.Black;
            tbPassword.PasswordChar = '•';
        }
    }
}
