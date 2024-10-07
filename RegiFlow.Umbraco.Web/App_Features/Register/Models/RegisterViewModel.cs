using Umbraco.Core.Models.PublishedContent;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Models
{
    public class RegisterViewModel : App_Data.Models.Register
    {
        public RegisterViewModel(
            IPublishedContent content)
            : base(content)
        {
        }
    }
}