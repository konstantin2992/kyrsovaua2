using HumanResuorces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResuorces.Forms
{
    public partial class MainForm : Form
    {

        List list = new List();
        public MainForm()
        {
            InitializeComponent();
            addnewEmployee.Enabled = false;
            deleteEmployee.Enabled = false;
            reduceStaffButton.Enabled = false;
            prepareOrderButton.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Виклик методу пошуку з текстових полів nameBox та passportBox
            var result = list.Search(nameBox.Text, passportBox.Text);

            // Оновлення джерела даних результатами пошуку
            employeeBindingSource.DataSource = result;
        }

        private void resultSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultSearchList_DoubleClick(object sender, EventArgs e)
        {
            // Перевірка наявності вибраного елемента у списку
            if (resultSearchList.SelectedItems.Count > 0)
            {
                // Отримання вибраного елемента
                object selectedItem = resultSearchList.SelectedItem;

                // Перевірка, чи вибраний елемент не є null
                if (selectedItem != null)
                {
                    // Перетворення вибраного елемента на об'єкт Employee
                    Employee employee = selectedItem as Employee;

                    // Відкриття форми редагування співробітника
                    var dialog = new EmployeeEditFormcs(employee);

                    // Обробка результату діалогу
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Оновлення списку після редагування співробітника
                        searchButton_Click(null, null);
                    }
                }
            }
        }
        const string PATH_TO_DATA = ".//employee.txt";
        // Обробник події для збереження даних у файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.Employees.Count > 0)
            {
                // Виклик методу для збереження даних
                list.SaveData(PATH_TO_DATA);
            }
            else
            {
                MessageBox.Show("Список співробітників порожній. Не можна зберегти порожній файл.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник події для завантаження даних з файлу
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Виклик методу для завантаження даних
            list = list.LoadData(PATH_TO_DATA);
            addnewEmployee.Enabled = true;
            deleteEmployee.Enabled = true;
            reduceStaffButton.Enabled = true;
            prepareOrderButton.Enabled = true;
        }

        private void addnewEmployee_Click(object sender, EventArgs e)
        {
            // Створення нового об'єкта співробітника
            Employee newEmployee = new Employee();

            // Відкриття форми редагування співробітника
            var dialog = new EmployeeEditFormcs(newEmployee);

            // Обробка результату діалогу
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Додавання нового співробітника до списку
                list.Employees.Add(newEmployee);

                // Оновлення списку після додавання нового співробітника
                searchButton_Click(null, null);
            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            // Перевірка наявності вибраного елемента у списку
            if (resultSearchList.SelectedItems.Count > 0)
            {
                // Отримання вибраного елемента
                object selectedItem = resultSearchList.SelectedItem;

                // Перевірка, чи вибраний елемент не є null
                if (selectedItem != null)
                {
                    // Підтвердження видалення
                    var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити цього співробітника?",
                                                        "Підтвердження видалення",
                                                         MessageBoxButtons.YesNo);

                    // Видалення співробітника при підтвердженні
                    if (confirmResult == DialogResult.Yes)
                    {
                        list.Employees.Remove(selectedItem as Employee);

                        // Оновлення списку після видалення співробітника
                        searchButton_Click(null, null);
                    }
                }
            }
        }

        private void reduceStaffButton_Click(object sender, EventArgs e)
        {


            int retirementAge = 60;


            var retirementCandidates = list.SelectForRetirement(retirementAge);


            employeeBindingSource.DataSource = retirementCandidates;
        }

        private void prepareOrderButton_Click(object sender, EventArgs e)
        {
            // Перевірка наявності вибраного співробітника
            if (resultSearchList.SelectedItems.Count > 0)
            {
                // Отримання вибраного співробітника
                Employee employee = resultSearchList.SelectedItem as Employee;

                // Створення форми для вибору причини звільнення
                var reasonSelectionForm = new ReasonSelectionForm();
                if (reasonSelectionForm.ShowDialog() == DialogResult.OK)
                {
                    // Отримання вибраної причини звільнення
                    string selectedReason = reasonSelectionForm.SelectedReason;

                    // Генерація наказу з урахуванням вибраної причини
                    string order = list.GenerateOrder(employee, selectedReason);

                    // Відображення наказу (наприклад, у MessageBox або збереження у файл)
                    MessageBox.Show(order, "Наказ");

                    // Збереження наказу у файл
                    SaveOrderToFile(order);
                }
            }
        }

        private void SaveOrderToFile(string order)
        {
            // Пропозиція користувачу вибрати місце для збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save an Order File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Збереження наказу у вибраний файл
                File.WriteAllText(saveFileDialog.FileName, order);
            }
        }
        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string notificationText = "Ця програма призначена для управління інформацією про співробітників компанії.\n\n" +
                                          "Для початку, виберіть 'Файл' у верхній панелі, а потім натисніть кнопку 'Відкрити', " +
                                          "щоб завантажити базу даних зі списком співробітників. Для відображення списку вам треба " +
                                          "натиснути кнопку 'Пошук'. У вікні програми також доступні такі функції: 'Додати', 'Видалити', " +
                                          "'Пенсійний вік' і 'Сгенерувати наказ'.\n\n" +
                                          "'Додати' дозволяє додавати нових співробітників; 'Видалити' — видаляти їх з бази даних. " +
                                          "'Пенсійний вік' сортує співробітників, які досягли пенсійного віку і старше. " +
                                          "'Сгенерувати наказ' відкриває вікно вибору причини звільнення, а після підтвердження — " +
                                          "вікно перегляду наказу. Після натискання кнопки 'Підтвердити' буде надана можливість " +
                                          "зберегти наказ у файлі формату .txt.\n\n" +
                                          "Подвійний клік по співробітнику у списку відкриває вікно з інформацією про нього, " +
                                          "яку можна редагувати.\n\n" +
                                          "Після завершення всіх операцій користувача, якщо не було помилок, треба вибрати 'Файл' " +
                                          "у меню і натиснути кнопку 'Зберегти', щоб зберегти всі зміни у файл. Після цього можна " +
                                          "закривати програму.";

            MessageBox.Show(notificationText, "Інформація про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}


