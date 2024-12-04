using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormReg : Form
    {
        bool _isAddedLogin;
        bool _isAddedPassword;
        bool _isAddedName;
        bool _isAddedSurname;
        bool _isAddedLastName;
        Database Database;
        public FormReg()
        {
            InitializeComponent();
        }

        // Конструктор класса
        private void FormReg_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Database = new Database();
        }

        // Метод для выхода из программы
        private void llExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти",
               "Выход из приложения", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Метод для закрытия формы
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Метод для очистки поля по клику
        private void tbLogin_Click(object sender, EventArgs e)
        {
            if (_isAddedLogin == false)
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
                _isAddedPassword = true;
                tbPassword.Text = String.Empty;
                tbPassword.PasswordChar = '•';
            }
        }

        // Метод для очистки поля по клику
        private void tbName_Click(object sender, EventArgs e)
        {
            if (_isAddedName == false)
            {
                _isAddedName = true;
                tbName.Text = String.Empty;
            }
        }

        // Метод для обработки регистрации в приложении
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (IsPasswordStrong(tbPassword.Text))
            {
                if (IsLoginValid(tbLogin.Text))
                {
                    if (IsNameValid(tbName.Text))
                    {
                        bool Reg = Database.Reg(tbName.Text, tbLogin.Text, tbPassword.Text, tbSurname.Text, tbLastName.Text);

                        if (Reg)
                        {
                            MessageBox.Show("Вы зарегистрированы!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Такой логин уже зарегистрирован!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Имя должно содержать не менее 2 символов", "Ошибка регистрации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Логин должен содержать не менее 4 символов", "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов", "Ошибка регистрации",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для проверки длины пароля
        public bool IsPasswordStrong(string password)
        {
            return password.Length > 7;
        }

        // Метод для проверки длины логина
        public bool IsLoginValid(string login)
        {
            return login.Length > 3;
        }

        // Метод для проверки длины имени
        public bool IsNameValid(string name)
        {
            return name.Length > 1;
        }

        // Метод для очистки поля по клику
        private void tbSurname_Click(object sender, EventArgs e)
        {
            if (_isAddedSurname == false)
            {
                _isAddedSurname = true;
                tbSurname.Text = String.Empty;
            }
        }

        // Метод для очистки поля по клику
        private void tbLastName_Click(object sender, EventArgs e)
        {
            if (_isAddedLastName == false)
            {
                _isAddedLastName = true;
                tbLastName.Text = String.Empty;
            }
        }
    }
}
