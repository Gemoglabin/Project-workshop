﻿namespace Zurnal
{
    partial class Zvit
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblgroup = new System.Windows.Forms.Label();
			this.cmbgroup = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.ForeColor = System.Drawing.SystemColors.Window;
			this.radioButton1.Location = new System.Drawing.Point(181, 86);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(94, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "За тиждень";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.ForeColor = System.Drawing.SystemColors.Window;
			this.radioButton2.Location = new System.Drawing.Point(283, 86);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(84, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "За місяць";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton3.ForeColor = System.Drawing.SystemColors.Window;
			this.radioButton3.Location = new System.Drawing.Point(373, 86);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(94, 17);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "За семестр";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(476, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 31);
			this.button1.TabIndex = 4;
			this.button1.Text = "Сформувати звіт";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(12, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(577, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "_________________________________________________________________________________" +
    "______________";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(34, 133);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(527, 343);
			this.dataGridView1.TabIndex = 7;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "П.І.Б. студента";
			this.Column1.Name = "Column1";
			this.Column1.Width = 400;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Кількість пропущених годин";
			this.Column2.Name = "Column2";
			this.Column2.Width = 80;
			// 
			// lblgroup
			// 
			this.lblgroup.AutoSize = true;
			this.lblgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblgroup.ForeColor = System.Drawing.SystemColors.Window;
			this.lblgroup.Location = new System.Drawing.Point(8, 86);
			this.lblgroup.Name = "lblgroup";
			this.lblgroup.Size = new System.Drawing.Size(56, 16);
			this.lblgroup.TabIndex = 8;
			this.lblgroup.Text = "Група:";
			// 
			// cmbgroup
			// 
			this.cmbgroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbgroup.FormattingEnabled = true;
			this.cmbgroup.Location = new System.Drawing.Point(63, 81);
			this.cmbgroup.Margin = new System.Windows.Forms.Padding(2);
			this.cmbgroup.Name = "cmbgroup";
			this.cmbgroup.Size = new System.Drawing.Size(100, 27);
			this.cmbgroup.TabIndex = 9;
			this.cmbgroup.SelectedIndexChanged += new System.EventHandler(this.cmbgroup_SelectedIndexChanged);
			this.cmbgroup.DropDownStyleChanged += new System.EventHandler(this.DropDownList);
			this.cmbgroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgroup_KeyPress);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(587, 133);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(12, 43);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(325, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "_____________________________________________________";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(11, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Звітність по групам";
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(323, 482);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(153, 31);
			this.button3.TabIndex = 20;
			this.button3.Text = "Зберегти звіт в Excel";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(146, 482);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 31);
			this.button2.TabIndex = 19;
			this.button2.Text = "Зберегти звіт в Word";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(21, 505);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(577, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "_________________________________________________________________________________" +
    "______________";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label5.Image = global::Zurnal.Properties.Resources.backward;
			this.label5.Location = new System.Drawing.Point(541, 9);
			this.label5.MaximumSize = new System.Drawing.Size(48, 48);
			this.label5.MinimumSize = new System.Drawing.Size(48, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 48);
			this.label5.TabIndex = 21;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Zvit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(609, 523);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.cmbgroup);
			this.Controls.Add(this.lblgroup);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(609, 550);
			this.MinimumSize = new System.Drawing.Size(609, 489);
			this.Name = "Zvit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Звітність";
			this.Load += new System.EventHandler(this.Zvit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblgroup;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
	}
}