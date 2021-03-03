using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFilesLib
{
    public interface IDirectoryExplorer {

        ICollection<string> GetFiles(string path);
    }

    public class DirectoryExplorer : IDirectoryExplorer
    {
        public ICollection<string> GetFiles(string path) {
            string[] files = Directory.GetFiles(path);
            return files;
        }
    }
}
