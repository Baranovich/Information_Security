
namespace Inf_Security
{
    partial class firstForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.compairButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.hashLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.firstGroupBox = new System.Windows.Forms.GroupBox();
            this.firstOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.file_hashTextBox = new System.Windows.Forms.TextBox();
            this.file_hashLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.firstGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(137, 153);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(342, 20);
            this.hashTextBox.TabIndex = 0;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(137, 32);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(342, 20);
            this.fileTextBox.TabIndex = 1;
            // 
            // compairButton
            // 
            this.compairButton.Location = new System.Drawing.Point(404, 193);
            this.compairButton.Name = "compairButton";
            this.compairButton.Size = new System.Drawing.Size(75, 23);
            this.compairButton.TabIndex = 2;
            this.compairButton.Text = "Сравнить";
            this.compairButton.UseVisualStyleBackColor = true;
            this.compairButton.Click += new System.EventHandler(this.compairButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(485, 26);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(89, 31);
            this.fileButton.TabIndex = 3;
            this.fileButton.Text = "Выбрать файл";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(12, 153);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(123, 13);
            this.hashLabel.TabIndex = 4;
            this.hashLabel.Text = "Хэш файла на сервере";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(6, 35);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(129, 13);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "Путь к файлу в системе";
            // 
            // firstGroupBox
            // 
            this.firstGroupBox.Controls.Add(this.resultButton);
            this.firstGroupBox.Controls.Add(this.file_hashLabel);
            this.firstGroupBox.Controls.Add(this.file_hashTextBox);
            this.firstGroupBox.Controls.Add(this.fileLabel);
            this.firstGroupBox.Controls.Add(this.hashLabel);
            this.firstGroupBox.Controls.Add(this.fileButton);
            this.firstGroupBox.Controls.Add(this.compairButton);
            this.firstGroupBox.Controls.Add(this.fileTextBox);
            this.firstGroupBox.Controls.Add(this.hashTextBox);
            this.firstGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstGroupBox.Location = new System.Drawing.Point(0, 0);
            this.firstGroupBox.Name = "firstGroupBox";
            this.firstGroupBox.Size = new System.Drawing.Size(584, 228);
            this.firstGroupBox.TabIndex = 6;
            this.firstGroupBox.TabStop = false;
            // 
            // file_hashTextBox
            // 
            this.file_hashTextBox.Location = new System.Drawing.Point(137, 109);
            this.file_hashTextBox.Name = "file_hashTextBox";
            this.file_hashTextBox.Size = new System.Drawing.Size(342, 20);
            this.file_hashTextBox.TabIndex = 6;
            // 
            // file_hashLabel
            // 
            this.file_hashLabel.AutoSize = true;
            this.file_hashLabel.Location = new System.Drawing.Point(34, 112);
            this.file_hashLabel.Name = "file_hashLabel";
            this.file_hashLabel.Size = new System.Drawing.Size(97, 13);
            this.file_hashLabel.TabIndex = 7;
            this.file_hashLabel.Text = "Посчитанный хэш";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(385, 70);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(94, 23);
            this.resultButton.TabIndex = 8;
            this.resultButton.Text = "Вычислить хэш";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // firstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 228);
            this.Controls.Add(this.firstGroupBox);
            this.Name = "firstForm";
            this.Text = "ПРОВЕРКА ХЭША НА СОВПАДЕНИЕ";
            this.Load += new System.EventHandler(this.firstForm_Load);
            this.firstGroupBox.ResumeLayout(false);
            this.firstGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button compairButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.GroupBox firstGroupBox;
        private System.Windows.Forms.OpenFileDialog firstOpenFileDialog;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label file_hashLabel;
        private System.Windows.Forms.TextBox file_hashTextBox;
    }
}

