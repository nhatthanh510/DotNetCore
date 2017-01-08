using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SampleProject.Models;

namespace SampleProject.TagHelpers
{
    [HtmlTargetElement("customer-list")]
    public class MyCustomTagHelper : TagHelper
    {
        private List<CustomerViewModel> _customer;

        public MyCustomTagHelper()
        {
            _customer = new List<CustomerViewModel>()
            {
                new CustomerViewModel {City = "HCM", CompanyName = "Bluecom"},
                new CustomerViewModel {City = "HN", CompanyName = "GCS"}
            };
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _customer;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in query)
            {
                stringBuilder.AppendFormat("<h2>{0}_{1}</h2>", item.City, item.CompanyName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
