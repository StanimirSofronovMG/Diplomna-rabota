namespace StanimirSofronov08._04._2023
{
    partial class addEmployee
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            newEmployeeUserName = new Label();
            NewUserPassword = new Label();
            button1 = new Button();
            label1 = new Label();
            AdminButton = new RadioButton();
            EmployeeButton = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 23);
            textBox3.TabIndex = 2;
            // 
            // newEmployeeUserName
            // 
            newEmployeeUserName.AutoSize = true;
            newEmployeeUserName.Location = new Point(6, 107);
            newEmployeeUserName.Name = "newEmployeeUserName";
            newEmployeeUserName.Size = new Size(117, 15);
            newEmployeeUserName.TabIndex = 3;
            newEmployeeUserName.Text = "Потребителско име";
            newEmployeeUserName.Click += label1_Click;
            // 
            // NewUserPassword
            // 
            NewUserPassword.AutoSize = true;
            NewUserPassword.Location = new Point(41, 152);
            NewUserPassword.Name = "NewUserPassword";
            NewUserPassword.Size = new Size(49, 15);
            NewUserPassword.TabIndex = 4;
            NewUserPassword.Text = "Парола";
            // 
            // button1
            // 
            button1.Location = new Point(242, 239);
            button1.Name = "button1";
            button1.Size = new Size(212, 58);
            button1.TabIndex = 5;
            button1.Text = "Създай";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 196);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "Роля";
            // 
            // AdminButton
            // 
            AdminButton.AutoSize = true;
            AdminButton.Location = new Point(160, 192);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(112, 19);
            AdminButton.TabIndex = 7;
            AdminButton.TabStop = true;
            AdminButton.Text = "Администратор";
            AdminButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeButton
            // 
            EmployeeButton.AutoSize = true;
            EmployeeButton.Location = new Point(325, 194);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(80, 19);
            EmployeeButton.TabIndex = 8;
            EmployeeButton.TabStop = true;
            EmployeeButton.Text = "Служител";
            EmployeeButton.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmployeeButton);
            Controls.Add(AdminButton);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(NewUserPassword);
            Controls.Add(newEmployeeUserName);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "addEmployee";
            Text = "addEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Label newEmployeeUserName;
        private Label NewUserPassword;
        private Button button1;
        private Label label1;
        private RadioButton AdminButton;
        private RadioButton EmployeeButton;
    }
}