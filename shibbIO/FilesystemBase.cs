﻿namespace shibbIO
{
    public class FilesystemBase
    {
        public virtual void Save() { }
        public virtual void Close() { }
        public virtual List<string>? GetDirectories(string directory) { return null; }
        public virtual bool DoesDirectoryExist(string dir) { return false; }
        public virtual List<string>? GetFiles(string dir) { return null; }
        public virtual List<string>? GetFilesWithExt(string dir, string ext) { return null; }
        public virtual bool DoesFileExist(string dir) { return false; }
        public virtual FileBase? OpenFile(string file) { return null; }
        public virtual void CreateFile(string dir, string file) { }
        public virtual void RenameFile(string old, string newname) { }
        public virtual void DeleteFile(string file) { }
        public virtual void ReplaceFileContents(string file, byte[] contents) { }
    }
}
