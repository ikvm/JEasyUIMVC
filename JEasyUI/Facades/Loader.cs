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
    /// JEasyUI EasyLoader
    /// </summary>
    public class Loader : IHtmlString
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Loader"/>.
        /// </summary>
        public Loader()
        {
            this.Options = new LoaderOptions();
        }

        /// <summary>
        /// Initializes a new instance of <see cref="JEasyUI.Facades.Loader"/> with specified options.
        /// <param name="action">An action to set the options.</param>
        /// </summary>
        public Loader(Action<LoaderOptions> action)
            : this()
        {
            action(this.Options);
        }

        #endregion

        #region Properties
        
        public LoaderOptions Options { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Set the easyui base directory.
        /// </summary>
        /// <param name="baseFolder">The easyui base directory, must end with '/'.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetBase(string baseFolder)
        {
            this.Options.Base = baseFolder;
            return this;
        }

        /// <summary>
        /// Set the easyui theme.
        /// </summary>
        /// <param name="theme">The name of theme that defined in 'themes' directory.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetTheme(string theme)
        {
            this.Options.Theme = theme;
            return this;
        }

        /// <summary>
        /// Defines if loading css file when loading module.
        /// </summary>
        /// <param name="css">If <c>true</c> a css will be load when loading a module.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetCss(bool loadCss)
        {
            this.Options.Css = loadCss;
            return this;
        }

        /// <summary>
        /// Set easyui locale name.
        /// </summary>
        /// <param name="locale">The locale name.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetLocale(string locale)
        {
            this.Options.Locale = locale;
            return this;
        }

        /// <summary>
        /// Set easyui timeout. Fires if a timeout occurs.
        /// </summary>
        /// <param name="timeOut">Timeout value in milliseconds.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetTimeout(long timeOut)
        {
            this.Options.Timeout = timeOut;
            return this;
        }

        /// <summary>
        /// Fires when a module is loaded successfully.
        /// </summary>
        /// <param name="onProgress">A javascript function/delegate to handle the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetOnProgress(string onProgress)
        {
            this.Options.OnProgress = onProgress;
            return this;
        }

        /// <summary>
        /// Fires when a module and it's dependencies are loaded successfully.
        /// </summary>
        /// <param name="onLoad">A javascript function/delegate to handle the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader SetOnLoad(string onLoad)
        {
            this.Options.OnLoad = onLoad;
            return this;
        }

        /// <summary>
        /// Load the specified module. When load success a callback function will be called.
        /// The module parameter valid type are:
        /// a single module name
        /// an module array
        /// a css file that end with '.css'
        /// a js file that end with '.js'
        /// </summary>
        /// <param name="module">The module name</param>
        /// <param name="callback">A javascript function/delegate to handle the event.</param>
        /// <returns>An instance of <see cref="JEasyUI.Facades.Loader"/></returns>
        public Loader LoadModule(string module, string callback)
        {
            if (!this.Options.ModulesToLoad.ContainsKey(module))
                this.Options.ModulesToLoad.Add(module, callback);
            return this;
        }


        public string ToHtmlString()
        {
            StringBuilder loader = new StringBuilder();
            loader.AppendLine("<script>");

            if (!string.IsNullOrEmpty(this.Options.Base))
                loader.AppendFormat("{0}.{1} = '{2}';\n", Loader.JavascriptName, Loader.BasePropertyName, this.Options.Base);

            if (!string.IsNullOrEmpty(this.Options.Theme))
                loader.AppendFormat("{0}.{1} = '{2}';\n", Loader.JavascriptName, Loader.ThemePropertyName, this.Options.Theme);

            if (!string.IsNullOrEmpty(this.Options.Locale))
                loader.AppendFormat("{0}.{1} = '{2}';\n", Loader.JavascriptName, Loader.LocalePropertyName, this.Options.Locale);

            if (this.Options.Css.HasValue)
                loader.AppendFormat("{0}.{1} = '{2}';\n", Loader.JavascriptName, Loader.CssPropertyName, this.Options.Css.Value.ToString().ToLowerInvariant());

            if (this.Options.Timeout.HasValue)
                loader.AppendFormat("{0}.{1} = {2};\n", Loader.JavascriptName, Loader.TimeoutPropertyName, this.Options.Timeout.Value.ToString());

            if (!string.IsNullOrEmpty(this.Options.OnProgress))
                loader.AppendFormat("{0}.{1} = {2};\n", Loader.JavascriptName, Loader.OnProgressEventName, this.Options.OnProgress);

            if (!string.IsNullOrEmpty(this.Options.OnLoad))
                loader.AppendFormat("{0}.{1} = {2};\n", Loader.JavascriptName, Loader.OnLoadEventName, this.Options.OnLoad);

            if (this.Options.ModulesToLoad != null)
            {
                foreach (var module in this.Options.ModulesToLoad)
                {
                    loader.AppendFormat("{0}.{1}('{2}', {3}\n", Loader.JavascriptName, Loader.LoadFunctionName, module.Key, module.Value);
                }
            }

            loader.AppendLine("</script>");
            return loader.ToString();
        }

        #endregion

        #region Private fields and constants

        /// <summary>
        /// Gets the name of the javascript object which holds jEasyUI Loader.
        /// </summary>
        public const string JavascriptName = "easyloader";

        /// <summary>
        /// Gets the name of the property which holds the base folder.
        /// </summary>
        public const string BasePropertyName = "base";

        /// <summary>
        /// Gets the name of the property which holds the theme.
        /// </summary>
        public const string ThemePropertyName = "theme";

        /// <summary>
        /// Gets the name of the property which holds the css loading.
        /// </summary>
        public const string CssPropertyName = "css";

        /// <summary>
        /// Gets the name of the property which holds the timeout.
        /// </summary>
        public const string TimeoutPropertyName = "timeout";

        /// <summary>
        /// Gets the name of the onProgress handler.
        /// </summary>
        public const string OnProgressEventName = "onProgress";

        /// <summary>
        /// Gets the name of the onLoad handler.
        /// </summary>
        public const string OnLoadEventName = "onLoad";

        /// <summary>
        /// Gets the name of the load function.
        /// </summary>
        public const string LoadFunctionName = "load";

        /// <summary>
        /// Gets the name of the property which holds the locale.
        /// </summary>
        public const string LocalePropertyName = "locale";

        #endregion
    }
}
