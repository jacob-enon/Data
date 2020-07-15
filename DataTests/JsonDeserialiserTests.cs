using BigJacob.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace DataTests
{
    [TestClass]
    public class JsonDeserialiserTests
    {
        string path;
        List<string> expected;
        JsonDeserialiser deserialiser;

        [TestInitialize]
        public void Init()
        {
            path = Path.Combine("TestData", "test.json");

            expected = new List<string>()
            {
                "a",
                "b",
                "c"
            };

            deserialiser = new JsonDeserialiser();
        }

        [TestMethod]
        public void DeserialiseFile_ReturnsDeserialisedObject()
        {
            var result = deserialiser.DeserialiseFile<List<string>>(path);

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void DeserialiseFileAsync_ReturnsDeserialisedObject()
        {
            var result = deserialiser.DeserialiseFileAsync<List<string>>(path).Result;

            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
        }
    }
}