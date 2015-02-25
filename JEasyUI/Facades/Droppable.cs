using JEasyUI.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace JEasyUI.Facades
{
    /// <summary>
    /// JEasyUI Droppable
    /// </summary>
    public class Droppable : IHtmlString
    {
        #region Constructors

        public Droppable(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(StringResources.ElementIdRequiredException);

            this.options = new DroppableOptions();
        }

        public Droppable(string id, Action<DroppableOptions> action)
            : this(id)
        {
            action(this.options);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Set id of the droppable element.
        /// </summary>
        /// <param name="id">Id of the droppable element.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Droppable"/></returns>
        public Droppable SetId(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(StringResources.ElementIdRequiredException);
            this.options.Id = id;

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
            throw new NotImplementedException();
        }

        private string GetDomElements()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private fields and constants

        private DroppableOptions options;
        private const string tagName = "div";

        #endregion
    }
}
