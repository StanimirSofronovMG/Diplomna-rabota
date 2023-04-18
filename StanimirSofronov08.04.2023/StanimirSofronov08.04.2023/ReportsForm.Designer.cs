namespace StanimirSofronov08._04._2023
{
    partial class ReportsForm
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
            Report1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Report1
            // 
            Report1.Location = new Point(12, 12);
            Report1.Name = "Report1";
            Report1.Size = new Size(174, 61);
            Report1.TabIndex = 0;
            Report1.Text = "GetAllShiftsForUser";
            Report1.UseVisualStyleBackColor = true;
            Report1.Click += Report1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(749, 319);
            listBox1.TabIndex = 1;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(Report1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Report1;
        private ListBox listBox1;
    }
}