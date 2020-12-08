
namespace Inf_Security
{
    partial class errorForm
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
            this.errorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorButton
            // 
            this.errorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorButton.Location = new System.Drawing.Point(81, 31);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(125, 50);
            this.errorButton.TabIndex = 0;
            this.errorButton.Text = "Файл не найден!";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // errorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.errorButton);
            this.Name = "errorForm";
            this.Text = "Ошибка!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button errorButton;
    }
}