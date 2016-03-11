﻿
using System.Collections.Generic;
using System.Linq;

namespace Sfa.Eds.Das.Web.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Sfa.Das.ApplicationServices;
    using Sfa.Das.ApplicationServices.Models;
    using Sfa.Eds.Das.ApplicationServices;
    using Sfa.Eds.Das.Core.Domain.Model;
    using Sfa.Eds.Das.Core.Domain.Services;
    using Sfa.Eds.Das.Core.Logging;
    using Sfa.Eds.Das.Web.Models;
    using Sfa.Eds.Das.Web.Services;
    using Sfa.Eds.Das.Web.ViewModels;

    public sealed class ProviderController : Controller
    {
        private readonly IProviderSearchService _providerSearchService;
        private readonly ILog _logger;
        private readonly IMappingService _mappingService;

        private IProviderRepository _providerRepository;

        private readonly ILookupLocations _postcodeLookup;

        public ProviderController(IProviderSearchService providerSearchService, ILog logger, IMappingService mappingService, IProviderRepository providerRepository, ILookupLocations postcodeLookup)
        {
            _providerSearchService = providerSearchService;
            _logger = logger;
            _mappingService = mappingService;
            _providerRepository = providerRepository;
            _postcodeLookup = postcodeLookup;
        }

        [HttpGet]
        public async Task<ActionResult> SearchResults(ProviderSearchCriteria criteria)
        {
            if (string.IsNullOrEmpty(criteria?.PostCode))
            {
                return RedirectToAction("Detail", "Standard", new { id = criteria.StandardId, HasError = true });
            }

            var searchResults = await _providerSearchService.SearchByPostCode(criteria.StandardId, criteria.PostCode);

            var viewModel = _mappingService.Map<ProviderSearchResults, ProviderSearchResultViewModel>(searchResults);

            var id = 1;

            if (viewModel.Hits != null)
            {
                foreach (var providerResultItemViewModel in viewModel.Hits)
                {
                    providerResultItemViewModel.Name = "Test";
                    providerResultItemViewModel.LocationName = "LocationTest";
                    providerResultItemViewModel.Address = new Address
                    {
                        Address1 = "Address 1",
                        Address2 = "Address 2",
                        Postcode = "PostCodeTest",
                        County = "CountyTest",
                        Town = "MyTown",
                        Lat = 12345,
                        Long = 54321
                    };
                    if (id == 1)
                    {
                        providerResultItemViewModel.DeliveryModes = new List<string> { "100PercentEmployer", "patata" };
                    }
                    if (id == 2)
                    {
                        providerResultItemViewModel.DeliveryModes = new List<string> { "100PercentEmployer" };
                    }

                    id++;
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Detail(ProviderLocationSearchCriteria criteria)
        {
            var model = this._providerRepository.GetById(criteria.ProviderId, criteria.LocationId, criteria.StandardCode);

            if (model == null)
            {
                var message = $"Cannot find provider: {criteria.ProviderId}";
                _logger.Warn($"404 - {message}");

                return new HttpNotFoundResult(message);
            }

            var viewModel = this._mappingService.Map<Provider, ProviderViewModel>(model);
            
            return View(viewModel);
        }
    }
}