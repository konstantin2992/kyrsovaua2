namespace HumanResuorces.Forms
{
    partial class ReasonSelectionForm
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
            reasonComboBox = new ComboBox();
            reasonSelectionFormBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)reasonSelectionFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // reasonComboBox
            // 
            reasonComboBox.DataSource = reasonSelectionFormBindingSource;
            reasonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            reasonComboBox.FormattingEnabled = true;
            reasonComboBox.Location = new Point(12, 55);
            reasonComboBox.Name = "reasonComboBox";
            reasonComboBox.Size = new Size(488, 28);
            reasonComboBox.TabIndex = 0;
            // 
            // reasonSelectionFormBindingSource
            // 
            reasonSelectionFormBindingSource.DataSource = typeof(ReasonSelectionForm);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(428, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReasonSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(530, 231);
            Controls.Add(button1);
            Controls.Add(reasonComboBox);
            Name = "ReasonSelectionForm";
            Text = "Причина звільненя";
            ((System.ComponentModel.ISupportInitialize)reasonSelectionFormBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox reasonComboBox;
        private Button button1;
        private BindingSource reasonSelectionFormBindingSource;
    }
}