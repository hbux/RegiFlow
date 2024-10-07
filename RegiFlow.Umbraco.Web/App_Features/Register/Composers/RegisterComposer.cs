using RegiFlow.Umbraco.Web.App_Features.Register.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Composers
{
    public class RegisterComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IRegisterService, RegisterService>(Lifetime.Scope);
        }
    }
}