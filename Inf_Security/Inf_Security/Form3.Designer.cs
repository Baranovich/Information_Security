﻿
namespace Inf_Security
{
    partial class thirdForm
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
            this.notButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notButton
            // 
            this.notButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notButton.Location = new System.Drawing.Point(85, 28);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(125, 50);
            this.notButton.TabIndex = 0;
            this.notButton.Text = "Не совпадают!";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // thirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.ControlBox = false;
            this.Controls.Add(this.notButton);
            this.Name = "thirdForm";
            this.Text = "Результат";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notButton;
    }
}