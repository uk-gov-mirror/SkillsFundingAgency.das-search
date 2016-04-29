﻿using System.Web.Mvc;
using Sfa.Das.Sas.ApplicationServices;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Core.Logging;
using Sfa.Das.Sas.Web.Extensions;
using Sfa.Das.Sas.Web.Models;
using Sfa.Das.Sas.Web.Services;
using Sfa.Das.Sas.Web.ViewModels;

namespace Sfa.Das.Sas.Web.Controllers
{
    public sealed class ApprenticeshipController : Controller
    {
        private readonly ILog _logger;

        private readonly IMappingService _mappingService;

        private readonly IApprenticeshipSearchService _searchService;
        private readonly IGetStandards _getStandards;
        private readonly IGetFrameworks _getFrameworks;

        public ApprenticeshipController(
            IApprenticeshipSearchService searchService,
            IGetStandards getStandards,
            IGetFrameworks getFrameworks,
            ILog logger,
            IMappingService mappingService)
        {
            _searchService = searchService;
            _getStandards = getStandards;
            _getFrameworks = getFrameworks;
            _logger = logger;
            _mappingService = mappingService;
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SearchResults(StandardSearchCriteria criteria)
        {
            var searchResults = _searchService.SearchByKeyword(criteria.Keywords, criteria.Skip, criteria.Take);

            var viewModel = _mappingService.Map<ApprenticeshipSearchResults, ApprenticeshipSearchResultViewModel>(searchResults);

            return View(viewModel);
        }

        // GET: Standard
        public ActionResult Standard(int id, string hasError)
        {
            var standardResult = _getStandards.GetStandardById(id);

            if (standardResult == null)
            {
                var message = $"Cannot find standard: {id}";
                _logger.Warn($"404 - {message}");

                return new HttpNotFoundResult(message);
            }

            var viewModel = _mappingService.Map<Standard, StandardViewModel>(standardResult);

            viewModel.HasError = !string.IsNullOrEmpty(hasError) && bool.Parse(hasError);
            viewModel.SearchResultLink = Request.UrlReferrer.GetSearchResultUrl(Url.Action("Search", "Apprenticeship"));

            return View(viewModel);
        }

        public ActionResult Framework(int id, string hasError)
        {
            var frameworkResult = _getFrameworks.GetFrameworkById(id);

            if (frameworkResult == null)
            {
                var message = $"Cannot find framework: {id}";
                _logger.Warn($"404 - {message}");

                return new HttpNotFoundResult(message);
            }

            var viewModel = _mappingService.Map<Framework, FrameworkViewModel>(frameworkResult);

            viewModel.HasError = !string.IsNullOrEmpty(hasError) && bool.Parse(hasError);
            viewModel.SearchResultLink = Request.UrlReferrer.GetSearchResultUrl(Url.Action("Search", "Apprenticeship"));

            return View(viewModel);
        }
    }
}