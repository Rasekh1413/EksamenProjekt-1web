using System;
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenProjekt_1web.Pages.Sager
{
    public class AlleModel : PageModel
    {
        private ISagRepository _sagRepository;

        /// <summary>
        /// Denne property bruges af Page til at kunne generere HTML
        /// for hver Person.
        /// </summary>
        public List<Sag> Sager { get; private set; }

        public AlleModel(ISagRepository sagRepository)
        {
            _sagRepository = sagRepository;

        }

        public void OnGet()
        {
            Sager = _sagRepository.All;
        }
    }
}
