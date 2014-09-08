using System;
using System.IO;

namespace DirectoriesAndFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // list directories in C drive
            DirectoryInfo[] di = new DirectoryInfo(@"c:\").GetDirectories();
            foreach (DirectoryInfo dir in di) 
            { 
                Console.WriteLine(dir.Name); 
            }

            // make backup copy of current directory
            string currentFolderName = Directory.GetCurrentDirectory();
            DirectoryInfo currentFolder = new DirectoryInfo(currentFolderName);

            string backupFolderName = currentFolderName + @"\backup";
            DirectoryInfo backupFolder = new DirectoryInfo(backupFolderName);
            if (!backupFolder.Exists)
            {
                backupFolder.Create();
            }

            foreach (FileInfo entry in currentFolder.GetFiles())
            {
                entry.CopyTo(backupFolder.FullName + @"\" + entry.Name);
            }

            Console.WriteLine("Backup complete"); 

            // list folders and subfolders in Program Files
            DirectoryInfo progfiles = new DirectoryInfo(@"c:\Program Files");
            listFolders(progfiles);

            Console.ReadLine();
        }

        static void listFolders(DirectoryInfo dirinfo)
        {
            DirectoryInfo[] di = dirinfo.GetDirectories();
            foreach (DirectoryInfo dir in di)
            {
                Console.WriteLine(dir.Name);
                listFolders(dir);
            }
        }
    }
}
