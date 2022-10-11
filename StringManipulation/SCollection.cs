using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulation
{
    public class SCollection : IDisposable
    {
        public List<string> RetrieveStringCollection()
        {
            var list = new List<string>
            {
                "2",
                "abaccadcc",
                "xyzxy",
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
                "fkdsgnekft",
                "5",
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc",
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
                "3",
                "pzjim",
                "njnfq",
                "xyohs",
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys",
            };
            return list;
        }

        public List<string> ProcessCollection(List<string> list)
        {
            var output = new List<string>();
            foreach (var word in list)
            {
                if (word.Any(x => char.IsLetter(x)))
                    output.Add(BuildArrangedStringCollection(word.Replace(" ", "")));
            }
            return output;
        }

        private string BuildArrangedStringCollection(string word)
        {
            var repList = from l in word
                          orderby l
                          group l by l into rep
                          select new { letter = rep.Key, times = rep.Count() };

            string output = "";
            foreach (var letter in repList.OrderByDescending(r => r.times))
            {
                var counter = letter.times;
                while (counter > 0)
                {
                    output += letter.letter;
                    counter--;
                }
            }
            return output;
        }
        public void Dispose()
        {
        }

    }
}
