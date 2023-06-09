﻿using System;
using System.Text;
using CompositeExample.Components;

namespace CompositeExample
{
    /// <summary>
    /// Клиентский код 
    /// </summary>
    class Client
    {
        public  static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Создание корневой папки
            Component rootFolder = new Folder("Root");
            
            // Создание файла - компонента низшего уровня 
            Component myFile = new File("MyFile.txt");
            
            // Создание папки с документами
            Folder documentsFolder = new Folder("MyDocuments");
            
            // Добавляем файл в корневую папки
            rootFolder.Add(myFile);
            
            // Добавляем подпапку для документов в корневую папку
            rootFolder.Add(documentsFolder);
            
            // показываем контент корневой папки
            rootFolder.Display();
        }
    }
}