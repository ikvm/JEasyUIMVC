using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JEasyUI
{
    public static class JEasyUIHtmlHelper
    {
        public static JEasyUIHelper JEasyUI(this HtmlHelper helper)
        {
            return new JEasyUIHelper();
        }
    }
}
