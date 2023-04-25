namespace StanimirSofronov08._04._2023
{
    partial class VacationForm
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
            cbUsersVacation = new ComboBox();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            btnVacation = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            checkBoxVacation = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            listBoxVacation = new ListBox();
            SuspendLayout();
            // 
            // cbUsersVacation
            // 
            cbUsersVacation.FormattingEnabled = true;
            cbUsersVacation.Location = new Point(46, 84);
            cbUsersVacation.Name = "cbUsersVacation";
            cbUsersVacation.Size = new Size(151, 28);
            cbUsersVacation.TabIndex = 0;
            cbUsersVacation.SelectedIndexChanged += cbUsersVacation_SelectedIndexChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.ImeMode = ImeMode.NoControl;
            dateTimePickerFrom.Location = new Point(267, 57);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.ImeMode = ImeMode.NoControl;
            dateTimePickerTo.Location = new Point(267, 122);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 2;
            // 
            // btnVacation
            // 
            btnVacation.Location = new Point(696, 57);
            btnVacation.Name = "btnVacation";
            btnVacation.Size = new Size(160, 113);
            btnVacation.TabIndex = 4;
            btnVacation.Text = "vacation";
            btnVacation.UseVisualStyleBackColor = true;
            btnVacation.Click += btnVacation_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // checkBoxVacation
            // 
            checkBoxVacation.AutoSize = true;
            checkBoxVacation.Location = new Point(548, 102);
            checkBoxVacation.Name = "checkBoxVacation";
            checkBoxVacation.Size = new Size(69, 24);
            checkBoxVacation.TabIndex = 6;
            checkBoxVacation.Text = "IsPaid";
            checkBoxVacation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 29);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 99);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 8;
            label2.Text = "to";
            // 
            // listBoxVacation
            // 
            listBoxVacation.FormattingEnabled = true;
            listBoxVacation.ItemHeight = 20;
            listBoxVacation.Location = new Point(212, 207);
            listBoxVacation.Name = "listBoxVacation";
            listBoxVacation.Size = new Size(438, 284);
            listBoxVacation.TabIndex = 9;
            // 
            // VacationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 600);
            Controls.Add(listBoxVacation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxVacation);
            Controls.Add(btnVacation);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(cbUsersVacation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VacationForm";
            Text = "VacationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUsersVacation;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button btnVacation;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private CheckBox checkBoxVacation;
        private Label label1;
        private Label label2;
        private ListBox listBoxVacation;
    }
}