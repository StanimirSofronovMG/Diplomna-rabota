namespace StanimirSofronov08._04._2023
{
    partial class DeleteUser
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
            SelectDelete = new ComboBox();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // SelectDelete
            // 
            SelectDelete.FormattingEnabled = true;
            SelectDelete.Location = new Point(94, 134);
            SelectDelete.Name = "SelectDelete";
            SelectDelete.Size = new Size(618, 36);
            SelectDelete.TabIndex = 0;
            SelectDelete.SelectedIndexChanged += SelectDelete_SelectedIndexChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(486, 225);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(244, 72);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Изтрий потребителя";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 567);
            Controls.Add(DeleteBtn);
            Controls.Add(SelectDelete);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox SelectDelete;
        private Button DeleteBtn;
    }
}