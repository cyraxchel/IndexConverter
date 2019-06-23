namespace OldIndexConverter {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьИзБуфераОбменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьTochtmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.командаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.командаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзФайлаToolStripMenuItem,
            this.вставитьИзБуфераОбменаToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьTochtmToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // загрузитьИзФайлаToolStripMenuItem
            // 
            this.загрузитьИзФайлаToolStripMenuItem.Name = "загрузитьИзФайлаToolStripMenuItem";
            this.загрузитьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.загрузитьИзФайлаToolStripMenuItem.Text = "Загрузить из файла";
            // 
            // вставитьИзБуфераОбменаToolStripMenuItem
            // 
            this.вставитьИзБуфераОбменаToolStripMenuItem.Name = "вставитьИзБуфераОбменаToolStripMenuItem";
            this.вставитьИзБуфераОбменаToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.вставитьИзБуфераОбменаToolStripMenuItem.Text = "Вставить из буфера обмена";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // сохранитьTochtmToolStripMenuItem
            // 
            this.сохранитьTochtmToolStripMenuItem.Name = "сохранитьTochtmToolStripMenuItem";
            this.сохранитьTochtmToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сохранитьTochtmToolStripMenuItem.Text = "Сохранить toc.htm";
            // 
            // командаToolStripMenuItem
            // 
            this.командаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конвертироватьToolStripMenuItem});
            this.командаToolStripMenuItem.Name = "командаToolStripMenuItem";
            this.командаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.командаToolStripMenuItem.Text = "Команда";
            // 
            // конвертироватьToolStripMenuItem
            // 
            this.конвертироватьToolStripMenuItem.Name = "конвертироватьToolStripMenuItem";
            this.конвертироватьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.конвертироватьToolStripMenuItem.Text = "Конвертировать";
            this.конвертироватьToolStripMenuItem.Click += new System.EventHandler(this.конвертироватьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.folderPath);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 410);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(768, 347);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вставьте разметку SecureDisk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите одну из папок с изображениями (800, 1024 или 1400):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выбрать...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(423, 378);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(349, 20);
            this.folderPath.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Конвертор индексных файлов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьИзБуфераОбменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьTochtmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem командаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертироватьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

