using Umbraco.Web.Mvc;

namespace RegiFlow.Umbraco.Web.App_Features.Shared
{
    public abstract class BaseSurfaceController : SurfaceController
    {
        public UmbracoPageResult CurrentUmbracoPage(string result)
        {
            // TODO: change signature to use Result or Result<TModel>
            // Use Result.Failure()'s error object and add to ModelState
            ModelState.AddModelError(nameof(result), result);

            return base.CurrentUmbracoPage();
        }
    }
}