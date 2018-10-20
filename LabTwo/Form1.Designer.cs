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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.унивеситетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зачислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исключитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лКЛБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.унивеситетToolStripMenuItem,
            this.studToolStripMenuItem,
            this.исключитьСтудентаToolStripMenuItem,
            this.добавитьПреподавателяToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // унивеситетToolStripMenuItem
            // 
            this.унивеситетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.унивеситетToolStripMenuItem.Name = "унивеситетToolStripMenuItem";
            this.унивеситетToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.унивеситетToolStripMenuItem.Text = "Унивеситет";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.addUniversityToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.dellUniversityToolStripMenuItem_Click);
            // 
            // studToolStripMenuItem
            // 
            this.studToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зачислитьToolStripMenuItem,
            this.исключитьToolStripMenuItem});
            this.studToolStripMenuItem.Name = "studToolStripMenuItem";
            this.studToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studToolStripMenuItem.Text = "Студенты";
            // 
            // зачислитьToolStripMenuItem
            // 
            this.зачислитьToolStripMenuItem.Name = "зачислитьToolStripMenuItem";
            this.зачислитьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.зачислитьToolStripMenuItem.Text = "Зачислить";
            this.зачислитьToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // исключитьToolStripMenuItem
            // 
            this.исключитьToolStripMenuItem.Name = "исключитьToolStripMenuItem";
            this.исключитьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.исключитьToolStripMenuItem.Text = "Исключить";
            this.исключитьToolStripMenuItem.Click += new System.EventHandler(this.dellStudentToolStripMenuItem_Click);
            // 
            // исключитьСтудентаToolStripMenuItem
            // 
            this.исключитьСтудентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.уволитьToolStripMenuItem});
            this.исключитьСтудентаToolStripMenuItem.Name = "исключитьСтудентаToolStripMenuItem";
            this.исключитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.исключитьСтудентаToolStripMenuItem.Text = "Преподаватели";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.добавитьToolStripMenuItem.Text = "Принять";
            // 
            // уволитьToolStripMenuItem
            // 
            this.уволитьToolStripMenuItem.Name = "уволитьToolStripMenuItem";
            this.уволитьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.уволитьToolStripMenuItem.Text = "Уволить";
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьToolStripMenuItem,
            this.уволитьToolStripMenuItem1});
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Персонал";
            // 
            // принятьToolStripMenuItem
            // 
            this.принятьToolStripMenuItem.Name = "принятьToolStripMenuItem";
            this.принятьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.принятьToolStripMenuItem.Text = "Принять";
            // 
            // уволитьToolStripMenuItem1
            // 
            this.уволитьToolStripMenuItem1.Name = "уволитьToolStripMenuItem1";
            this.уволитьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.уволитьToolStripMenuItem1.Text = "Уволить";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лКЛБToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лКЛБToolStripMenuItem
            // 
            this.лКЛБToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.лКЛБToolStripMenuItem.Name = "лКЛБToolStripMenuItem";
            this.лКЛБToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.лКЛБToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Университет";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem лКЛБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исключитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПреподавателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зачислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исключитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem унивеситетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

