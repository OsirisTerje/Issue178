using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Issue178
{
    [TestFixture]
    public class UnitTestNUnit
    {
        [Test]
        public void TestMethod1()
        {
            string ver = FileVersionInfo.GetVersionInfo(typeof(Uri).Assembly.Location).ProductVersion;
            TestContext.Out.WriteLine($"Running under {ver}");
        }
    }
}