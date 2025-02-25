using System;
using System.IO;
using System.Linq;

public class FileOrganizer
{
    public void OrganizeFiles(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }
        
        var files = Directory.GetFiles(directoryPath);
        if (!files.Any())
        {
            Console.WriteLine("No files found in the directory.");
            return;
        }
        
        foreach (var file in files)
        {
            string extension = Path.GetExtension(file).TrimStart('.').ToLower();
            if (string.IsNullOrEmpty(extension)) extension = "Others";
            
            string newFolderPath = Path.Combine(directoryPath, extension);
            Directory.CreateDirectory(newFolderPath);
            
            string newFilePath = Path.Combine(newFolderPath, Path.GetFileName(file));
            File.Move(file, newFilePath);
        }
        
        Console.WriteLine("Files organized successfully.");
    }
}
