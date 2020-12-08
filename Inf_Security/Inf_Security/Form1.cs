using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace Inf_Security
{
    public partial class firstForm : Form
    {
        string file;
        string hash;
        string file_hash;

        public firstForm()
        {
            InitializeComponent();
        }

        private void firstForm_Load(object sender, EventArgs e)
        {

        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (firstOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = firstOpenFileDialog.FileName;
            }
        }

        private void compairButton_Click(object sender, EventArgs e)
        {
            hash = hashTextBox.Text;
            file_hash = file_hashTextBox.Text;
            
            secondForm newForm_OK = new secondForm();
            thirdForm newForm_NO = new thirdForm();

            if (String.Compare(hash, file_hash) == 0)
            {
                newForm_OK.Show();
            }
            else
            {
                newForm_NO.Show();
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            file = fileTextBox.Text;
            if (File.Exists(file))
            {
                // Создание обекта DirectoryInfo, который будет представлять указанную директорию.
                var file_inf = new FileInfo(file);
                // Инициализация объектов хэша SHA256.
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    // Создание fileStream (файлового потока) для текущего файла.
                    FileStream fileStream = file_inf.Open(FileMode.Open);
                    // Чтобы быть уверенным, что это  расположено в начале потока.
                    fileStream.Position = 0;
                    // Вычисление хэша от fileStream.
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);
                    
                    file_hash = System.BitConverter.ToString(hashValue).Replace("-","");
                    file_hash = file_hash.Replace("A", "a");
                    file_hash = file_hash.Replace("B", "b");
                    file_hash = file_hash.Replace("C", "c");
                    file_hash = file_hash.Replace("D", "d");
                    file_hash = file_hash.Replace("E", "e");
                    file_hash = file_hash.Replace("F", "f");
                    file_hashTextBox.Text = file_hash;

                    // Закрытие файла.
                    fileStream.Close();
                }
            }
            else
            {
                errorForm newForm_ERROR = new errorForm();
                newForm_ERROR.Show();
            }
        }
    }
}
