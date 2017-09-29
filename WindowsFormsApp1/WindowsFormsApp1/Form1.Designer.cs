namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLprMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.критерииКачестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLprMenu,
            this.альтернативаToolStripMenuItem,
            this.критерииКачестваToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // AddLprMenu
            // 
            this.AddLprMenu.Name = "AddLprMenu";
            this.AddLprMenu.Size = new System.Drawing.Size(178, 22);
            this.AddLprMenu.Text = "ЛПР";
            this.AddLprMenu.Click += new System.EventHandler(this.лПРToolStripMenuItem_Click);
            // 
            // альтернативаToolStripMenuItem
            // 
            this.альтернативаToolStripMenuItem.Name = "альтернативаToolStripMenuItem";
            this.альтернативаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.альтернативаToolStripMenuItem.Text = "Альтернатива";
            this.альтернативаToolStripMenuItem.Click += new System.EventHandler(this.альтернативаToolStripMenuItem_Click);
            // 
            // критерииКачестваToolStripMenuItem
            // 
            this.критерииКачестваToolStripMenuItem.Name = "критерииКачестваToolStripMenuItem";
            this.критерииКачестваToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.критерииКачестваToolStripMenuItem.Text = "Критерии качества";
            this.критерииКачестваToolStripMenuItem.Click += new System.EventHandler(this.критерииКачестваToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 363);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Не дефолтное название";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddLprMenu;
        private System.Windows.Forms.ToolStripMenuItem альтернативаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem критерииКачестваToolStripMenuItem;
    }
}

