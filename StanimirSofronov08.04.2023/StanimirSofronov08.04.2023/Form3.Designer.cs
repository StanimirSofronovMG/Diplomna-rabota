namespace StanimirSofronov08._04._2023
{
    partial class Form3
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            закъсненияБонусиToolStripMenuItem = new ToolStripMenuItem();
            добавянеНаСлужителToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { изберетеОпцияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(308, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // изберетеОпцияToolStripMenuItem
            // 
            изберетеОпцияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, закъсненияБонусиToolStripMenuItem, добавянеНаСлужителToolStripMenuItem });
            изберетеОпцияToolStripMenuItem.Name = "изберетеОпцияToolStripMenuItem";
            изберетеОпцияToolStripMenuItem.Size = new Size(107, 20);
            изберетеОпцияToolStripMenuItem.Text = "Изберете опция";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(199, 22);
            toolStripMenuItem1.Text = "Резервации";
            // 
            // закъсненияБонусиToolStripMenuItem
            // 
            закъсненияБонусиToolStripMenuItem.Name = "закъсненияБонусиToolStripMenuItem";
            закъсненияБонусиToolStripMenuItem.Size = new Size(199, 22);
            закъсненияБонусиToolStripMenuItem.Text = "Закъснения, бонуси";
            // 
            // добавянеНаСлужителToolStripMenuItem
            // 
            добавянеНаСлужителToolStripMenuItem.Name = "добавянеНаСлужителToolStripMenuItem";
            добавянеНаСлужителToolStripMenuItem.Size = new Size(199, 22);
            добавянеНаСлужителToolStripMenuItem.Text = "Добавяне на служител";
            добавянеНаСлужителToolStripMenuItem.Click += добавянеНаСлужителToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 390);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem закъсненияБонусиToolStripMenuItem;
        private ToolStripMenuItem добавянеНаСлужителToolStripMenuItem;
    }
}