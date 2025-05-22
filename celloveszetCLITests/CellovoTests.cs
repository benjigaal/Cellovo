using Microsoft.VisualStudio.TestTools.UnitTesting;
using celloveszetCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI.Tests
{
    [TestClass()]
    public class CellovoTests
    {
        [TestMethod()]
        [DataRow("nev;22; 29; 12; 23", 29)]
        [DataRow("nev;16; 45; 87; 33", 87)]
        [DataRow("nev;96; 49; 67; 45", 96)]
        [DataRow("nev;44; 3; 12; 77", 77)]
        public void LegnagyobbTest(string line, int expected)
        {
            Cellovo cellovo = new Cellovo(line);
            Assert.AreEqual(expected, cellovo.Legnagyobb());
        }
    }
}