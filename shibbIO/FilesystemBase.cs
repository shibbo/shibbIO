/* 
 * Copyright (c) 2023 shibboleet

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace shibbIO
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
