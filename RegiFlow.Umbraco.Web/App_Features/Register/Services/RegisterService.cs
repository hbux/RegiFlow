using RegiFlow.Umbraco.Web.App_Features.Register.Models;
using RegiFlow.Umbraco.Web.App_Features.Shared.Extensions;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Services
{
    public interface IRegisterService
    {
        RegisterViewModel GetViewModel(ContentModel model);
        BasicDetailsFormModel GetFormModel();
        IPublishedContent ContinueToPlanSelection(BasicDetailsFormModel model);
    }

    public class RegisterService : IRegisterService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public RegisterService(
            UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public RegisterViewModel GetViewModel(ContentModel model)
        {
            return new RegisterViewModel(model.Content);
        }

        public BasicDetailsFormModel GetFormModel()
        {
            return new BasicDetailsFormModel();
        }

        public IPublishedContent ContinueToPlanSelection(BasicDetailsFormModel model)
        {
            var planSelectionNode = _umbracoHelper.GetPlanNode();

            return planSelectionNode;
        }
    }
}