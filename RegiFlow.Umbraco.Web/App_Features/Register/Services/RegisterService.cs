using RegiFlow.Umbraco.Web.App_Features.Register.Models;
using Umbraco.Web.Models;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Services
{
    public interface IRegisterService
    {
        RegisterViewModel GetViewModel(ContentModel model);
        BasicDetailsFormModel GetFormModel();
    }

    public class RegisterService : IRegisterService
    {
        public RegisterViewModel GetViewModel(ContentModel model)
        {
            return new RegisterViewModel(model.Content);
        }

        public BasicDetailsFormModel GetFormModel()
        {
            return new BasicDetailsFormModel();
        }
    }
}