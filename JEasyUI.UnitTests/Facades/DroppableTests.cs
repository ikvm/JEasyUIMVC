using JEasyUI.Facades;
using JEasyUI.Options;
using JEasyUI.TestUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JEasyUI.UnitTests.Facades
{
    [TestClass]
    public class DroppableTests
    {
        #region Tests

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DroppableSetOptionsEmptyConstructorTest()
        {
            this.ConfigureDroppable();
            this.AssertDroppable();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DroppableSetOptionsInActionConstructorTest()
        {
            this.ConfigureDroppableWithActionConstructor();
            this.AssertDroppable();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DroppableCreateWithEmptyIdThrowsException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DroppableSetEmptyIdThrowsException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DroppableToStringEmptyIdThrowsException()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DroppableToStringEmptyAcceptThrowsException()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private methods

        private void ConfigureDroppable()
        {
            this.droppable = new Droppable(this.options.Id);
        }

        private void ConfigureDroppableWithActionConstructor()
        {
            this.droppable = new Droppable(this.options.Id, options =>
            {
                options.Accept = this.options.Accept;
                options.Attributes = this.options.Attributes;
                options.Disabled = this.options.Disabled;
                options.Id = this.options.Id;
                options.Jquery = this.options.Jquery;
                options.OnDragEnter = this.options.OnDragEnter;
                options.OnDragLeave = this.options.OnDragLeave;
                options.OnDragOver = this.options.OnDragOver;
                options.OnDrop = this.options.OnDrop;
                options.TagName = this.options.TagName;
            });
        }

        private void AssertDroppable()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private fields and constants

        Droppable droppable;

        DroppableOptions options = new DroppableOptions()
        {
            Disabled = true,
            Id = "unitTestDroppableId",
            Jquery = "$unitTestDroppable",
            OnDragEnter = "unitTestOnDragEnter",
            OnDragLeave = "unitTestOnDragLeave",
            OnDragOver = "unitTestOnDragOver",
            OnDrop = "unitTestOnDrop",
            TagName = HtmlTextWriterTag.Span,
            Accept = new List<string>() { "unitTestAccept1", "unitTestAccept2", "unitTestAccept3" },
            Attributes = new Dictionary<string, string>() { 
                { "unitTestAttribute1", "unitTestAttributeValue1" },
                { "unitTestAttribute2", "unitTestAttributeValue2" },
                { "unitTestAttribute3", "unitTestAttributeValue3" },
            }
        };

        #endregion
    }
}
