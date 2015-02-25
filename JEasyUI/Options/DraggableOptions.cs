using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JEasyUI.Options
{
    public class DraggableOptions
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Options.DraggableOptions"/>
        /// </summary>
        public DraggableOptions()
        {
            this.Attributes = new Dictionary<string, string>();
            this.TitleAttributes = new Dictionary<string, string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the id of the element. Required.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the jQuery name. Default is '$'.
        /// </summary>
        public string Jquery { get; set; }

        /// <summary>
        /// Gets or sets a proxy element to be used when dragging, when set to 'clone', a clone element is used as proxy. If a function is specified, it must return a jQuery object.
        /// </summary>
        public string Proxy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether element will return to its start position when dragging stops.
        /// </summary>
        public bool? Revert { get; set; }

        /// <summary>
        /// Gets or sets the css cursor when dragging.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or sets the dragged element position x corresponding to current cursor.
        /// </summary>
        public float? DeltaX { get; set; }

        /// <summary>
        /// Gets or sets the dragged element position y corresponding to current cursor.
        /// </summary>
        public float? DeltaY { get; set; }

        /// <summary>
        /// Gets or sets the selector of the handle that start the draggable. Required.
        /// </summary>
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether draggable is disabled.
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or sets the drag width in which can start draggable.
        /// </summary>
        public float? Edge { get; set; }

        /// <summary>
        /// Gets or sets the axis which the dragged elements moves on, available value is 'v' or 'h', when set to null will move across 'v' and 'h' direction.
        /// </summary>
        public DraggableAxis Axis { get; set; }

        /// <summary>
        /// Gets or sets a css class for the draggable element.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// The tagname of the draggable element.
        /// </summary>
        public HtmlTextWriterTag? TagName { get; set; }

        /// <summary>
        /// Gets or sets html attributes of the draggable element.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a css class for the title.
        /// </summary>
        public string TitleCssClass { get; set; }

        /// <summary>
        /// The tagname of the title element.
        /// </summary>
        public HtmlTextWriterTag? TitleTagName { get; set; } 

        /// <summary>
        /// Gets or sets html attributes of the title element.
        /// </summary>
        public Dictionary<string, string> TitleAttributes { get; set; }

        /// <summary>
        /// Gets or sets the onBeforeDrag handler. Fires before dragging, return false to cancel this dragging. Parameters: [e].
        /// </summary>
        public string OnBeforeDrag { get; set; }

        /// <summary>
        /// Gets or sets the onStartDrag handler. Fires when the target object start dragging. Parameters: [e].
        /// </summary>
        public string OnStartDrag { get; set; }

        /// <summary>
        /// Gets or sets the onDrag handler. Fires during dragging. Return false will not do dragging actually. Parameters: [e].
        /// </summary>
        public string OnDrag { get; set; }

        /// <summary>
        /// Gets or sets the onStopDrag handler. Fires when the dragging stops. Parameters: [e].
        /// </summary>
        public string OnStopDrag { get; set; }

        #endregion
    }

    public enum DraggableAxis
    {
        None,
        Vertical,
        Horizontal
    }
}
