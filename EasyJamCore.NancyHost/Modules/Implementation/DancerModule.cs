using EasyJamCore.Common.Model;
using Nancy;
using Nancy.ModelBinding;

namespace EasyJamCore.NancyHost.Modules.Implementation
{
    public class DancerModule : NancyModule
    {
        public DancerModule(IAppConfiguration appConfig)
        {
            Get("/", args => "Hello from Nancy running on CoreCLR");

            Post("/", args =>
            {
                var person = this.BindAndValidate<DancerModel>();
                if (!this.ModelValidationResult.IsValid)
                {
                    return 422;
                }
                return person;
            });
        }
    }
}
