using DotLiquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belegleser
{
    class MakeDotLiquid
    {
        /// <summary>
        /// Executes the dotLiquid template
        /// </summary>
        /// <param name="regexvalue"></param>
        /// <param name="dotliquidValue">The dotliquid template, where "value" wil be replaced with regexvalue</param>
        /// <returns></returns>
        public static string Work(string regexvalue, string dotliquidValue)
        {
            if(dotliquidValue == null || dotliquidValue.Length < 1)
            {
                dotliquidValue = "{{value}}";
            }
            DotLiquid.Template template = DotLiquid.Template.Parse(dotliquidValue);
            return template.Render(Hash.FromAnonymousObject(new { date = DateTime.Now, value = regexvalue }));
        }
    }
}
