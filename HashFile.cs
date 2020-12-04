using System;
using System.IO;
using System.Security.Cryptography;

public class HashFile
{
    public static void Main(String[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("No directory selected.");
            return;
        }

        string file = args[0];
        if (File.Exists(file))
        {
            // Создание обекта DirectoryInfo, который будет представлять указанную директорию.
           var file_inf = new FileInfo(file);
            // Инициализация объектов хэша SHA256.
            using (SHA256 mySHA256 = SHA256.Create())
            {
                // Вычисление и печать значения хэша для каждого файла в директории.
                try {
                    // Создание fileStream (файлового потока) для текущего файла.
                    FileStream fileStream = file_inf.Open(FileMode.Open);
                    // Чтобы быть уверенным, что это  расположено в начале потока.
                    fileStream.Position = 0;
                    // Вычисление хэша от fileStream.
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);
                    // Вывсти имя и значение хэша файла в консоль.
                    Console.Write($"{file_inf.Name}: ");
                    PrintByteArray(hashValue);
                    // Закрытие файла.
                    fileStream.Close();
                }
                catch (IOException e) {
                    Console.WriteLine($"I/O Exception: {e.Message}");
                }
                catch (UnauthorizedAccessException e) {
                    Console.WriteLine($"Access Exception: {e.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine("The file specified could not be found.");
        }
    }

    // Display the byte array in a readable format.
    public static void PrintByteArray(byte[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]:X2}");
            if ((i % 4) == 3) Console.Write(" ");
        }
        Console.WriteLine();
    }
}