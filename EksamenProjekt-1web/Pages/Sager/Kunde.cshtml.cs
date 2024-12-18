using EksamenProjekt_1web.Pages.Models; 
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EksamenProjekt_1web.Pages.Models;

namespace EksamenProjekt_1web.Services.Repository;

/// <summary>
/// PageModel-klasse for "Opret Sag".
/// </summary>
public class KundeModel : PageModel
{
	private IKundeRepository _KundeRepo;

	[BindProperty]
	public Kunde NyKunde { get; set; }

	public KundeModel(IKundeRepository KundeRepo)
	{

		_KundeRepo = KundeRepo;

	}

	public IActionResult OnPost()
	{

		if (!ModelState.IsValid)
		{
			return Page();
		}

		_KundeRepo.Create(NyKunde);
		return RedirectToPage("Alle");
	}
}
