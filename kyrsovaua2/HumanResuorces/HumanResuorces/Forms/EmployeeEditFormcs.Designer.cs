namespace HumanResuorces.Forms
{
    partial class EmployeeEditFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cancelButton = new Button();
            okButton = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            birthdateBox = new TextBox();
            dlaBox = new TextBox();
            doeBox = new TextBox();
            salaryBox = new TextBox();
            positionBox = new TextBox();
            departmentBox = new TextBox();
            specialtyBox = new TextBox();
            ededucationBox = new TextBox();
            passportBox = new TextBox();
            nameBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(okButton);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(birthdateBox);
            panel1.Controls.Add(dlaBox);
            panel1.Controls.Add(doeBox);
            panel1.Controls.Add(salaryBox);
            panel1.Controls.Add(positionBox);
            panel1.Controls.Add(departmentBox);
            panel1.Controls.Add(specialtyBox);
            panel1.Controls.Add(ededucationBox);
            panel1.Controls.Add(passportBox);
            panel1.Controls.Add(nameBox);
            panel1.Location = new Point(24, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 294);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.AppWorkspace;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Location = new Point(658, 260);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Відмінити";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.BackColor = SystemColors.AppWorkspace;
            okButton.Cursor = Cursors.Hand;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(544, 260);
            okButton.Name = "okButton";
            okButton.Size = new Size(103, 29);
            okButton.TabIndex = 20;
            okButton.Text = "Підтвердити";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(385, 158);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 19;
            label10.Text = "Дата народження";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(452, 129);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 18;
            label9.Text = "ДОП";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(452, 96);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 17;
            label8.Text = "ДПНР";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(452, 59);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 16;
            label7.Text = "Оклад";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(452, 26);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 15;
            label6.Text = "Позиція";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 155);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 14;
            label5.Text = "Департамент";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 122);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 13;
            label4.Text = "Спеціальність";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(47, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Освіта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(32, 56);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 11;
            label2.Text = "Паспорт";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(65, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 10;
            label1.Text = "Ім'я";
            label1.Click += label1_Click;
            // 
            // birthdateBox
            // 
            birthdateBox.BackColor = SystemColors.Control;
            birthdateBox.Location = new Point(524, 155);
            birthdateBox.Name = "birthdateBox";
            birthdateBox.Size = new Size(238, 27);
            birthdateBox.TabIndex = 9;
            birthdateBox.TextChanged += birthdateBox_TextChanged;
            birthdateBox.Validating += birthdateBox_Validating;
            // 
            // dlaBox
            // 
            dlaBox.BackColor = SystemColors.Control;
            dlaBox.Location = new Point(524, 122);
            dlaBox.Name = "dlaBox";
            dlaBox.Size = new Size(238, 27);
            dlaBox.TabIndex = 8;
            dlaBox.Validating += dlaBox_Validating;
            // 
            // doeBox
            // 
            doeBox.BackColor = SystemColors.Control;
            doeBox.Location = new Point(524, 89);
            doeBox.Name = "doeBox";
            doeBox.Size = new Size(238, 27);
            doeBox.TabIndex = 7;
            doeBox.Validating += doeBox_Validating;
            // 
            // salaryBox
            // 
            salaryBox.BackColor = SystemColors.Control;
            salaryBox.Location = new Point(524, 56);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(238, 27);
            salaryBox.TabIndex = 6;
            salaryBox.Validating += salaryBox_Validating;
            // 
            // positionBox
            // 
            positionBox.BackColor = SystemColors.Control;
            positionBox.Location = new Point(524, 23);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(238, 27);
            positionBox.TabIndex = 5;
            positionBox.Validating += positionBox_Validating;
            // 
            // departmentBox
            // 
            departmentBox.BackColor = SystemColors.Control;
            departmentBox.Location = new Point(114, 155);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(238, 27);
            departmentBox.TabIndex = 4;
            departmentBox.Validating += departmentBox_Validating;
            // 
            // specialtyBox
            // 
            specialtyBox.BackColor = SystemColors.Control;
            specialtyBox.Location = new Point(114, 122);
            specialtyBox.Name = "specialtyBox";
            specialtyBox.Size = new Size(238, 27);
            specialtyBox.TabIndex = 3;
            specialtyBox.Validating += specialtyBox_Validating;
            // 
            // ededucationBox
            // 
            ededucationBox.BackColor = SystemColors.Control;
            ededucationBox.Location = new Point(114, 89);
            ededucationBox.Name = "ededucationBox";
            ededucationBox.Size = new Size(238, 27);
            ededucationBox.TabIndex = 2;
            ededucationBox.Validating += ededucationBox_Validating;
            // 
            // passportBox
            // 
            passportBox.BackColor = SystemColors.Control;
            passportBox.Location = new Point(114, 56);
            passportBox.Name = "passportBox";
            passportBox.Size = new Size(238, 27);
            passportBox.TabIndex = 1;
            passportBox.Validating += passportBox_Validating;
            // 
            // nameBox
            // 
            nameBox.BackColor = SystemColors.Control;
            nameBox.Location = new Point(114, 23);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(238, 27);
            nameBox.TabIndex = 0;
            nameBox.Validating += nameBox_Validating;
            // 
            // EmployeeEditFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(848, 450);
            Controls.Add(panel1);
            MinimumSize = new Size(866, 497);
            Name = "EmployeeEditFormcs";
            Text = "Форма додавання/редагування працівника";
            Load += EmployeeEditFormcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox birthdateBox;
        private TextBox dlaBox;
        private TextBox doeBox;
        private TextBox salaryBox;
        private TextBox positionBox;
        private TextBox departmentBox;
        private TextBox specialtyBox;
        private TextBox ededucationBox;
        private TextBox passportBox;
        private TextBox nameBox;
        private Button cancelButton;
        private Button okButton;
        private Label label5;
    }
}