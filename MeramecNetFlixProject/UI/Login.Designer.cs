﻿namespace MeramecNetFlixProject.UI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_uName = new System.Windows.Forms.TextBox();
            this.tb_pWord = new System.Windows.Forms.TextBox();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // tb_uName
            // 
            this.tb_uName.Location = new System.Drawing.Point(53, 6);
            this.tb_uName.Name = "tb_uName";
            this.tb_uName.Size = new System.Drawing.Size(100, 20);
            this.tb_uName.TabIndex = 2;
            // 
            // tb_pWord
            // 
            this.tb_pWord.Location = new System.Drawing.Point(53, 32);
            this.tb_pWord.Name = "tb_pWord";
            this.tb_pWord.Size = new System.Drawing.Size(100, 20);
            this.tb_pWord.TabIndex = 3;
            // 
            // btn_Log
            // 
            this.btn_Log.Location = new System.Drawing.Point(33, 58);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(75, 23);
            this.btn_Log.TabIndex = 4;
            this.btn_Log.Text = "Login";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(33, 87);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 147);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.tb_pWord);
            this.Controls.Add(this.tb_uName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_uName;
        private System.Windows.Forms.TextBox tb_pWord;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_close;
    }
}