﻿using System.Threading.Tasks;
using Sfa.Das.Sas.Shared.Components.ViewComponents.Fat;
using Sfa.Das.Sas.Shared.Components.ViewModels;
using Sfa.Das.Sas.Shared.Components.ViewModels.Apprenticeship;
using Sfa.Das.Sas.Shared.Components.ViewModels.Basket;

namespace Sfa.Das.Sas.Shared.Components.Orchestrators
{
    public interface IBasketOrchestrator
    {
        Task<BasketViewModel<ApprenticeshipBasketItemViewModel>> GetBasket();
    }
}