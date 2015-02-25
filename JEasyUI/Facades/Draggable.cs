using JEasyUI.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace JEasyUI.Facades
{
    /// <summary>
    /// JEasyUI Draggable
    /// </summary>
    public class Draggable : IHtmlString
    {
        #region Constructors

        public Draggable(string id, string handle)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(StringResources.ElementIdRequiredException);
            if (string.IsNullOrEmpty(handle))
                throw new ArgumentNullException(StringResources.HandleRequiredException);

            this.Options = new DraggableOptions();
            this.Options.Id = id;
            this.Options.Handle = handle;
        }

        public Draggable(string id, string handle, Action<DraggableOptions> action)
            : this(id, handle)
        {
            action(this.Options);
        }

        #endregion

        #region Properties

        public DraggableOptions Options { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Set the id of the draggable element.
        /// </summary>
        /// <param name="id">The if of the draggable element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetId(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(StringResources.ElementIdRequiredException);
            this.Options.Id = id;
            return this;
        }

        /// <summary>
        /// Set a proxy element to be used when dragging, when set to 'clone', a clone element is used as proxy. If a function is specified, it must return a jQuery object.
        /// </summary>
        /// <param name="proxy">A string or a javascript function.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetProxy(string proxy)
        {
            this.Options.Proxy = proxy;
            return this;
        }

        /// <summary>
        /// Set wheter the element will return to its start position when dragging stops.
        /// </summary>
        /// <param name="revert">If set to true, the element will return to its start position when dragging stops.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetRevert(bool revert)
        {
            this.Options.Revert = revert;
            return this;
        }

        /// <summary>
        /// Set the css cursor when dragging.
        /// </summary>
        /// <param name="cursor"></param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetCursor(string cursor)
        {
            this.Options.Cursor = cursor;
            return this;
        }

        /// <summary>
        /// Set the dragged element position x corresponding to current cursor.
        /// </summary>
        /// <param name="deltaX">The position x corresponding to current cursor.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetDeltaX(float deltaX)
        {
            this.Options.DeltaX = deltaX;
            return this;
        }

        /// <summary>
        /// Set the dragged element position y corresponding to current cursor.
        /// </summary>
        /// <param name="deltaY">The position y corresponding to current cursor.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetDeltaY(float deltaY)
        {
            this.Options.DeltaY = deltaY;
            return this;
        }

        /// <summary>
        /// Set the handle that start the draggable.
        /// </summary>
        /// <param name="handle">A jQuery selector.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetHandle(string handle)
        {
            if (string.IsNullOrEmpty(handle))
                throw new ArgumentNullException(StringResources.HandleRequiredException);
            this.Options.Handle = handle;
            return this;
        }

        /// <summary>
        /// Set whether to disable the draggable.
        /// </summary>
        /// <param name="disabled">If <c>true</c> stop draggable</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetDisabled(bool disabled)
        {
            this.Options.Disabled = disabled;
            return this;
        }

        /// <summary>
        /// Set the drag width in which can start draggable.
        /// </summary>
        /// <param name="edge">The width in which can start draggable.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetEdge(float edge)
        {
            this.Options.Edge = edge;
            return this;
        }

        /// <summary>
        /// Set the axis which the dragged elements moves on, available value is 'v' or 'h', when set to null will move across 'v' and 'h' direction.
        /// </summary>
        /// <param name="axis">the axis which the dragged elements moves on.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetAxis(DraggableAxis axis)
        {
            this.Options.Axis = axis;
            return this;
        }

        /// <summary>
        /// Set the tagnama of the draggable element.
        /// </summary>
        /// <param name="tagName">The tagname of the draggable element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetTagName(HtmlTextWriterTag tagName)
        {
            this.Options.TagName = tagName;
            return this;
        }

        /// <summary>
        /// Set the css class of the draggable element.
        /// </summary>
        /// <param name="cssClass">The css class of the draggable element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetCssClass(string cssClass)
        {
            this.Options.CssClass = cssClass;
            return this;
        }

        /// <summary>
        /// Add html attribute to the draggable element.
        /// </summary>
        /// <param name="name">The name of the html attribute.</param>
        /// <param name="value">The value of the html attribute.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable AddAttribute(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (!this.Options.Attributes.ContainsKey(name))
                this.Options.Attributes.Add(name, value);
            return this;
        }

        /// <summary>
        /// Set the title of the draggable element. Creates a new html dom element.
        /// </summary>
        /// <param name="title">The title of the draggable element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetTitle(string title)
        {
            this.Options.Title = title;
            return this;
        }

        /// <summary>
        /// Set the tagname of the title element.
        /// </summary>
        /// <param name="tagName">The tagname of the title element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetTitleTagName(HtmlTextWriterTag tagName)
        {
            this.Options.TitleTagName = tagName;
            return this;
        }

        /// <summary>
        /// Set the css class of the title element.
        /// </summary>
        /// <param name="cssClass">The css class of the title element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable SetTitleCssClass(string cssClass)
        {
            this.Options.TitleCssClass = cssClass;
            return this;
        }

        /// <summary>
        /// Add html attribute to the title element.
        /// </summary>
        /// <param name="name">The name of the html attribute.</param>
        /// <param name="value">The value of the html attribute.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable AddTitleAttribute(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (!this.Options.TitleAttributes.ContainsKey(name))
                this.Options.TitleAttributes.Add(name, value);
            return this;
        }

        /// <summary>
        /// Set onBeforeDrag handler.
        /// </summary>
        /// <param name="onBeforeDrag">A javascript function that handles the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable OnBeforeDrag(string onBeforeDrag)
        {
            this.Options.OnBeforeDrag = onBeforeDrag;
            return this;
        }

        /// <summary>
        /// Set onStartDrag handler.
        /// </summary>
        /// <param name="onStartDrag">A javascript function that handles the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable OnStartDrag(string onStartDrag)
        {
            this.Options.OnStartDrag = onStartDrag;
            return this;
        }

        /// <summary>
        /// Set onDrag handler.
        /// </summary>
        /// <param name="onDrag">A javascript function that handles the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable OnDrag(string onDrag)
        {
            this.Options.OnDrag = onDrag;
            return this;
        }

        /// <summary>
        /// Set onStopDrag handler.
        /// </summary>
        /// <param name="onStopDrag">A javascript function that handles the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Draggable"/></returns>
        public Draggable OnStopDrag(string onStopDrag)
        {
            this.Options.OnStopDrag = onStopDrag;
            return this;
        }

        public string ToHtmlString()
        {
            return this.GetDomElements() + "\n" + this.GetScript();
        }

        #endregion

        #region Private methods

        private string GetScript()
        {
            if (string.IsNullOrEmpty(this.Options.Handle))
                throw new ArgumentNullException(StringResources.HandleRequiredException);

            StringBuilder script = new StringBuilder();
            script.AppendLine("<script>");
            script.AppendFormat("{0}('#{1}').draggable({{\n", this.Options.Jquery ?? "$", this.Options.Id);

            List<string> jsOptions = new List<string>();
            jsOptions.Add(string.Format("handle: {0}", this.Options.Handle));

            if (!string.IsNullOrEmpty(this.Options.Proxy))
                jsOptions.Add(string.Format("proxy: {0}", this.Options.Proxy));

            if (this.Options.Revert.HasValue)
                jsOptions.Add(string.Format("revert: {0}", this.Options.Revert.Value.ToString().ToLowerInvariant()));

            if (!string.IsNullOrEmpty(this.Options.Cursor))
                jsOptions.Add(string.Format("cursor: {0}", this.Options.Cursor));

            if (this.Options.DeltaX.HasValue)
                jsOptions.Add(string.Format("deltaX: {0}", this.Options.DeltaX.Value.ToString()));

            if (this.Options.DeltaY.HasValue)
                jsOptions.Add(string.Format("deltaY: {0}", this.Options.DeltaY.Value.ToString()));

            if (this.Options.Disabled.HasValue)
                jsOptions.Add(string.Format("disable: {0}", this.Options.Disabled.Value.ToString().ToLowerInvariant()));

            if (this.Options.Edge.HasValue)
                jsOptions.Add(string.Format("edge: {0}", this.Options.Edge.Value.ToString()));

            if (this.Options.Axis != DraggableAxis.None)
                jsOptions.Add(string.Format("axis: {0}", this.Options.Axis == DraggableAxis.Vertical ? "v" : "h"));

            if (!string.IsNullOrEmpty(this.Options.OnBeforeDrag))
                jsOptions.Add(string.Format("onBeforeDrag: {0}", this.Options.OnBeforeDrag));

            if (!string.IsNullOrEmpty(this.Options.OnStartDrag))
                jsOptions.Add(string.Format("onStartDrag: {0}", this.Options.OnStartDrag));

            if (!string.IsNullOrEmpty(this.Options.OnDrag))
                jsOptions.Add(string.Format("onDrag: {0}", this.Options.OnDrag));

            if (!string.IsNullOrEmpty(this.Options.OnStopDrag))
                jsOptions.Add(string.Format("onStopDrag: {0}", this.Options.OnStopDrag));

            if (jsOptions.Count > 0)
                script.AppendLine(string.Join(",\n", jsOptions.ToArray()));

            script.AppendLine("});");
            script.AppendLine("<script>");

            return script.ToString();
        }

        private string GetDomElements()
        {
            if (this.Options == null)
                throw new ArgumentNullException(StringResources.OptionsRequired);

            if (string.IsNullOrEmpty(this.Options.Id))
                throw new ArgumentNullException(StringResources.ElementIdRequiredException);

            TagBuilder tag = new TagBuilder(this.Options.TagName.HasValue ? this.Options.TagName.Value.ToString() : tagName);
            tag.MergeAttribute("id", this.Options.Id);
            if (!string.IsNullOrEmpty(this.Options.CssClass))
                tag.AddCssClass(this.Options.CssClass);
            if (this.Options.Attributes != null)
                tag.MergeAttributes(this.Options.Attributes);

            if (!string.IsNullOrEmpty(this.Options.Title))
            {
                TagBuilder titleTag = new TagBuilder(this.Options.TitleTagName.HasValue ? this.Options.TagName.Value.ToString() : tagName);
                titleTag.SetInnerText(this.Options.Title);
                if (!string.IsNullOrEmpty(this.Options.TitleCssClass))
                    titleTag.AddCssClass(this.Options.TitleCssClass);
                if (this.Options.TitleAttributes != null)
                    tag.MergeAttributes(this.Options.TitleAttributes);

                tag.InnerHtml = titleTag.ToString();
            }

            return tag.ToString();
        }

        #endregion

        #region Private fields and constants

        private const string tagName = "div";

        #endregion
    }
}
