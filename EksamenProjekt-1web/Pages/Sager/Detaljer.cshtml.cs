using EksamenProjekt_1web.Pages;
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenProjekt_1web.Pages.Sager;

/// <summary>
/// PageModel-klasse for "Vis Detaljer for en valgt Sag".
/// </summary>
public class Detaljer : PageModel
{
	private ISagRepository _sagRepo;

	[BindProperty]

	public Sag Sagen { get; set; }


	public Detaljer(ISagRepository sagRepo)
	{
		_sagRepo = sagRepo;
	}

	/// <summary>
	/// NB: Bemærk at OnGet her tager en parameter. Denne parameter bliver
	/// sat i "kaldet" fra "Vis alle Sager"-Page (se efter asp-route-sagId).
	/// Derved kan vi læse en specifik Sag fra Sag-repository via det givne Id.
	/// </summary>
	public virtual IActionResult OnGet(int sagId)
	{
		Sagen = _sagRepo.Read(sagId);

		return Page();
	}
}
