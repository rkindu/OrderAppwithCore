using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApplication
{
     
    public class RadioTagHelpers: TagHelper
    {
        /// <summary>
        /// <radio name="ObjName" type = "radio" value = "item"> </radio>       
        /// </summary>
        /// 
        public string name { get; set; }
        public List<string> Item { get; set; }
        public override  void Process(TagHelperContext context, TagHelperOutput output)
        {
            foreach (var item in Item)
            {
                output.TagName = "radio";
                var html = "<input type=\"radio\" name =\"" + name + "\" value = \"" + item + "\"></input> <label> "+item+" </label> ";
                output.Content.AppendHtml(   
                       html);
                output.TagMode = TagMode.StartTagAndEndTag;

            }
             
        }

    }
}
 