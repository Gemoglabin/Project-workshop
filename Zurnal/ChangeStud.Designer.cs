namespace Zurnal
{
    partial class ChangeStud
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
			this.tbFIO = new System.Windows.Forms.TextBox();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbFIO
			// 
			this.tbFIO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFIO.Location = new System.Drawing.Point(16, 129);
			this.tbFIO.MaxLength = 60;
			this.tbFIO.Name = "tbFIO";
			this.tbFIO.Size = new System.Drawing.Size(333, 29);
			this.tbFIO.TabIndex = 1;
			// 
			// cbGroup
			// 
			this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(16, 200);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(333, 29);
			this.cbGroup.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(119, 273);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(131, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Зберегти";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Location = new System.Drawing.Point(12, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(205, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "_________________________________";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 40);
			this.label1.TabIndex = 16;
			this.label1.Text = "Редагування даних \r\nобраного студента";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.label7.Location = new System.Drawing.Point(13, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Змінити ПІБ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.label2.Location = new System.Drawing.Point(13, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Змінити групу";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label8.Image = global::Zurnal.Properties.Resources.backward;
			this.label8.Location = new System.Drawing.Point(301, 24);
			this.label8.MaximumSize = new System.Drawing.Size(48, 48);
			this.label8.MinimumSize = new System.Drawing.Size(48, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 48);
			this.label8.TabIndex = 26;
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// ChangeStud
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(372, 336);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbFIO);
			this.Controls.Add(this.cbGroup);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChangeStud";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangeStud";
			this.Load += new System.EventHandler(this.ChangeStud_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cbGroup;
        public System.Windows.Forms.TextBox tbFIO;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label8;
	}
}