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
            btnAllShifts = new Button();
            listBoxResult = new ListBox();
            cbUsers = new ComboBox();
            label1 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            restaurantContextBindingSource = new BindingSource(components);
            btnTotalHours = new Button();
            ((System.ComponentModel.ISupportInitialize)restaurantContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAllShifts
            // 
            btnAllShifts.Location = new Point(596, 20);
            btnAllShifts.Name = "btnAllShifts";
            btnAllShifts.Size = new Size(174, 61);
            btnAllShifts.TabIndex = 0;
            btnAllShifts.Text = "GetAllShiftsForUser";
            btnAllShifts.UseVisualStyleBackColor = true;
            btnAllShifts.Click += btnAllShifts_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(22, 95);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(749, 319);
            listBoxResult.TabIndex = 1;
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            cbUsers.Location = new Point(36, 40);
            cbUsers.Margin = new Padding(3, 2, 3, 2);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(133, 23);
            cbUsers.TabIndex = 2;
            cbUsers.SelectedIndexChanged += cbUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 20);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "users:";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(210, 17);
            dateTimePickerFrom.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(160, 23);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(210, 44);
            dateTimePickerTo.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(160, 23);
            dateTimePickerTo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 23);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 48);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 7;
            label3.Text = "to:";
            // 
            // restaurantContextBindingSource
            // 
            restaurantContextBindingSource.DataSource = typeof(DataLayer.RestaurantContext);
            // 
            // btnTotalHours
            // 
            btnTotalHours.Location = new Point(387, 20);
            btnTotalHours.Name = "btnTotalHours";
            btnTotalHours.Size = new Size(180, 61);
            btnTotalHours.TabIndex = 8;
            btnTotalHours.Text = "GetTotalHours";
            btnTotalHours.UseVisualStyleBackColor = true;
            btnTotalHours.Click += btnTotalHours_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(btnTotalHours);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(cbUsers);
            Controls.Add(listBoxResult);
            Controls.Add(btnAllShifts);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)restaurantContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAllShifts;
        private ListBox listBoxResult;
        private ComboBox cbUsers;
        private Label label1;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label2;
        private Label label3;
        private BindingSource restaurantContextBindingSource;
        private Button btnTotalHours;
    }
}