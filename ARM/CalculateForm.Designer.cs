namespace ARM
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            this.showReadybtn = new System.Windows.Forms.Button();
            this.add_newBtn = new System.Windows.Forms.Button();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.l1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.ll1 = new System.Windows.Forms.LinkLabel();
            this.res_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReadybtn
            // 
            this.showReadybtn.Location = new System.Drawing.Point(12, 86);
            this.showReadybtn.Name = "showReadybtn";
            this.showReadybtn.Size = new System.Drawing.Size(81, 50);
            this.showReadybtn.TabIndex = 1;
            this.showReadybtn.Text = "Показать/скрыть расчитанные заготовки";
            this.showReadybtn.UseVisualStyleBackColor = true;
            this.showReadybtn.Click += new System.EventHandler(this.showReadybtn_Click);
            // 
            // add_newBtn
            // 
            this.add_newBtn.Location = new System.Drawing.Point(12, 12);
            this.add_newBtn.Name = "add_newBtn";
            this.add_newBtn.Size = new System.Drawing.Size(81, 32);
            this.add_newBtn.TabIndex = 2;
            this.add_newBtn.Text = "Расчитать";
            this.add_newBtn.UseVisualStyleBackColor = true;
            this.add_newBtn.Click += new System.EventHandler(this.add_newBtn_Click);
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
            this.dgw1.Location = new System.Drawing.Point(99, 12);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.RowTemplate.ReadOnly = true;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw1.Size = new System.Drawing.Size(690, 124);
            this.dgw1.TabIndex = 3;
            this.dgw1.Visible = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(125, 17);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 13);
            this.l1.TabIndex = 4;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(128, 41);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(67, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(225, 63);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(67, 20);
            this.tb2.TabIndex = 7;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(222, 44);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 13);
            this.l2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(330, 86);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(67, 20);
            this.tb3.TabIndex = 9;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(327, 70);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 13);
            this.l3.TabIndex = 8;
            // 
            // ll1
            // 
            this.ll1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ll1.AutoSize = true;
            this.ll1.Location = new System.Drawing.Point(416, 123);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(0, 13);
            this.ll1.TabIndex = 10;
            this.ll1.TabStop = true;
            // 
            // res_lbl
            // 
            this.res_lbl.AutoSize = true;
            this.res_lbl.Location = new System.Drawing.Point(303, 123);
            this.res_lbl.Name = "res_lbl";
            this.res_lbl.Size = new System.Drawing.Size(0, 13);
            this.res_lbl.TabIndex = 11;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 48);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(81, 32);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "Запомнить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 149);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.res_lbl);
            this.Controls.Add(this.ll1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.add_newBtn);
            this.Controls.Add(this.showReadybtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление размера заготовок";
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showReadybtn;
        private System.Windows.Forms.Button add_newBtn;
        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.LinkLabel ll1;
        private System.Windows.Forms.Label res_lbl;
        private System.Windows.Forms.Button save_btn;
    }
}