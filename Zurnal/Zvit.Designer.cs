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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.розкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розкладToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розкладToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // розкладToolStripMenuItem
            // 
            this.розкладToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розкладToolStripMenuItem1});
            this.розкладToolStripMenuItem.Name = "розкладToolStripMenuItem";
            this.розкладToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.розкладToolStripMenuItem.Text = "Розклад";
            // 
            // розкладToolStripMenuItem1
            // 
            this.розкладToolStripMenuItem1.Name = "розкладToolStripMenuItem1";
            this.розкладToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.розкладToolStripMenuItem1.Text = "Розклад";
            this.розкладToolStripMenuItem1.Click += new System.EventHandler(this.розкладToolStripMenuItem1_Click);
            // 
            // Zvit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zvit";
            this.Text = "Zvit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розкладToolStripMenuItem1;
    }
}