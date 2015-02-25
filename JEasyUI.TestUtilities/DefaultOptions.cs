using JEasyUI.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JEasyUI.TestUtilities
{
    public class DefaultOptions
    {
        public static DraggableOptions DraggableTestOptions = new DraggableOptions()
        {
            Axis = DraggableAxis.Horizontal,
            CssClass = "unitTestCssClass",
            Cursor = "unitTestCursor",
            DeltaX = 5.67f,
            DeltaY = 2.23f,
            Disabled = true,
            Edge = 3.44f,
            Handle = "unitTestHandle",
            Id = "unitTestId",
            Jquery = "unitTestJQuery",
            OnBeforeDrag = "unitTestOnBeforeDrag",
            OnDrag = "unitTestOnDrag",
            OnStartDrag = "unitTestOnStartDrag",
            OnStopDrag = "unitTestOnStopDrag",
            Proxy = "unitTestProxy",
            Revert = true,
            TagName = HtmlTextWriterTag.Span,
            Title = "unitTestTitle",
            TitleCssClass = "unitTestTitleCssClass",
            TitleTagName = HtmlTextWriterTag.Span,
            Attributes = DefaultOptions.TestAttributesDictionary,
            TitleAttributes = DefaultOptions.TestAttributesDictionary
        };

        public static Dictionary<string, string> TestAttributesDictionary = new Dictionary<string, string>()
        {
            { "testAttribute1", "testAttributeValue1"},
            { "testAttribute2", "testAttributeValue2"},
            { "testAttribute3", "testAttributeValue3"}
        };
    }

}
