namespace StanimirSofronov08._04._2023
{
    partial class MenuForm
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            изберетеОпцияToolStripMenuItem = new ToolStripMenuItem();
            ReservationForm = new ToolStripMenuItem();
            Reports = new ToolStripMenuItem();
            добавянеНаСлужителToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            премахванеНаПотребителToolStripMenuItem = new ToolStripMenuItem();
            vacation = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { изберетеОпцияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(352, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // изберетеОпцияToolStripMenuItem
            // 
            изберетеОпцияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReservationForm, Reports, добавянеНаСлужителToolStripMenuItem, toolStripMenuItem1, премахванеНаПотребителToolStripMenuItem, vacation });
            изберетеОпцияToolStripMenuItem.Name = "изберетеОпцияToolStripMenuItem";
            изберетеОпцияToolStripMenuItem.Size = new Size(137, 24);
            изберетеОпцияToolStripMenuItem.Text = "Изберете опция";
            изберетеОпцияToolStripMenuItem.Click += изберетеОпцияToolStripMenuItem_Click;
            // 
            // ReservationForm
            // 
            ReservationForm.Name = "ReservationForm";
            ReservationForm.Size = new Size(285, 26);
            ReservationForm.Text = "Резервации";
            ReservationForm.Click += toolStripMenuItem1_Click;
            // 
            // Reports
            // 
            Reports.Name = "Reports";
            Reports.Size = new Size(285, 26);
            Reports.Text = "Отчети";
            Reports.Click += Reports_Click;
            // 
            // добавянеНаСлужителToolStripMenuItem
            // 
            добавянеНаСлужителToolStripMenuItem.Name = "добавянеНаСлужителToolStripMenuItem";
            добавянеНаСлужителToolStripMenuItem.Size = new Size(285, 26);
            добавянеНаСлужителToolStripMenuItem.Text = "Добавяне на служител";
            добавянеНаСлужителToolStripMenuItem.Visible = false;
            добавянеНаСлужителToolStripMenuItem.Click += добавянеНаСлужителToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(285, 26);
            toolStripMenuItem1.Text = "Изход";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click_1;
            // 
            // премахванеНаПотребителToolStripMenuItem
            // 
            премахванеНаПотребителToolStripMenuItem.Name = "премахванеНаПотребителToolStripMenuItem";
            премахванеНаПотребителToolStripMenuItem.Size = new Size(285, 26);
            премахванеНаПотребителToolStripMenuItem.Text = "Премахване на потребител";
            премахванеНаПотребителToolStripMenuItem.Click += премахванеНаПотребителToolStripMenuItem_Click;
            // 
            // vacation
            // 
            vacation.Name = "vacation";
            vacation.Size = new Size(285, 26);
            vacation.Text = "Разпределение на отпуски";
            vacation.Click += vacation_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 520);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "Меню";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem изберетеОпцияToolStripMenuItem;
        private ToolStripMenuItem ReservationForm;
        private ToolStripMenuItem Reports;
        private ToolStripMenuItem добавянеНаСлужителToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem премахванеНаПотребителToolStripMenuItem;
        private ToolStripMenuItem vacation;
    }
}