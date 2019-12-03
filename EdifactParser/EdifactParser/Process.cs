using System;
using System.Collections.Generic;
using System.Text;

namespace EdifactParser
{
    public class Process
    {
        public string[] ProcessFirstExecise()
        {
            string lMessage = @"UNA:+.? 'UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-'IE++1++1'UNH+EDIFACT+CUSDEC:D:96B:UN:145050'BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'LOC+17+IT044100'LOC+18+SOL'LOC+35+SE'LOC+36+TZ'LOC+116+SE003033'DTM+9:20090527:102'DTM+268:20090626:102'DTM+182:20090527:102";
            List<string> lReturn = new List<string>();
            foreach (string[] lRow in Parser.GetSegment(lMessage, "LOC"))
            {
                //if array size is bigger than 1, add second element to the array
                if (lRow.Length > 1)
                    lReturn.Add(lRow[1]);

                //if array size is bigger than 2, add third element to the array
                if (lRow.Length > 2)
                    lReturn.Add(lRow[2]);
            }
            return lReturn.ToArray();
        } 
    }
}
