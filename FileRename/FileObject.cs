using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileRename
{
    public class FileObject
    {
        public string Path { get; private set; }
        public string Name { get; private set; }
        public string Directory { get; private set; }
        public string Extension { get; private set; }
        public DateTime CreationTime { get; private set; }

        public FileObject(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            this.Path = fileName;
            this.Name = f.Name;
            this.Directory = f.Directory.FullName;
            this.Extension = f.Extension;
            this.CreationTime = f.CreationTime;
        }

        public override string ToString()
        {
            return this.Path;
        }
    }

    public class RenameTask
    {
        public List<FileObject> Files { get; private set; }
        public INameGenerator Generator { get; private set; }
        public IRenamer Renamer { get; private set; }
        public int Processed { get; private set; }
        public int Total { get { return (Files == null ? 0 : Files.Count); } }
        public bool HasMore { get { return Processed < Total; } }

        public RenameTask(IEnumerable<FileObject> collection, INameGenerator generator)
        {
            this.Files = new List<FileObject>(collection);
            this.Generator = generator;
            this.Renamer = new Renamer();
        }

        public bool DoNext()
        {
            if (Processed != Total)
            {
                Renamer.Rename(Files[Processed++], Generator.GetNextName());
                return true;
            }
            return false;
        }
    }
}
