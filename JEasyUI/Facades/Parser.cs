using JEasyUI.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JEasyUI.Facades
{
    /// <summary>
    /// JEasyUI Parser
    /// </summary>
    public class Parser : IHtmlString
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Parser"/>.
        /// </summary>
        public Parser()
        {
            this.options = new ParserOptions();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Parser"/> with specified options.
        /// </summary>
        /// <param name="action">An action to set the options.</param>
        public Parser(Action<ParserOptions> action)
            :base()
        {
            action(this.options);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Defines if to auto parse the easyui component.
        /// </summary>
        /// <param name="autoParse">If <c>true</c> auto parse is on.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser AutoParse(bool autoParse)
        {
            this.options.AutoParse = autoParse;
            return this;
        }

        /// <summary>
        /// Parse the specified node.
        /// </summary>
        /// <param name="node">A jQuery selector for specific node to parse.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser Node(string node)
        {
            this.options.Node = node;
            return this;
        }

        /// <summary>
        /// Fires when parser finishing its parse action.
        /// Parameters: [context]
        /// </summary>
        /// <param name="onComplete">A javascript function to handle the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser OnComplete(string onComplete)
        {
            this.options.OnComplete = onComplete;
            return this;
        }

        public string ToHtmlString()
        {
            StringBuilder parser = new StringBuilder();

            if (this.options.AutoParse.HasValue)
                parser.AppendFormat("$.parser.auto = {0};\n", this.options.AutoParse.Value.ToString().ToLowerInvariant());

            if (!string.IsNullOrEmpty(this.options.OnComplete))
                parser.AppendFormat("$.parser.onComplete = {0};", this.options.OnComplete);

            parser.AppendFormat("$.parser.parse('{0}');\n", this.options.Node);

            return parser.ToString();
        }

        #endregion

        #region Private string and constants

        private ParserOptions options;

        #endregion
    }
}
