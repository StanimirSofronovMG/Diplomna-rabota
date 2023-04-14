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
            // addEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}