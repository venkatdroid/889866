using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using MagicFilesLib;

namespace DirectoryExplorerTests
{
    public class Class1
    {
        private IDirectoryExplorer _directoryExplorer;
        private readonly string _file1 = "test1.txt";
        private readonly string _file2 = "test2.txt";

        [SetUp]
        public void setUp()
        {
            _directoryExplorer = Mock.Of<IDirectoryExplorer>();
            Mock.Get(_directoryExplorer).Setup(x => x.GetFiles(It.IsAny<string>()))
                                        .Returns((string x) => new List<string> { _file1, _file2 });
        }

        [Test]
        public void GetFiles_Test()
        {
            ICollection<string> files = _directoryExplorer.GetFiles(@"C:\");

            Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.IsTrue(files.Contains(_file1));
        }
    }
}
