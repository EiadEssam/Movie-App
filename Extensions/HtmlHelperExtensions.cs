using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent DisplayDescriptionFor<TModel, TValue>(
            this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression)
        {
            var modelExplorer = html.ViewContext.ViewData.ModelExplorer;
            var fieldName = html.NameFor(expression).ToString(); 
            var modelProperty = modelExplorer.Metadata.Properties[fieldName];
            
            return new HtmlString(modelProperty?.Description ?? string.Empty);
        }
    }
}