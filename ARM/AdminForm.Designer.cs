namespace ARM
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.raschet = new System.Windows.Forms.Button();
            this.workers = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findFileBnt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workSessionBtn = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // raschet
            // 
            this.raschet.Location = new System.Drawing.Point(170, 19);
            this.raschet.Name = "raschet";
            this.raschet.Size = new System.Drawing.Size(89, 21);
            this.raschet.TabIndex = 0;
            this.raschet.Text = "Рассчитать";
            this.raschet.UseVisualStyleBackColor = true;
            this.raschet.Click += new System.EventHandler(this.raschet_Click);
            // 
            // workers
            // 
            this.workers.Location = new System.Drawing.Point(146, 19);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(89, 37);
            this.workers.TabIndex = 1;
            this.workers.Text = "Информация по персоналу";
            this.workers.UseVisualStyleBackColor = true;
            this.workers.Click += new System.EventHandler(this.workers_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(10, 19);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(89, 37);
            this.results.TabIndex = 2;
            this.results.Text = "Выполненные работы";
            this.results.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.cb1);
            this.gb1.Controls.Add(this.raschet);
            this.gb1.Location = new System.Drawing.Point(14, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(265, 58);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Расчёты площадей заготовок";
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Зонт конусообразный",
            "Зонт пирамидный",
            "Зонт трапецевидный",
            "Переход центровой",
            "Прямик"});
            this.cb1.Location = new System.Drawing.Point(9, 19);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(155, 21);
            this.cb1.TabIndex = 1;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.workers);
            this.gb2.Controls.Add(this.results);
            this.gb2.Location = new System.Drawing.Point(14, 85);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(265, 61);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Отчёты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findFileBnt);
            this.groupBox1.Location = new System.Drawing.Point(14, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск документов";
            // 
            // findFileBnt
            // 
            this.findFileBnt.Location = new System.Drawing.Point(10, 30);
            this.findFileBnt.Name = "findFileBnt";
            this.findFileBnt.Size = new System.Drawing.Size(89, 25);
            this.findFileBnt.TabIndex = 1;
            this.findFileBnt.Text = "Найти";
            this.findFileBnt.UseVisualStyleBackColor = true;
            this.findFileBnt.Click += new System.EventHandler(this.findFileBnt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workSessionBtn);
            this.groupBox2.Location = new System.Drawing.Point(157, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Учёт рабочего времени";
            // 
            // workSessionBtn
            // 
            this.workSessionBtn.Location = new System.Drawing.Point(10, 30);
            this.workSessionBtn.Name = "workSessionBtn";
            this.workSessionBtn.Size = new System.Drawing.Size(89, 25);
            this.workSessionBtn.TabIndex = 1;
            this.workSessionBtn.Text = "Просмотр";
            this.workSessionBtn.UseVisualStyleBackColor = true;
            this.workSessionBtn.Click += new System.EventHandler(this.workSessionBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.gb1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raschet;
        private System.Windows.Forms.Button workers;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findFileBnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button workSessionBtn;

    }
}