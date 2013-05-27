using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileRename
{
    public interface IRenamer
    {
        string CombineName(string path, string name, string extension);

        void Rename(FileObject file, string newName);
    }

    public class Renamer : IRenamer
    {
        public string CombineName(string path, string name, string extension)
        {
            return Path.Combine(path, name + extension);
        }

        public void Rename(FileObject file, string newName)
        {
            if (file.Name == newName) return;
            string path = CombineName(file.Directory, newName, file.Extension);
            while (File.Exists(path))
            {
                string rndtx = Path.GetRandomFileName();
                path = CombineName(file.Directory, 
                    string.Format("{0}_{1}", newName, rndtx), file.Extension);
            }
            File.Move(file.Path, path);
            File.Delete(file.Path);
        }
    }
}
