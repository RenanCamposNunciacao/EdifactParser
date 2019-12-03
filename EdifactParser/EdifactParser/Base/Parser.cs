using System;
using System.Collections.Generic;
using System.Linq;

namespace EdifactParser
{
    public class Parser
    {
        public static List<string[]> Parse(string pEdifact)
        {
            List<string[]> lReturn = new List<string[]>(); ;

            foreach (string lRow in pEdifact.Split('\''))
                lReturn.Add(lRow.Split('+'));

            return lReturn;
        }

        public static List<string[]> GetSegment(string pEdifact, string pSegment)
        {
            return Parse(pEdifact).Where(x => x[0].ToUpper() == pSegment.ToUpper()).ToList();
        }
    }
}
