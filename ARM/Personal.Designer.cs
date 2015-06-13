namespace ARM
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.Print = new System.Windows.Forms.Button();
            this.excel_our = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AllowUserToAddRows = false;
            this.dgw1.AllowUserToDeleteRows = false;
            this.dgw1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.GridColor = System.Drawing.SystemColors.Control;
            this.dgw1.Location = new System.Drawing.Point(12, 10);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.RowTemplate.ReadOnly = true;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw1.Size = new System.Drawing.Size(829, 159);
            this.dgw1.TabIndex = 0;
            this.dgw1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw1_MouseDown);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(644, 175);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(87, 38);
            this.Print.TabIndex = 1;
            this.Print.Text = "Печать";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Visible = false;
            // 
            // excel_our
            // 
            this.excel_our.Location = new System.Drawing.Point(752, 175);
            this.excel_our.Name = "excel_our";
            this.excel_our.Size = new System.Drawing.Size(89, 38);
            this.excel_our.TabIndex = 2;
            this.excel_our.Text = "Экспорт в Excel";
            this.excel_our.UseVisualStyleBackColor = true;
            this.excel_our.Click += new System.EventHandler(this.excel_our_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(29, 192);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 225);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.excel_our);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.dgw1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button excel_our;
        private System.Windows.Forms.Button backBtn;
    }
}