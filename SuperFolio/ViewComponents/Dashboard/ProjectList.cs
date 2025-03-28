﻿using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public ProjectList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.TGetList();
            return View(values);
        }
    }
}
