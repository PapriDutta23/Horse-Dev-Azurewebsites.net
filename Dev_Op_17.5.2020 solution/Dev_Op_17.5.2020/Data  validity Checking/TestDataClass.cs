using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Dev_Op_17._5._2020.Data__validity_Checking
{
    class TestDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("300", "Indian");
                yield return new TestCaseData("2308", "Austrlian");
            }
        }

    }
}
