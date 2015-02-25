using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JEasyUI.TestUtilities;
using JEasyUI.Facades;
using JEasyUI.Options;

namespace JEasyUI.UnitTests.Facades
{
    [TestClass]
    public class ParserTests
    {
        #region Tests

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void ParserSetOptionsEmptyConstructorTest()
        {
            this.ConfigureParser();
            this.AssertParser();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void ParserSetOptionsInActionConstructorTest()
        {
            this.ConfigureParserWithActionConstructor();
            this.AssertParser();
        }

        #endregion

        #region Private methods

        private void ConfigureParser()
        {
            this.parser = new Parser();
            parser.SetAutoParse(this.options.AutoParse.Value)
                .SetNode(this.options.Node)
                .SetOnComplete(this.options.OnComplete);
        }

        private void ConfigureParserWithActionConstructor()
        {
            this.parser = new Parser(options =>
            {
                options.AutoParse = this.options.AutoParse;
                options.Node = this.options.Node;
                options.OnComplete = this.options.OnComplete;
            });
        }

        private void AssertParser()
        {
            Assert.AreEqual(this.options.AutoParse, this.parser.Options.AutoParse);
            Assert.AreEqual(this.options.Node, this.parser.Options.Node);
            Assert.AreEqual(this.options.OnComplete, this.parser.Options.OnComplete);
        }

        #endregion

        #region Private fields and constants

        Parser parser;

        ParserOptions options = new ParserOptions()
        {
            AutoParse = true,
            Node = "unitTestNode",
            OnComplete = "onCompleteUnitTestHandler"
        };

        #endregion
    }
}
