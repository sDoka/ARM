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
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // showReadybtn
            // 
            this.showReadybtn.Location = new System.Drawing.Point(12, 12);
            this.showReadybtn.Name = "showReadybtn";
            this.showReadybtn.Size = new System.Drawing.Size(81, 50);
            this.showReadybtn.TabIndex = 1;
            this.showReadybtn.Text = "Показать расчитанные заготовки";
            this.showReadybtn.UseVisualStyleBackColor = true;
            // 
            // add_newBtn
            // 
            this.add_newBtn.Location = new System.Drawing.Point(12, 68);
            this.add_newBtn.Name = "add_newBtn";
            this.add_newBtn.Size = new System.Drawing.Size(81, 49);
            this.add_newBtn.TabIndex = 2;
            this.add_newBtn.Text = "Рассчитать новую заготовку";
            this.add_newBtn.UseVisualStyleBackColor = true;
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
            this.dgw1.Location = new System.Drawing.Point(99, 1);
            this.dgw1.MultiSelect = false;
            this.dgw1.Name = "dgw1";
            this.dgw1.ReadOnly = true;
            this.dgw1.RowHeadersVisible = false;
            this.dgw1.RowTemplate.ReadOnly = true;
            this.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw1.Size = new System.Drawing.Size(514, 116);
            this.dgw1.TabIndex = 3;
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 140);
            this.Controls.Add(this.dgw1);
            this.Controls.Add(this.add_newBtn);
            this.Controls.Add(this.showReadybtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateForm";
            this.Text = "Вычисление размера заготовок";
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showReadybtn;
        private System.Windows.Forms.Button add_newBtn;
        private System.Windows.Forms.DataGridView dgw1;
    }
}