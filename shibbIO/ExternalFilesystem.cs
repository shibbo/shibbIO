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
    public class ExternalFilesystem : FilesystemBase
    {
        public ExternalFilesystem(string dir)
        {
            if (!Directory.Exists(dir))
                throw new Exception($"ExternalFilesystem::ExternalFilesystem() - Directory not found.");

            mInfo = new DirectoryInfo(dir);
        }

        public override void Save()
        {

        }

        public override void Close()
        {

        }

        public override List<string> GetDirectories(string dir)
        {
            if (!DoesDirectoryExist(dir))
                throw new Exception($"ExternalFilesystem::GetDirectories() - Directory not found.");

            List<string> dirs = new List<string>();

            DirectoryInfo inf = new DirectoryInfo(mInfo.FullName + dir);

            foreach (DirectoryInfo d in inf.GetDirectories())
                dirs.Add(d.Name);

            return dirs;
        }

        public override bool DoesDirectoryExist(string dir)
        {
            DirectoryInfo inf = new DirectoryInfo(mInfo.FullName + dir);
            return inf.Exists;
        }

        public override List<string> GetFiles(string dir)
        {
            if (!DoesDirectoryExist(dir))
                throw new Exception($"ExternalFilesystem::GetFiles() - Directory not found.");

            List<string> files = new List<string>();

            DirectoryInfo inf = new DirectoryInfo(mInfo.FullName + dir);

            foreach (FileInfo f in inf.GetFiles())
                files.Add(f.Name);

            return files;
        }

        public override bool DoesFileExist(string file)
        {
            FileInfo inf = new FileInfo(mInfo.FullName + file);
            return inf.Exists;
        }

        public override FileBase OpenFile(string file)
        {
            if (!DoesFileExist(file))
                throw new Exception($"ExternalFilesystem::OpenFile() - File {file} not found.");

            return new ExternalFile(mInfo.FullName + file);
        }

        DirectoryInfo mInfo;
    }
}
