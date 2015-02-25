using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JEasyUI.TestUtilities;
using JEasyUI.Facades;
using JEasyUI.Options;

namespace JEasyUI.UnitTests.Facades
{
    [TestClass]
    public class LoaderTests
    {
        #region Tests

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void LoaderSetOptionsEmptyConstructorTest()
        {
            this.ConfigureLoader();
            this.AssertLoader();
        }

        [TestMethod]
        [TestCategory(TestCategories.Facades)]
        public void LoaderSetOptionsInActionConstructorTest()
        {
            this.ConfigureLoaderWithActionConstructor();
            this.AssertLoader();
        }

        #endregion

        #region Private methods

        private void ConfigureLoader()
        {
            this.loader = new Loader();
            loader
                .SetBase(this.options.Base)
                .SetCss(this.options.Css.Value)
                .SetLocale(this.options.Locale)
                .SetOnLoad(this.options.OnLoad)
                .SetOnProgress(this.options.OnProgress)
                .SetTheme(this.options.Theme)
                .SetTimeout(this.options.Timeout.Value);
            foreach (var module in this.options.ModulesToLoad)
            {
                loader.LoadModule(module.Key, module.Value);
            }
        }

        private void ConfigureLoaderWithActionConstructor()
        {
            this.loader = new Loader(options =>
            {
                options.Base = this.options.Base;
                options.Css = this.options.Css;
                options.Locale = this.options.Locale;
                options.OnLoad = this.options.OnLoad;
                options.OnProgress = this.options.OnProgress;
                options.Theme = this.options.Theme;
                options.Timeout = this.options.Timeout;
                options.ModulesToLoad = this.options.ModulesToLoad;
            });
        }

        private void AssertLoader()
        {
            Assert.AreEqual(this.options.Base, this.loader.Options.Base);
            Assert.AreEqual(this.options.Css, this.loader.Options.Css);
            Assert.AreEqual(this.options.Locale, this.loader.Options.Locale);
            Assert.AreEqual(this.options.OnLoad, this.loader.Options.OnLoad);
            Assert.AreEqual(this.options.OnProgress, this.loader.Options.OnProgress);
            Assert.AreEqual(this.options.Theme, this.loader.Options.Theme);
            Assert.AreEqual(this.options.Timeout, this.loader.Options.Timeout);
            foreach (var module in this.options.ModulesToLoad)
            {
                Assert.IsTrue(this.loader.Options.ModulesToLoad.ContainsKey(module.Key));
                Assert.AreEqual(module.Value, this.loader.Options.ModulesToLoad[module.Key]);
            }
        }

        #endregion

        #region Private fields and constants

        Loader loader;

        LoaderOptions options = new LoaderOptions()
        {
            Base = "unitTestBaseFolder",
            Css = false,
            Locale = "unitTestLocale",
            ModulesToLoad = new System.Collections.Generic.Dictionary<string, string>()
            {
                { "unitTestModule1", "unitTestModuleCallback1" },
                { "unitTestModule2", "unitTestModuleCallback2" },
                { "unitTestModule3", "unitTestModuleCallback3" },
                { "unitTestModule4", "unitTestModuleCallback4" },
                { "unitTestModule5", "unitTestModuleCallback5" }
            },
            OnLoad = "unitTestOnLoad",
            OnProgress = "unitTestOnProgress",
            Theme = "unitTestTheme",
            Timeout = 1000
        };

        #endregion
    }
}
