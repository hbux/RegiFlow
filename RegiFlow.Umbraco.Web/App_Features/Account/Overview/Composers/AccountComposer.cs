using RegiFlow.Umbraco.Web.App_Features.Account.Overview.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace RegiFlow.Umbraco.Web.App_Features.Account.Overview.Composers
{
    public class AccountComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IAccountService, AccountService>(Lifetime.Scope);
        }
    }
}