namespace RegiFlow.Umbraco.Web.App_Features.Shared.Constants
{
    public static class ViewTypes
    {
        public static class Layouts
        {
            public const string None = null;
            public const string Core = "~/Views/_Layout.cshtml";
        }

        public static class Account
        {
            public const string View = "~/App_Features/Account/Overview/Views/Account.cshtml";
        }

        public static class Register
        {
            public const string View = "~/App_Features/Register/Views/Register.cshtml";
            public const string Form = "~/App_Features/Register/Views/_BasicDetails.cshtml";
            
            public const string Action = "BasicDetails";
            public const string Controller = "RegisterSurface";
        }

        public static class Plan
        {
            public const string View = "~/App_Features/Plan/Views/Plan.cshtml";
            public const string Form = "~/App_Features/Plan/Views/_PlanSelection.cshtml";
            
            public const string Action = "PlanSelection";
            public const string Controller = "PlanSurface";
        }
    }
}