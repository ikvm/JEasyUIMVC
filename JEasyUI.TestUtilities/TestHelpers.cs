using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JEasyUI.TestUtilities
{
    public class TestHelpers
    {
        public static void AssertDictionaries<TKey, TValue>(IDictionary<TKey, TValue> expected, IDictionary<TKey, TValue> actual)
        {
            if (expected == null)
                Assert.IsNull(actual);
            else
            {
                Assert.IsNotNull(actual);
                Assert.AreEqual(expected.Count, actual.Count);
                foreach (KeyValuePair<TKey, TValue> item in expected)
                {
                    Assert.IsTrue(actual.ContainsKey(item.Key));
                    Assert.AreEqual<TValue>(expected[item.Key], actual[item.Key]);
                }
            }
        }
    }
}
