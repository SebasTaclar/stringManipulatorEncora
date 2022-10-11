using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StringManipulation.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestCase1()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "2",
                    "abaccadcc",
                    "xyzxy",
                };

                var expected_output = new List<string>
                {
                    "ccccaaabd",
                    "xxyyz"
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }

        [TestMethod]
        public void TestCase2()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "10",
                    "dulgvgzwqg",
                    "gxtjtmtywr",
                    "hnlnxiupgt",
                    "gzjotckivp",
                    "dpwwsdptae",
                    "pcscpilknb",
                    "btvyhhmflf",
                    "artrtnqxcr",
                    "nrtcmcoadn",
                    "fkdsgnekft"
                };

                var expected_output = new List<string>
                {
                    "gggdlquvwz",
                    "tttgjmrwxy",
                    "nnghilptux",
                    "cgijkoptvz",
                    "ddppwwaest",
                    "ccppbiklns",
                    "ffhhblmtvy",
                    "rrrttacnqx",
                    "ccnnadmort",
                    "ffkkdegnst"
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }

        [TestMethod]
        public void TestCase3()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "5",
                    "wzenwebuau",
                    "vokfxzynwl",
                    "neldfeyrxk",
                    "wqadfiodgs",
                    "ykiuvzfcbc",
                };

                var expected_output = new List<string>
                {
                    "eeuuwwabnz",
                    "fklnovwxyz",
                    "eedfklnrxy",
                    "ddafgioqsw",
                    "ccbfikuvyz",
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }

        [TestMethod]
        public void TestCase4()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "10",
                    "qakmc",
                    "rrtbk",
                    "vaixn",
                    "wmpnj",
                    "uproi",
                    "btska",
                    "ejqwr",
                    "elwlg",
                    "oaoiy",
                    "hrqkn",
                };

                var expected_output = new List<string>
                {
                    "ackmq",
                    "rrbkt",
                    "ainvx",
                    "jmnpw",
                    "iopru",
                    "abkst",
                    "ejqrw",
                    "llegw",
                    "ooaiy",
                    "hknqr",
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }

        [TestMethod]
        public void TestCase5()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "3",
                    "pzjim",
                    "njnfq",
                    "xyohs",
                };

                var expected_output = new List<string>
                {
                    "ijmpz",
                    "nnfjq",
                    "hosxy",
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }

        [TestMethod]
        public void TestCase6()
        {
            using (var stringCollection = new SCollection())
            {
                var input = new List<string>
                {
                    "xqycs",
                    "beoax",
                    "afkso",
                    "bldit",
                    "gwrys",
                };

                var expected_output = new List<string>
                {
                    "cqsxy",
                    "abeox",
                    "afkos",
                    "bdilt",
                    "grswy",
                };

                CollectionAssert.AreEqual(expected_output, stringCollection.ProcessCollection(input));
            }
        }
    }
}
