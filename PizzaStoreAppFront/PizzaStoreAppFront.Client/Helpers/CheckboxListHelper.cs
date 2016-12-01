using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            List<StringBuilder> columnInnerHtmls = new List<StringBuilder>();
            for (int c = 0; c < totalColumns; c++) {
                TagBuilder column = new TagBuilder("div");
                column.AddCssClass("col-md-" + (12 / totalColumns));
                columns.Add(column);

                columnInnerHtmls.Add(new StringBuilder());
            }

            int i = 0;
            
            foreach (var item in list) {
                string element = string.Format(
                    @"<div class=""checkbox""><label><input type=""checkbox"" name=""toppings"" value=""{0}"" />{1}</label></div>",
                    item.Value,
                    item.Text
                );

                columnInnerHtmls[i % totalColumns].Append(element);

                // columns[i % totalColumns].InnerHtml += element;

                i++;
            }

            i = 0;

            foreach (TagBuilder column in columns) {
                column.InnerHtml = columnInnerHtmls[i].ToString();
                builder.Append(column.ToString());
                i++;
            }

            builder.Append("</div>");

            return MvcHtmlString.Create(builder.ToString());
        }

        public static MvcHtmlString PizzaColumns(this HtmlHelper html, IEnumerable<Pizza> pizzas, int totalColumns) {
            StringBuilder builder = new StringBuilder(@"<div class=""row"">");

            List<TagBuilder> columns = new List<TagBuilder>();
            List<StringBuilder> columnInnerHtmls = new List<StringBuilder>();
            for (int c = 0; c < totalColumns; c++) {
                TagBuilder column = new TagBuilder("div");
                column.AddCssClass("col-md-" + (12 / totalColumns));
                columns.Add(column);

                columnInnerHtmls.Add(new StringBuilder());
            }

            int i = 0;

            foreach (var pizza in pizzas) {
                StringBuilder ingredientList = new StringBuilder("<ul>");

                foreach (Ingredient ingredient in pizza.Ingredients) {
                    ingredientList.Append("<li>" + ingredient.Name + "</li>");
                }

                ingredientList.Append("</ul>");

                string element = string.Format(
                    @"<p><b>{0}</b></p><p><b>Price</b><span class=""pull-right"">{1}</span></p><p><b>Ingredients</b>{2}",
                    pizza.Size.Dimension + " Inch Custom Pizza",
                    pizza.Price.ToString("C"),
                    ingredientList.ToString()
                );

                columnInnerHtmls[i % totalColumns].Append(element);

                // columns[i % totalColumns].InnerHtml += element;

                i++;
            }

            i = 0;

            foreach (TagBuilder column in columns) {
                column.InnerHtml = columnInnerHtmls[i].ToString();
                builder.Append(column.ToString());
                i++;
            }

            builder.Append("</div>");

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}