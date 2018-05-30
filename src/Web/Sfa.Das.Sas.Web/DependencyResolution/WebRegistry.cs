using Sfa.Das.Sas.ApplicationServices.Handlers;
using Sfa.Das.Sas.Core.Domain.Helpers;
using Sfa.Das.Sas.Core.Domain.Repositories;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Infrastructure.Repositories;
using Sfa.Das.Sas.Infrastructure.Settings;
using Sfa.Das.Sas.Web.Helpers;

namespace Sfa.Das.Sas.Web.DependencyResolution
{
    using System.Web;
    using Factories;
    using Factories.Interfaces;
    using Logging;
    using MediatR;
    using Services;
    using SFA.DAS.NLog.Logger;
    using SFA.DAS.Providers.Api.Client;
    using StructureMap;

    public class WebRegistry : Registry
    {
        public WebRegistry()
        {
            For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
            For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));
            For<IMediator>().Use<Mediator>();
            For<IRequestContext>().Use(x => new RequestContext(new HttpContextWrapper(HttpContext.Current)));

            For<IMappingService>().Use<MappingService>();
            For<ICookieService>().Use<CookieService>();
            For<IGetProviderDetails>().Use<ProviderApiRepository>();
            For<IUrlEncoder>().Use<UrlEncoder>();
            For<IXmlDocumentSerialiser>().Use<XmlDocumentSerialiser>();

            For<IProviderApiClient>().Use(x => new ProviderApiClient(new ApplicationSettings().ApprenticeshipApiBaseUrl));
            For<IHttpCookieFactory>().Use<HttpCookieFactory>();

            For<IValidation>().Use<Validation>();
            For<IButtonTextService>().Use<ButtonTextService>();
        }
    }
}