using RegiFlow.Umbraco.Web.App_Features.Account.Overview.Models;
using Umbraco.Web.Models;

namespace RegiFlow.Umbraco.Web.App_Features.Account.Overview.Services
{
    public interface IAccountService
    {
        AccountViewModel GetViewModel(ContentModel model);
    }

    public class AccountService : IAccountService
    {
        public AccountViewModel GetViewModel(ContentModel model)
        {
            return new AccountViewModel(model.Content);
        }
    }
}