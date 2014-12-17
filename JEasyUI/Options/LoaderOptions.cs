using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEasyUI.Options
{
    public class LoaderOptions
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Options.LoaderOptions"/>
        /// </summary>
        public LoaderOptions()
        {
            this.ModulesToLoad = new Dictionary<string, string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the easyui base directory, must end with '/'.	
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        /// Gets or sets the name of theme that defined in 'themes' directory.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Gets or sets whether to load css file when loading module.
        /// </summary>
        public bool? Css { get; set; }

        /// <summary>
        /// Gets or sets the locale name
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets a timeout value in milliseconds. Fires if a timeout occurs.
        /// </summary>
        public long? Timeout { get; set; }

        /// <summary>
        /// A dictionary with modules/.js files/.css files to load. The key is the module/file. The value is the callback handler.
        /// </summary>
        public Dictionary<string, string> ModulesToLoad { get; set; }

        /// <summary>
        /// Gets or sets a handler for onProgress. Fires when a module is loaded successfully.
        /// </summary>
        public string OnProgress { get; set; }

        /// <summary>
        /// Gets or sets a handler for onLoad. Fires when a module and it's dependencies are loaded successfully.
        /// </summary>
        public string OnLoad { get; set; }

        #endregion
    }
}
