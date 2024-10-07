using System;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Models
{
    [Serializable]
    public class RegisterFormModel
    {
        public BasicDetailsFormModel Basics { get; set; }
    }

    [Serializable]
    public partial class BasicDetailsFormModel
    {
    }
}