﻿using Microsoft.AspNetCore.Mvc;
using PastryShop.Models;
using PastryShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShop.Controllers
{
    public class PieController : Controller
    {
        

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        //constructeur
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;


            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
            //return View(_pieRepository.AllPies);
            //_pieRepository
        }
    }
}
