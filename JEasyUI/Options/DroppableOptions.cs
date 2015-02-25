using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace JEasyUI.Options
{
    public class DroppableOptions
    {
        #region Constructors

        public DroppableOptions()
        {
            this.Accept = new List<string>();
            this.Attributes = new Dictionary<string, string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the id of the droppable element. Required.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the jQuery name. Default is '$'.
        /// </summary>
        public string Jquery { get; set; }

        /// <summary>
        /// The tagname of the droppable element.
        /// </summary>
        public HtmlTextWriterTag? TagName { get; set; }

        /// <summary>
        /// Gets or sets html attributes of the droppable element.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets which draggable elements will be accepted. Required at least one.
        /// </summary>
        public List<string> Accept { get; set; }

        /// <summary>
        /// Gets or sets a value indication whether the droppable is disabled.
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or sets a javascript handler for onDragEnter event. 
        ///     Fires when the draggable element is dragged enter. 
        ///     Parameters: [e, source]. 
        ///     The source parameter indicate the dragged DOM element.
        /// </summary>
        public string OnDragEnter { get; set; }

        /// <summary>
        /// Gets or sets a javascript handler for onDragOver event. 
        ///     Fires when the draggable element is dragged over. 
        ///     Parameters: [e, source].
        ///     The source parameter indicate the dragged DOM element.
        /// </summary>
        public string OnDragOver { get; set; }

        /// <summary>
        /// Gets or sets a javascript handler for onDragLeave event.
        ///     Fires when the draggable element is dragged leave. 
        ///     Parameters: [e, source].
        ///     The source parameter indicate the dragged DOM element.
        /// </summary>
        public string OnDragLeave { get; set; }

        /// <summary>
        /// Gets or sets a javascript handler for onDrop even
        ///     Fires when the draggable element is dropped. 
        ///     Parameters: [e, source].
        ///     The source parameter indicate the dragged DOM element.
        /// </summary>
        public string OnDrop { get; set; }

        #endregion
    }
}
