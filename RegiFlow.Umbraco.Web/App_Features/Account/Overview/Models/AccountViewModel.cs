using Umbraco.Core.Models.PublishedContent;

namespace RegiFlow.Umbraco.Web.App_Features.Account.Overview.Models
{
    public class AccountViewModel : App_Data.Models.Account
    {
        public AccountViewModel(
            IPublishedContent content)
            : base(content)
        {
        }
    }
}