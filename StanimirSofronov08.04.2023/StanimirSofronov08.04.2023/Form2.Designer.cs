namespace StanimirSofronov08._04._2023
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            FirstTableSecondShiftBox = new ComboBox();
            FirstTableFirstShiftBox = new ComboBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BothShiftForDate = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            ExitButton = new Button();
            MenuButton = new Button();
            isLateBox = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(FirstTableSecondShiftBox);
            panel1.Controls.Add(FirstTableFirstShiftBox);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(46, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 380);
            panel1.TabIndex = 0;
            // 
            // FirstTableSecondShiftBox
            // 
            FirstTableSecondShiftBox.FormattingEnabled = true;
            FirstTableSecondShiftBox.Location = new Point(58, 96);
            FirstTableSecondShiftBox.Name = "FirstTableSecondShiftBox";
            FirstTableSecondShiftBox.Size = new Size(121, 23);
            FirstTableSecondShiftBox.TabIndex = 13;
            FirstTableSecondShiftBox.Visible = false;
            FirstTableSecondShiftBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FirstTableFirstShiftBox
            // 
            FirstTableFirstShiftBox.FormattingEnabled = true;
            FirstTableFirstShiftBox.Location = new Point(58, 76);
            FirstTableFirstShiftBox.Name = "FirstTableFirstShiftBox";
            FirstTableFirstShiftBox.Size = new Size(121, 23);
            FirstTableFirstShiftBox.TabIndex = 12;
            FirstTableFirstShiftBox.Visible = false;
            FirstTableFirstShiftBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(426, 189);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(149, 141);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(245, 189);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(149, 141);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(426, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(149, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(245, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "1";
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // BothShiftForDate
            // 
            BothShiftForDate.FormattingEnabled = true;
            BothShiftForDate.ItemHeight = 15;
            BothShiftForDate.Location = new Point(692, 195);
            BothShiftForDate.Name = "BothShiftForDate";
            BothShiftForDate.Size = new Size(191, 229);
            BothShiftForDate.TabIndex = 6;
            BothShiftForDate.SelectedIndexChanged += BothShiftForDate_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(313, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(692, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 38);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Изход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button1_Click;
            // 
            // MenuButton
            // 
            MenuButton.Location = new Point(12, 2);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(142, 38);
            MenuButton.TabIndex = 4;
            MenuButton.Text = "Меню";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // isLateBox
            // 
            isLateBox.FormattingEnabled = true;
            isLateBox.Location = new Point(693, 84);
            isLateBox.Name = "isLateBox";
            isLateBox.Size = new Size(125, 23);
            isLateBox.TabIndex = 5;
            isLateBox.Text = "Закъснение";
            isLateBox.SelectedIndexChanged += isLateBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(720, 172);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 7;
            label1.Text = "Днес на смяна са";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 530);
            Controls.Add(label1);
            Controls.Add(isLateBox);
            Controls.Add(MenuButton);
            Controls.Add(BothShiftForDate);
            Controls.Add(ExitButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Резервации";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private ListBox BothShiftForDate;
        private Button ExitButton;
        private ComboBox FirstTableFirstShiftBox;
        private ComboBox FirstTableSecondShiftBox;
        private Button MenuButton;
        private ComboBox isLateBox;
        private Label label1;
    }
}