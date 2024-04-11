using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace S_Coefficient.Tests
{
    [TestClass]
    public class PostProcessTests
    {
        [TestMethod]
        public void Test()
        {
            var sourceLines = File.ReadAllLines(Path.Combine("TestFiles", "PostProcessing", "source.txt"));

            var resultLines = PostProcessing.Program.FormatFile(sourceLines).ToArray();

            // 目視確認用。
            //var resultFile = Path.Combine("TestFiles", "PostProcessing", "~result.txt");
            //File.WriteAllLines(resultFile, resultLines);

            var expectFile = Path.Combine("TestFiles", "PostProcessing", "expect.txt");
            var expectLines = File.ReadAllLines(expectFile).ToArray();
            CollectionAssert.AreEqual(expectLines, resultLines);
        }
    }
}
