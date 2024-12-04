using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormMain : Form
    {
        Database _database;
        int _baseCurrent = 0;
        int _basePrevius = 0;
        bool _isChecked = false;
        string _currentValue;

        // Конструктор класса
        public FormMain()
        {
            InitializeComponent();
            _database = new Database();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            rbDec.Checked = true;
            tbValue.Focus();
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

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            tbValue.Text = RemoveLeadingZero(tbValue.Text);
        }

        // Метод для удаления нуля в качестве превой цыфры
        public string RemoveLeadingZero(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            if (input[0] == '0')
            {
                return input.Substring(1);
            }

            return input;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'A';
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'B';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'C';
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'D';
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'E';
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbValue.Text += 'F';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbValue.Text += '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbValue.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbValue.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbValue.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbValue.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbValue.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbValue.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbValue.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbValue.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbValue.Text += '9';
        }

        // Метод для обработки функционала шестнадцатиричной системы счисления
        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isChecked)
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
                btn9.Enabled = true;
                btn8.Enabled = true;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _isChecked = true;
                _basePrevius = 16;
                _baseCurrent = 16;
            }
            else
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
                btn9.Enabled = true;
                btn8.Enabled = true;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _basePrevius = _baseCurrent;
                _baseCurrent = 16;
                string result = ConvertNumberBase(tbValue.Text, _basePrevius, _baseCurrent);
                _currentValue = tbValue.Text;
                tbValue.Text = result;
                _database.LoadHistory(_currentValue, _basePrevius.ToString(), result,_baseCurrent.ToString());
                _database.ClearHistory();
            }
        }

        // Метод для обработки функционала десятичной системы счисления
        private void rbDec_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isChecked)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = true;
                btn8.Enabled = true;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _isChecked = true;
                _basePrevius = 10;
                _baseCurrent = 10;
            }
            else
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = true;
                btn8.Enabled = true;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _basePrevius = _baseCurrent;
                _baseCurrent = 10;
                string result = ConvertNumberBase(tbValue.Text, _basePrevius, _baseCurrent);
                _currentValue = tbValue.Text;
                tbValue.Text = result;
                _database.LoadHistory(_currentValue, _basePrevius.ToString(), result, _baseCurrent.ToString());
                _database.ClearHistory();
            }
        }

        // Метод для очискти текстового поля
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbValue.Text = String.Empty;
            _baseCurrent = 0;
            _basePrevius = 0;
            _isChecked = false;
        }

        // Метод для удаления последней цифры из текстового поля
        public string RemoveLastCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, input.Length - 1);
        }

        // Метод для удаления последней цифры из текстового поля
        private void btnBack_Click(object sender, EventArgs e)
        {
            tbValue.Text = RemoveLastCharacter(tbValue.Text);
        }

        // Метод для обработки функционала восьмиричной системы счисления
        private void rbOct_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isChecked)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = false;
                btn8.Enabled = false;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _isChecked = true;
                _basePrevius = 8;
                _baseCurrent = 8;
            }
            else
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = false;
                btn8.Enabled = false;
                btn7.Enabled = true;
                btn6.Enabled = true;
                btn5.Enabled = true;
                btn4.Enabled = true;
                btn3.Enabled = true;
                btn2.Enabled = true;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _basePrevius = _baseCurrent;
                _baseCurrent = 8;
                string result = ConvertNumberBase(tbValue.Text, _basePrevius, _baseCurrent);
                _currentValue = tbValue.Text;
                tbValue.Text = result;
                _database.LoadHistory(_currentValue, _basePrevius.ToString(), result, _baseCurrent.ToString());
                _database.ClearHistory();
            }
        }

        // Метод для обработки функционала двоичной системы счисления
        private void rbBin_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isChecked)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = false;
                btn8.Enabled = false;
                btn7.Enabled = false;
                btn6.Enabled = false;
                btn5.Enabled = false;
                btn4.Enabled = false;
                btn3.Enabled = false;
                btn2.Enabled = false;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _isChecked = true;
                _basePrevius = 2;
                _baseCurrent = 2;
            }
            else
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btn9.Enabled = false;
                btn8.Enabled = false;
                btn7.Enabled = false;
                btn6.Enabled = false;
                btn5.Enabled = false;
                btn4.Enabled = false;
                btn3.Enabled = false;
                btn2.Enabled = false;
                btn1.Enabled = true;
                btn0.Enabled = true;
                _basePrevius = _baseCurrent;
                _baseCurrent = 2;
                string result = ConvertNumberBase(tbValue.Text, _basePrevius, _baseCurrent);
                _currentValue = tbValue.Text;
                tbValue.Text = result;
                _database.LoadHistory(_currentValue, _basePrevius.ToString(), result, _baseCurrent.ToString());
                _database.ClearHistory();
            }
        }

        // Метод для обработки ввода данных в тектовое поле
        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbBin.Checked)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '1'))
                {
                    tbValue.Text += e.KeyChar;
                }
            }
            if (rbOct.Checked)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '7'))
                {
                    tbValue.Text += e.KeyChar;
                }
            }
            if (rbDec.Checked)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
                {
                    tbValue.Text += e.KeyChar;
                }
            }
            if (rbHex.Checked)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '7' || (e.KeyChar >= 'A' && e.KeyChar <= 'F')))
                {
                    tbValue.Text += e.KeyChar;
                }
            }
        }

        // Метод для конвертации числа из одной системы в другую
        public static string ConvertNumberBase(string number, int baseFrom, int baseTo)
        {
            // Перевод числа из исходной системы счисления в десятичную
            int decimalNumber = ConvertFromBaseToDecimal(number, baseFrom);

            // Перевод числа из десятичной системы в целевую систему счисления
            string result = ConvertFromDecimalToBase(decimalNumber, baseTo);

            return result;
        }

        // Метод для перевода числа из исходной системы счисления в десятичную
        private static int ConvertFromBaseToDecimal(string number, int baseFrom)
        {
            int decimalNumber = 0;
            int power = 1;

            // Идем справа налево по числу и умножаем каждую цифру на соответствующую степень основания
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digitValue = DigitValue(number[i]);
                decimalNumber += digitValue * power;
                power *= baseFrom;
            }

            return decimalNumber;
        }

        // Метод для перевода числа из десятичной системы в целевую систему счисления
        private static string ConvertFromDecimalToBase(int decimalNumber, int baseTo)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseTo;
                result = DigitChar(remainder) + result;
                decimalNumber /= baseTo;
            }

            return result;
        }

        // Метод для получения числового значения символа (цифры) в системе счисления
        private static int DigitValue(char digit)
        {
            if (char.IsDigit(digit))
            {
                return (int)(digit - '0');
            }
            else
            {
                return (int)(char.ToUpper(digit) - 'A' + 10);
            }
        }

        // Метод для получения символа (цифры) по числовому значению в системе счисления
        private static char DigitChar(int value)
        {
            if (value < 10)
            {
                return (char)('0' + value);
            }
            else
            {
                return (char)('A' + value - 10);
            }
        }

        // Метод для вывода информации о работе калькулятора
        private void llInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Белое текстовое поле - строка ввода. Сюда нужно вводить число, которое необходимо преобразовать\n" +
                "Радиокнопки слева предназначены для указания системы счисления. HEX - шестнадцатиричное число, DEC - десятичное, OCT - восьмиричное, BIN - двоичное\n" +
                "Например, чтобы перевести десятичное число в шестнадцатиричное, необходимо нажать на кнопку DEC, ввести десятиричное число, а далее нажать на кнопку HEX\n" +
                "Аналогично можно перевести из любой другой системы счисления в иную","Работа калькулятора",MessageBoxButtons.OK);
        }

        // Метод для перехода к форме истории
        private void llMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            formHistory.Show();
            this.Hide();
        }
    }
}
