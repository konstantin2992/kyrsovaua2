using HumanResuorces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HumanResuorces.Forms
{
    public partial class EmployeeEditFormcs : Form
    {
        readonly Employee employee = new Employee();

        public EmployeeEditFormcs(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            nameBox.Text = employee.Name;
            birthdateBox.Text = employee.BirthDate.ToString();
            dlaBox.Text = employee.DLA.ToString();
            doeBox.Text = employee.DOE.ToString();
            salaryBox.Text = employee.Salary.ToString();
            positionBox.Text = employee.Position;
            departmentBox.Text = employee.Department;
            specialtyBox.Text = employee.Specialty;
            ededucationBox.Text = employee.Ededucation;
            passportBox.Text = employee.Passport;

        }
        public EmployeeEditFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeEditFormcs_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                employee.Name = nameBox.Text;
                employee.BirthDate = Convert.ToDateTime(birthdateBox.Text);
                employee.DLA = Convert.ToDateTime(dlaBox.Text);
                employee.DOE = Convert.ToDateTime(doeBox.Text);
                employee.Salary = Convert.ToInt32(salaryBox.Text);
                employee.Position = positionBox.Text;
                employee.Department = departmentBox.Text;
                employee.Specialty = specialtyBox.Text;
                employee.Ededucation = ededucationBox.Text;
                employee.Passport = passportBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Помилка у форматі введення даних. Будь ласка, перевірте введені значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Ім'я не може бути порожнім.");
                e.Cancel = true;
            }
            if (Regex.IsMatch(nameBox.Text.Trim(), @"[0-9]"))
            {
                MessageBox.Show("Поле Ім'я не може містити цифри.");
                e.Cancel = true;
            }
        }

        private void salaryBox_Validating(object sender, CancelEventArgs e)
        {
            if (salaryBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Оклад не може бути порожнім.");
                e.Cancel = true;
            }

            if (Regex.IsMatch(salaryBox.Text.Trim(), @"[а-яА-ЯіІїЇ]", RegexOptions.CultureInvariant))
            {
                MessageBox.Show("Поле Оклад не може містити букви");
                e.Cancel = true;
            }
        }

        private void passportBox_Validating(object sender, CancelEventArgs e)
        {
            if (passportBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Паспорт не може бути порожнім.");
                e.Cancel = true;
            }
            string currentText = passportBox.Text;
            int letterCount = currentText.Count(char.IsLetter);
            int digitCount = currentText.Count(char.IsDigit);

            // Проверка на количество букв и цифр
            if (letterCount > 2 || digitCount > 6)
            {
                // Если количество букв больше 2 или количество цифр больше 6, установка флага ошибки
                e.Cancel = true;
                passportBox.Select(0, passportBox.Text.Length);
                MessageBox.Show("Поле Паспорт має містити не більше 2 літер та 6 цифр.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ededucationBox_Validating(object sender, CancelEventArgs e)
        {
            if (ededucationBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Освіта не може бути порожнім.");
                e.Cancel = true;
            }
        }

        private void specialtyBox_Validating(object sender, CancelEventArgs e)
        {
            if (specialtyBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Спеціальність не може бути порожнім.");
                e.Cancel = true;
            }
        }

        private void departmentBox_Validating(object sender, CancelEventArgs e)
        {
            if (departmentBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Департамент не може бути порожнім.");
                e.Cancel = true;
            }
            if (Regex.IsMatch(departmentBox.Text.Trim(), @"[0-9]"))
            {
                MessageBox.Show("Поле Департамент не може містити цифри.");
                e.Cancel = true;
            }
        }

        private void positionBox_Validating(object sender, CancelEventArgs e)
        {
            if (positionBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Позиція не може бути порожнім.");
                e.Cancel = true;
            }
            if (Regex.IsMatch(positionBox.Text.Trim(), @"[0-9]"))
            {
                MessageBox.Show("Поле Позиція не може містити цифри.");
                e.Cancel = true;
            }
        }

        private void doeBox_Validating(object sender, CancelEventArgs e)
        {
            if (doeBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле ДПНР може бути порожнім.");
                e.Cancel = true;
            }

            if (Regex.IsMatch(doeBox.Text.Trim(), @"[а-яА-ЯіІїЇ]", RegexOptions.CultureInvariant))
            {
                MessageBox.Show("Поле ДПНР не може містити букви");
                e.Cancel = true;
            }
            if (DateTime.TryParse(doeBox.Text, out DateTime DOE))
            {


                if (DOE.Year < 1924)
                {
                    MessageBox.Show("Не коректні данні.");
                    e.Cancel = true;
                }
                else if (DOE.Year > DateTime.Today.Year)
                {
                    MessageBox.Show("Не коректні данні.");
                    e.Cancel = true;
                }
            }
        }

        private void dlaBox_Validating(object sender, CancelEventArgs e)
        {
            if (dlaBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле ДПН може бути порожнім.");
                e.Cancel = true;
            }

            if (Regex.IsMatch(dlaBox.Text.Trim(), @"[а-яА-ЯіІїЇ]", RegexOptions.CultureInvariant))
            {
                MessageBox.Show("Поле ДПН не може містити букви");
                e.Cancel = true;
            }
            if (DateTime.TryParse(dlaBox.Text, out DateTime DLA))
            {


                if (DLA.Year < 1924)
                {
                    MessageBox.Show("Не коректні данні.");
                    e.Cancel = true;
                }
                else if (DLA.Year > DateTime.Today.Year)
                {
                    MessageBox.Show("Не коректні данні.");
                    e.Cancel = true;
                }
            }


        }

        private void birthdateBox_Validating(object sender, CancelEventArgs e)
        {
            if (birthdateBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Поле Дата народження не може бути порожнім.");
                e.Cancel = true;
            }

            if (Regex.IsMatch(birthdateBox.Text.Trim(), @"[а-яА-ЯіІїЇ]", RegexOptions.CultureInvariant))
            {
                MessageBox.Show("Поле Дата народження не може містити букви");
                e.Cancel = true;
            }
            if (DateTime.TryParse(birthdateBox.Text, out DateTime birthDate))
            {
                int age = DateTime.Today.Year - birthDate.Year;
                // Перевіряємо, чи вік в межах встановленого діапазону
                if (age < 18)
                {
                    MessageBox.Show("Співробітник має бути віком від 18 років.");
                    e.Cancel = true;
                }
                else if (age > 80)
                {
                    MessageBox.Show("Співробітник має бути віком до 80 років.");
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Введіть коректний формат дати (наприклад, '01.01.2000').");
                e.Cancel = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
