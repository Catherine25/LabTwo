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
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lectonRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLabaratoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLabaratoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лКЛБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.унивеситетToolStripMenuItem,
            this.добавитьФакультетToolStripMenuItem,
            this.studToolStripMenuItem,
            this.исключитьСтудентаToolStripMenuItem,
            this.добавитьПреподавателяToolStripMenuItem,
            this.лКЛБToolStripMenuItem1,
            this.lectonRoomsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 247);
            // 
            // унивеситетToolStripMenuItem
            // 
            this.унивеситетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.унивеситетToolStripMenuItem.Name = "унивеситетToolStripMenuItem";
            this.унивеситетToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.унивеситетToolStripMenuItem.Text = "University";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.добавитьToolStripMenuItem1.Text = "Add";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.AddUniversityToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.удалитьToolStripMenuItem.Text = "Delete";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DellUniversityToolStripMenuItem_Click);
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.добавитьФакультетToolStripMenuItem.Text = "Faculties";
            this.добавитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // studToolStripMenuItem
            // 
            this.studToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зачислитьToolStripMenuItem,
            this.исключитьToolStripMenuItem});
            this.studToolStripMenuItem.Name = "studToolStripMenuItem";
            this.studToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.studToolStripMenuItem.Text = "Students";
            // 
            // зачислитьToolStripMenuItem
            // 
            this.зачислитьToolStripMenuItem.Name = "зачислитьToolStripMenuItem";
            this.зачислитьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.зачислитьToolStripMenuItem.Text = "Add";
            this.зачислитьToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
            // 
            // исключитьToolStripMenuItem
            // 
            this.исключитьToolStripMenuItem.Name = "исключитьToolStripMenuItem";
            this.исключитьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.исключитьToolStripMenuItem.Text = "Delete";
            this.исключитьToolStripMenuItem.Click += new System.EventHandler(this.DellStudentToolStripMenuItem_Click);
            // 
            // исключитьСтудентаToolStripMenuItem
            // 
            this.исключитьСтудентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.уволитьToolStripMenuItem});
            this.исключитьСтудентаToolStripMenuItem.Name = "исключитьСтудентаToolStripMenuItem";
            this.исключитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.исключитьСтудентаToolStripMenuItem.Text = "Teachers";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.добавитьToolStripMenuItem.Text = "Add";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddTeacherToolStripMenuItem_Click);
            // 
            // уволитьToolStripMenuItem
            // 
            this.уволитьToolStripMenuItem.Name = "уволитьToolStripMenuItem";
            this.уволитьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.уволитьToolStripMenuItem.Text = "Delete";
            this.уволитьToolStripMenuItem.Click += new System.EventHandler(this.DellTeacherToolStripMenuItem_Click);
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.принятьToolStripMenuItem,
            this.уволитьToolStripMenuItem1});
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Personal";
            // 
            // принятьToolStripMenuItem
            // 
            this.принятьToolStripMenuItem.Name = "принятьToolStripMenuItem";
            this.принятьToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.принятьToolStripMenuItem.Text = "Add";
            this.принятьToolStripMenuItem.Click += new System.EventHandler(this.AddPersonalToolStripMenuItem_Click);
            // 
            // уволитьToolStripMenuItem1
            // 
            this.уволитьToolStripMenuItem1.Name = "уволитьToolStripMenuItem1";
            this.уволитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.уволитьToolStripMenuItem1.Text = "Delete";
            this.уволитьToolStripMenuItem1.Click += new System.EventHandler(this.DellPersonalToolStripMenuItem1_Click);
            // 
            // лКЛБToolStripMenuItem1
            // 
            this.лКЛБToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.лКЛБToolStripMenuItem1.Name = "лКЛБToolStripMenuItem1";
            this.лКЛБToolStripMenuItem1.Size = new System.Drawing.Size(240, 30);
            this.лКЛБToolStripMenuItem1.Text = "Labaratories";
            // 
            // lectonRoomsToolStripMenuItem
            // 
            this.lectonRoomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.lectonRoomsToolStripMenuItem.Name = "lectonRoomsToolStripMenuItem";
            this.lectonRoomsToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.lectonRoomsToolStripMenuItem.Text = "Lecton rooms";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // AddLabaratoryToolStripMenuItem
            // 
            this.AddLabaratoryToolStripMenuItem.Name = "AddLabaratoryToolStripMenuItem";
            this.AddLabaratoryToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.AddLabaratoryToolStripMenuItem.Text = "Add";

            // 
            // deleteLabaratoryToolStripMenuItem
            // 
            this.deleteLabaratoryToolStripMenuItem.Name = "deleteLabaratoryToolStripMenuItem";
            this.deleteLabaratoryToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteLabaratoryToolStripMenuItem.Text = "Delete";
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
            this.лКЛБToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.лКЛБToolStripMenuItem.Text = "About";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.оПрограммеToolStripMenuItem.Text = "Creators";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(252, 30);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(252, 30);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
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
        private System.Windows.Forms.ToolStripMenuItem AddLabaratoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLabaratoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectonRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
    }
}

