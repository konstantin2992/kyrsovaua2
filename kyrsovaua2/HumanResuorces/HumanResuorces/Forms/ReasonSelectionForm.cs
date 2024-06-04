using HumanResuorces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResuorces.Forms
{
    public partial class ReasonSelectionForm : Form
    {
        // Список причин звільнення
        private List<TerminationReason> terminationReasons = new List<TerminationReason>();

        // Властивість для зберігання вибраної причини звільнення
        public string SelectedReason { get; internal set; }

        public ReasonSelectionForm()
        {
            InitializeComponent();

            // Додавання причин звільнення в список
            terminationReasons.Add(new TerminationReason("Звільнення за власним бажанням"));
            terminationReasons.Add(new TerminationReason("Звільнення зі скорочення штату"));
            terminationReasons.Add(new TerminationReason("Звільнення у зв'язку з порушенням трудової дисципліни"));
            terminationReasons.Add(new TerminationReason("Звільнення в зв'язку з досягненням пенсійного віку"));

            // Прив'язка списку причин звільнення до ComboBox
            reasonComboBox.DataSource = terminationReasons;
            reasonComboBox.DisplayMember = "Reason";
        }

        // Обробка події натискання кнопки OK
        private void button1_Click(object sender, EventArgs e)
        {
            // Зберігання вибраної причини звільнення
            SelectedReason = reasonComboBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    // Клас для зберігання причин звільнення
    internal class TerminationReason
    {
        public string Reason { get; set; }

        public TerminationReason(string reason)
        {
            Reason = reason;
        }

        public override string ToString()
        {
            return Reason;
        }
    }
}