using JEasyUI.Facades;
using JEasyUI.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JEasyUI.TestUtilities
{
    public class Facades
    {
        public static Draggable ConfigureDraggable(DraggableOptions draggableOptions)
        {
            var draggable = new Draggable(draggableOptions.Id, draggableOptions.Handle);
            draggable
                .OnBeforeDrag(draggableOptions.OnBeforeDrag)
                .OnDrag(draggableOptions.OnDrag)
                .OnStartDrag(draggableOptions.OnStartDrag)
                .OnStopDrag(draggableOptions.OnStopDrag)
                .SetAxis(draggableOptions.Axis)
                .SetCssClass(draggableOptions.CssClass)
                .SetCursor(draggableOptions.Cursor)
                .SetProxy(draggableOptions.Proxy)
                .SetTitle(draggableOptions.Title)
                .SetTitleCssClass(draggableOptions.TitleCssClass);

            if (draggableOptions.DeltaX.HasValue)
                draggable.SetDeltaX(draggableOptions.DeltaX.Value);
            if (draggableOptions.DeltaY.HasValue)
                draggable.SetDeltaY(draggableOptions.DeltaY.Value);
            if( draggableOptions.Disabled.HasValue)
                draggable.SetDisabled(draggableOptions.Disabled.Value);
            if (draggableOptions.Edge.HasValue)
                draggable.SetEdge(draggableOptions.Edge.Value);
            if (draggableOptions.Revert.HasValue)
                draggable.SetRevert(draggableOptions.Revert.Value);
            if (draggableOptions.TagName.HasValue)
                draggable.SetTagName(draggableOptions.TagName.Value);
            if (draggableOptions.TitleTagName.HasValue)
                draggable.SetTagName(draggableOptions.TitleTagName.Value);

            return draggable;
        }

        public static Draggable ConfigureDraggableAction(DraggableOptions draggableOptions)
        {
            return new Draggable(draggableOptions.Id, draggableOptions.Handle, options =>
            {
                options.Attributes = options.Attributes;
                options.Axis = options.Axis;
                options.CssClass = options.CssClass;
                options.Cursor = options.Cursor;
                options.DeltaX = options.DeltaX;
                options.DeltaY = options.DeltaY;
                options.Disabled = options.Disabled;
                options.Edge = options.Edge;
                options.Jquery = options.Jquery;
                options.OnBeforeDrag = options.OnBeforeDrag;
                options.OnDrag = options.OnDrag;
                options.OnStartDrag = options.OnStartDrag;
                options.OnStopDrag = options.OnStopDrag;
                options.Proxy = options.Proxy;
                options.Revert = options.Revert;
                options.TagName = options.TagName;
                options.Title = options.Title;
                options.TitleAttributes = options.TitleAttributes;
                options.TitleCssClass = options.TitleCssClass;
                options.TitleTagName = options.TitleTagName;
            });
        }

        public static void AssertDraggable(Draggable draggable, DraggableOptions draggableOptions)
        {
            Assert.AreEqual(draggableOptions.Axis, draggable.Options.Axis);
            Assert.AreEqual(draggableOptions.CssClass, draggable.Options.CssClass);
            Assert.AreEqual(draggableOptions.Cursor, draggable.Options.Cursor);
            Assert.AreEqual(draggableOptions.DeltaX, draggable.Options.DeltaX);
            Assert.AreEqual(draggableOptions.DeltaY, draggable.Options.DeltaY);
            Assert.AreEqual(draggableOptions.Disabled, draggable.Options.Disabled);
            Assert.AreEqual(draggableOptions.Edge, draggable.Options.Edge);
            Assert.AreEqual(draggableOptions.Handle, draggable.Options.Handle);
            Assert.AreEqual(draggableOptions.Id, draggable.Options.Id);
            Assert.AreEqual(draggableOptions.Jquery, draggable.Options.Jquery);
            Assert.AreEqual(draggableOptions.OnBeforeDrag, draggable.Options.OnBeforeDrag);
            Assert.AreEqual(draggableOptions.OnDrag, draggable.Options.OnDrag);
            Assert.AreEqual(draggableOptions.OnStartDrag, draggable.Options.OnStartDrag);
            Assert.AreEqual(draggableOptions.OnStopDrag, draggable.Options.OnStopDrag);
            Assert.AreEqual(draggableOptions.Proxy, draggable.Options.Proxy);
            Assert.AreEqual(draggableOptions.Revert, draggable.Options.Revert);
            Assert.AreEqual(draggableOptions.TagName, draggable.Options.TagName);
            Assert.AreEqual(draggableOptions.Title, draggable.Options.Title);
            Assert.AreEqual(draggableOptions.TitleCssClass, draggable.Options.TitleCssClass);
            Assert.AreEqual(draggableOptions.TitleTagName, draggable.Options.TitleTagName);
            TestHelpers.AssertDictionaries<string, string>(draggableOptions.Attributes, draggable.Options.Attributes);
            TestHelpers.AssertDictionaries<string, string>(draggableOptions.TitleAttributes, draggable.Options.TitleAttributes);
        }
    }
}
