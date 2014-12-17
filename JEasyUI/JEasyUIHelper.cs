using JEasyUI.Facades;
using JEasyUI.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEasyUI
{
    public class JEasyUIHelper
    {
        #region Loader

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Loader"/>.
        /// </summary>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/>.</returns>
        public static Loader Loader()
        {
            return new Loader();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Loader"/> with specified options.
        /// </summary>
        /// <param name="action">An action to set the options.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/>.</returns>
        public static Loader Loader(Action<LoaderOptions> action)
        {
            return new Loader(action);
        }

        #endregion

        #region Parser

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Parser"/>.
        /// </summary>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/>.</returns>
        public static Parser Parser()
        {
            return new Parser();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Parser"/> with specified options.
        /// </summary>
        /// <param name="action">An action to set the options.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Parser"/>.</returns>
        public static Parser Parser(Action<ParserOptions> action)
        {
            return new Parser(action);
        }

        #endregion
    }
}
