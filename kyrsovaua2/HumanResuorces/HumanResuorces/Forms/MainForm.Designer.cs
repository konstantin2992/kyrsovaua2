namespace HumanResuorces.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            passportBox = new TextBox();
            nameBox = new TextBox();
            searchButton = new Button();
            resultSearchList = new ListBox();
            employeeBindingSource = new BindingSource(components);
            addnewEmployee = new Button();
            deleteEmployee = new Button();
            reduceStaffButton = new Button();
            prepareOrderButton = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(635, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(216, 26);
            открытьToolStripMenuItem.Text = "&Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(213, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(216, 26);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(216, 26);
            выходToolStripMenuItem.Text = "Вы&ход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(195, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(198, 26);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            опрограммеToolStripMenuItem.Click += опрограммеToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passportBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(searchButton);
            panel1.Location = new Point(24, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 149);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Паспорт";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "Ім'я";
            label1.Click += label1_Click;
            // 
            // passportBox
            // 
            passportBox.BackColor = SystemColors.Control;
            passportBox.BorderStyle = BorderStyle.FixedSingle;
            passportBox.Location = new Point(88, 64);
            passportBox.Name = "passportBox";
            passportBox.Size = new Size(239, 27);
            passportBox.TabIndex = 2;
            // 
            // nameBox
            // 
            nameBox.BackColor = SystemColors.Control;
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Location = new Point(88, 24);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(239, 27);
            nameBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.BackColor = SystemColors.AppWorkspace;
            searchButton.Cursor = Cursors.Hand;
            searchButton.Location = new Point(321, 116);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 0;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // resultSearchList
            // 
            resultSearchList.BackColor = SystemColors.Control;
            resultSearchList.DataSource = employeeBindingSource;
            resultSearchList.DisplayMember = "Name";
            resultSearchList.FormattingEnabled = true;
            resultSearchList.Location = new Point(24, 224);
            resultSearchList.Name = "resultSearchList";
            resultSearchList.Size = new Size(420, 164);
            resultSearchList.TabIndex = 2;
            resultSearchList.SelectedIndexChanged += resultSearchList_SelectedIndexChanged;
            resultSearchList.DoubleClick += resultSearchList_DoubleClick;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // addnewEmployee
            // 
            addnewEmployee.BackColor = SystemColors.AppWorkspace;
            addnewEmployee.Cursor = Cursors.Hand;
            addnewEmployee.Location = new Point(467, 224);
            addnewEmployee.Name = "addnewEmployee";
            addnewEmployee.Size = new Size(149, 29);
            addnewEmployee.TabIndex = 3;
            addnewEmployee.Text = "Додати";
            addnewEmployee.UseVisualStyleBackColor = false;
            addnewEmployee.Click += addnewEmployee_Click;
            // 
            // deleteEmployee
            // 
            deleteEmployee.BackColor = SystemColors.AppWorkspace;
            deleteEmployee.Cursor = Cursors.Hand;
            deleteEmployee.Location = new Point(467, 268);
            deleteEmployee.Name = "deleteEmployee";
            deleteEmployee.Size = new Size(149, 29);
            deleteEmployee.TabIndex = 4;
            deleteEmployee.Text = "Видалити";
            deleteEmployee.UseVisualStyleBackColor = false;
            deleteEmployee.Click += deleteEmployee_Click;
            // 
            // reduceStaffButton
            // 
            reduceStaffButton.BackColor = SystemColors.AppWorkspace;
            reduceStaffButton.Cursor = Cursors.Hand;
            reduceStaffButton.Location = new Point(467, 312);
            reduceStaffButton.Name = "reduceStaffButton";
            reduceStaffButton.Size = new Size(149, 29);
            reduceStaffButton.TabIndex = 5;
            reduceStaffButton.Text = "Пенсійний вік";
            reduceStaffButton.UseVisualStyleBackColor = false;
            reduceStaffButton.Click += reduceStaffButton_Click;
            // 
            // prepareOrderButton
            // 
            prepareOrderButton.BackColor = SystemColors.AppWorkspace;
            prepareOrderButton.Cursor = Cursors.Hand;
            prepareOrderButton.Location = new Point(467, 359);
            prepareOrderButton.Name = "prepareOrderButton";
            prepareOrderButton.Size = new Size(149, 29);
            prepareOrderButton.TabIndex = 6;
            prepareOrderButton.Text = "Сгенерувати наказ";
            prepareOrderButton.UseVisualStyleBackColor = false;
            prepareOrderButton.Click += prepareOrderButton_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(635, 450);
            Controls.Add(prepareOrderButton);
            Controls.Add(reduceStaffButton);
            Controls.Add(deleteEmployee);
            Controls.Add(addnewEmployee);
            Controls.Add(resultSearchList);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(653, 497);
            Name = "MainForm";
            Text = "Керування кадрами";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private TextBox passportBox;
        private TextBox nameBox;
        private Button searchButton;
        private Label label2;
        private ListBox resultSearchList;
        private BindingSource employeeBindingSource;
        private Button addnewEmployee;
        private Button deleteEmployee;
        private Button reduceStaffButton;
        private Button prepareOrderButton;
        private ToolTip toolTip1;
    }
}