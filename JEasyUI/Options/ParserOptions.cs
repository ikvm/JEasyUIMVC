using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEasyUI.Options
{
    public class ParserOptions
    {
        #region Properties

        /// <summary>
        /// Gets or sets whether to auto parse the easyui component.
        /// </summary>
        public bool? AutoParse { get; set; }

        /// <summary>
        /// Gets or sets a jQuery selector for specific node to parse.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// Gets or sets onComplete handler.
        /// </summary>
        public string OnComplete { get; set; }

        #endregion
    }
}
