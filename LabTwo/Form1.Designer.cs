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
            this.лКЛБToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЛабораториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1200, 657);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.унивеситетToolStripMenuItem,
            this.studToolStripMenuItem,
            this.исключитьСтудентаToolStripMenuItem,
            this.добавитьПреподавателяToolStripMenuItem,
            this.лКЛБToolStripMenuItem1,
            this.добавитьФакультетToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 217);
            // 
            // унивеситетToolStripMenuItem
            // 
            this.унивеситетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.унивеситетToolStripMenuItem.Name = "унивеситетToolStripMenuItem";
            this.унивеситетToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.унивеситетToolStripMenuItem.Text = "Унивеситет";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.addUniversityToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.dellUniversityToolStripMenuItem_Click);
            // 
            // studToolStripMenuItem
            // 
            this.studToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зачислитьToolStripMenuItem,
            this.исключитьToolStripMenuItem});
            this.studToolStripMenuItem.Name = "studToolStripMenuItem";
            this.studToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.studToolStripMenuItem.Text = "Студенты";
            // 
            // зачислитьToolStripMenuItem
            // 
            this.зачислитьToolStripMenuItem.Name = "зачислитьToolStripMenuItem";
            this.зачислитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.зачислитьToolStripMenuItem.Text = "Зачислить";
            this.зачислитьToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // исключитьToolStripMenuItem
            // 
            this.исключитьToolStripMenuItem.Name = "исключитьToolStripMenuItem";
            this.исключитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.исключитьToolStripMenuItem.Text = "Исключить";
            this.исключитьToolStripMenuItem.Click += new System.EventHandler(this.dellStudentToolStripMenuItem_Click);
            // 
            // исключитьСтудентаToolStripMenuItem
            // 
            this.исключитьСтудентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.уволитьToolStripMenuItem});
            this.исключитьСтудентаToolStripMenuItem.Name = "исключитьСтудентаToolStripMenuItem";
            this.исключитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.исключитьСтудентаToolStripMenuItem.Text = "Преподаватели";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.добавитьToolStripMenuItem.Text = "Принять";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // уволитьToolStripMenuItem
            // 
            this.уволитьToolStripMenuItem.Name = "уволитьToolStripMenuItem";
            this.уволитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.уволитьToolStripMenuItem.Text = "Уволить";
            this.уволитьToolStripMenuItem.Click += new System.EventHandler(this.dellTeacherToolStripMenuItem_Click);
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьToolStripMenuItem,
            this.уволитьToolStripMenuItem1});
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Персонал";
            // 
            // принятьToolStripMenuItem
            // 
            this.принятьToolStripMenuItem.Name = "принятьToolStripMenuItem";
            this.принятьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.принятьToolStripMenuItem.Text = "Принять";
            this.принятьToolStripMenuItem.Click += new System.EventHandler(this.addPersonalToolStripMenuItem_Click);
            // 
            // уволитьToolStripMenuItem1
            // 
            this.уволитьToolStripMenuItem1.Name = "уволитьToolStripMenuItem1";
            this.уволитьToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.уволитьToolStripMenuItem1.Text = "Уволить";
            this.уволитьToolStripMenuItem1.Click += new System.EventHandler(this.dellPersonalToolStripMenuItem1_Click);
            // 
            // лКЛБToolStripMenuItem1
            // 
            this.лКЛБToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЛабораториюToolStripMenuItem,
            this.добавитьToolStripMenuItem2});
            this.лКЛБToolStripMenuItem1.Name = "лКЛБToolStripMenuItem1";
            this.лКЛБToolStripMenuItem1.Size = new System.Drawing.Size(247, 30);
            this.лКЛБToolStripMenuItem1.Text = "ЛК/ЛБ";
            // 
            // добавитьЛабораториюToolStripMenuItem
            // 
            this.добавитьЛабораториюToolStripMenuItem.Name = "добавитьЛабораториюToolStripMenuItem";
            this.добавитьЛабораториюToolStripMenuItem.Size = new System.Drawing.Size(379, 30);
            this.добавитьЛабораториюToolStripMenuItem.Text = "Добавить лабораторию";
            this.добавитьЛабораториюToolStripMenuItem.Click += new System.EventHandler(this.добавитьЛабораториюToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(379, 30);
            this.добавитьToolStripMenuItem2.Text = "Добавить лекционную аудиторию";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.добавитьФакультетToolStripMenuItem.Text = "Добавить факультет";
            this.добавитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.добавитьФакультетToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лКЛБToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лКЛБToolStripMenuItem
            // 
            this.лКЛБToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.лКЛБToolStripMenuItem.Name = "лКЛБToolStripMenuItem";
            this.лКЛБToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.лКЛБToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem лКЛБToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЛабораториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
    }
}

