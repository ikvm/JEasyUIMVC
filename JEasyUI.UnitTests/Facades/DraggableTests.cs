using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JEasyUI.Facades;
using JEasyUI.Options;
using JEasyUI.TestUtilities;
using System.Web.UI;
using System.Collections.Generic;

namespace JEasyUI.UnitTests.Facades
{
    [TestClass]
    public class DraggableTests
    {
        #region Setup and Teardown

        [TestInitialize]
        public void Setup()
        {
            this.ConfigureDraggable();
        }

        [TestCleanup]
        public void TearDown()
        {
        }

        #endregion

        #region Tests

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DraggableSetOptionsEmptyConstructorTest()
        {
            this.AssertDraggable();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DraggableSetOptionsInActionConstructorTest()
        {
            this.ConfigureDraggableWithActionConstructor();
            this.AssertDraggable();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DraggableSetIdTest()
        {
            string testId = "manualSetIdTest";
            this.draggable.SetId(testId);
            Assert.AreEqual(testId, this.draggable.Options.Id);
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void DraggableSetHandleTest()
        {
            string testHandle = "manualSetHandleTest";
            this.draggable.SetHandle(testHandle);
            Assert.AreEqual(testHandle, this.draggable.Options.Handle);
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableCreateWithNullIdThrowsException()
        {
            new Draggable(null, "handle");
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableCreateWithNullHandleThrowsException()
        {
            new Draggable("id", null);
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableSetEmptyIdThrowsException()
        {
            this.draggable.SetId(string.Empty);
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableSetEmptyHandlerThrowsException()
        {
            this.draggable.SetHandle(string.Empty);
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableToStringEmptyIdThrowsException()
        {
            this.draggable.Options.Id = string.Empty;
            this.draggable.ToHtmlString();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DraggableToStringEmptyHandleThrowsException()
        {
            this.draggable.Options.Handle = string.Empty;
            this.draggable.ToHtmlString();
        }

        #endregion

        #region Private methods

        private void ConfigureDraggable()
        {
            this.draggable = TestUtilities.Facades.ConfigureDraggable(this.options);
        }

        private void ConfigureDraggableWithActionConstructor()
        {
            this.draggable = TestUtilities.Facades.ConfigureDraggableAction(this.options);
        }

        private void AssertDraggable()
        {
            TestUtilities.Facades.AssertDraggable(this.draggable, this.options);
        }

        #endregion

        #region Private fields and constants

        Draggable draggable;

        DraggableOptions options = TestUtilities.DefaultOptions.DraggableTestOptions;

        #endregion
    }
}
