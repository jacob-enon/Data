using BigJacob.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataTests
{
    [TestClass]
    public class JsonSerialiserTests
    {
        string path;
        List<string> item;
        JsonSerialiser serialiser;
        string expected;

        [TestInitialize]
        public void Init()
        {
            path = Path.Combine("TestData", "serialised.json");
            item = new List<string>()
            {
                "a",
                "b",
                "c"
            };
            serialiser = new JsonSerialiser();
            expected = "[\"a\",\"b\",\"c\"]";
        }

        [TestCleanup]
        public void Final()
        {
            File.Delete(path);
        }

        [TestMethod]
        public void SerialiseToFile_SerialisesToFile()
        {
            serialiser.SerialiseToFile(item, path);
            var result = File.ReadAllText(path);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SerialiseToFileAsync_SerialisesToFile()
        {
            serialiser.SerialiseToFileAsync(item, path).Wait();
            var result = File.ReadAllText(path);
            Assert.AreEqual(expected, result);
        }
    }
}