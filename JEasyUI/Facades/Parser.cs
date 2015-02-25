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
            this.Options = new ParserOptions();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Parser"/> with specified options.
        /// </summary>
        /// <param name="action">An action to set the options.</param>
        public Parser(Action<ParserOptions> action)
            : this()
        {
            action(this.Options);
        }

        #endregion

        #region Properties

        public ParserOptions Options { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Defines if to auto parse the easyui component.
        /// </summary>
        /// <param name="autoParse">If <c>true</c> auto parse is on.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser SetAutoParse(bool autoParse)
        {
            this.Options.AutoParse = autoParse;
            return this;
        }

        /// <summary>
        /// Parse the specified node.
        /// </summary>
        /// <param name="node">A jQuery selector for specific node to parse.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser SetNode(string node)
        {
            this.Options.Node = node;
            return this;
        }

        /// <summary>
        /// Fires when parser finishing its parse action.
        /// Parameters: [context]
        /// </summary>
        /// <param name="onComplete">A javascript function to handle the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/></returns>
        public Parser SetOnComplete(string onComplete)
        {
            this.Options.OnComplete = onComplete;
            return this;
        }

        public string ToHtmlString()
        {
            StringBuilder parser = new StringBuilder();
            parser.AppendLine("<script>");
            if (this.Options.AutoParse.HasValue)
                parser.AppendFormat("$.parser.auto = {0};\n", this.Options.AutoParse.Value.ToString().ToLowerInvariant());

            if (!string.IsNullOrEmpty(this.Options.OnComplete))
                parser.AppendFormat("$.parser.onComplete = {0};\n", this.Options.OnComplete);

            parser.AppendFormat("$.parser.parse('{0}');\n", this.Options.Node);
            parser.AppendLine("</script>");
            return parser.ToString();
        }

        #endregion
    }
}
