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

namespace Calc
{
    public partial class FormHistory : Form
    {
        Database _database;
        public FormHistory()
        {
            InitializeComponent();
        }

        // Выход из программы
        private void llExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти",
               "Выход из приложения", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Метод для возвращения к форме калькулятора
        private void llCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        // Инициализатор формы
        private void FormHistory_Load(object sender, EventArgs e)
        {
            _database = new Database();
            ControlBox = false;
            // При инициализации формы, данные из бд вносятся в датагрид
            _database.LoadData(dgvData);
        }
    }
}
