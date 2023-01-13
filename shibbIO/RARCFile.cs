using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shibbIO
{
    public class RARCFile : MemoryFile
    {
        public RARCFile(RARCFilesystem fs, string fullName) : base(fs.GetContents(fullName))
        {
            mFilesystem = fs;
            mFileName = fullName;
        }

        public override void Save()
        {
            mFilesystem.ReinsertFile(this);
            this.Close();
        }

        public RARCFilesystem mFilesystem;
        public string mFileName;

    }
}
