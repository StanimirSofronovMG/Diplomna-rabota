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
            components = new System.ComponentModel.Container();
            Report1 = new Button();
            listBoxResult = new ListBox();
            cbUsers = new ComboBox();
            label1 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            restaurantContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)restaurantContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Report1
            // 
            Report1.Location = new Point(681, 26);
            Report1.Margin = new Padding(3, 4, 3, 4);
            Report1.Name = "Report1";
            Report1.Size = new Size(199, 81);
            Report1.TabIndex = 0;
            Report1.Text = "GetAllShiftsForUser";
            Report1.UseVisualStyleBackColor = true;
            Report1.Click += Report1_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 20;
            listBoxResult.Items.AddRange(new object[] { "aaaa / aaaaa / aaaa", "bbb", "ccc" });
            listBoxResult.Location = new Point(25, 127);
            listBoxResult.Margin = new Padding(3, 4, 3, 4);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(855, 424);
            listBoxResult.TabIndex = 1;
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            cbUsers.Location = new Point(41, 53);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(151, 28);
            cbUsers.TabIndex = 2;
            cbUsers.SelectedIndexChanged += cbUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 3;
            label1.Text = "users:";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(443, 26);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(182, 27);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(443, 73);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(182, 27);
            dateTimePickerTo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 31);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 73);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 7;
            label3.Text = "to:";
            // 
            // restaurantContextBindingSource
            // 
            restaurantContextBindingSource.DataSource = typeof(DataLayer.RestaurantContext);
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(cbUsers);
            Controls.Add(listBoxResult);
            Controls.Add(Report1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)restaurantContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Report1;
        private ListBox listBoxResult;
        private ComboBox cbUsers;
        private Label label1;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label2;
        private Label label3;
        private BindingSource restaurantContextBindingSource;
    }
}