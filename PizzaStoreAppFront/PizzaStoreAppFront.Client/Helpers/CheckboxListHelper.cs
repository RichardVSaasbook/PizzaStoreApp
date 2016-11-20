using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreAppFront.Client.Helpers {
    public static class CheckboxListHelper {
        /// <summary>
        /// Display a List of Checkboxes within Bootstrap columns.
        /// </summary>
        /// <param name="html">The HtmlHelper class to extend.</param>
        /// <param name="list">The List of SelectItems.</param>
        /// <param name="totalColumns">The number of columns to put the checkboxes in.</param>
        /// <returns>The HTML string for the checkbox columns.</returns>
        public static MvcHtmlString CheckboxColumns (this HtmlHelper html, IEnumerable<SelectListItem> list, int totalColumns) {
            StringBuilder builder = new StringBuilder(@"<div class=""row"">");

            List<TagBuilder> columns = new List<TagBuilder>();
            for (int c = 0; c < totalColumns; c++) {
                TagBuilder column = new TagBuilder("div");
                column.AddCssClass("col-md-" + (12 / totalColumns));
                columns.Add(column);
            }

            int i = 0;
            
            foreach (var item in list) {
                string element = string.Format(
                    @"<div class=""checkbox""><label><input type=""checkbox"" name=""toppings"" value=""{0}"" />{1}</label></div>",
                    item.Value,
                    item.Text
                );

                columns[i % totalColumns].InnerHtml += element;

                i++;
            }

            foreach (TagBuilder column in columns) {
                builder.Append(column.ToString());
            }

            builder.Append("</div>");

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}