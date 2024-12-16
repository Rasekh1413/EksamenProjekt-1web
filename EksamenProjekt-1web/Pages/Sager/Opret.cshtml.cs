using EksamenProjekt_1web.Pages;
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BilVærksted.Pages.Sager;

/// <summary>
/// PageModel-klasse for "Opret Sag".
/// </summary>
public class OpretModel : PageModel
{
	
	private ISagRepository _sagRepo;

	[BindProperty]
	public Sag NySag { get; set; }

	[BindProperty]
	public int BilId { get; set; }  // NB: Bruges af SelectList

	/// <summary>
	/// Denne SelectList gør det muligt at vælge mellem de eksisterende Biler,
	/// når en ny Sag skal oprettes.
	/// NB: Bruges af <select>-tag på Page.
	/// </summary>
	public SelectList Biler { get; set; }

	public OpretModel(IKundeRepository kundeRepo, ISagRepository sagRepo)
	{
		
		_sagRepo = sagRepo;
	}

	public IActionResult OnPost()
	{

		if (!ModelState.IsValid)
		{
			return Page();
		}

		_sagRepo.Create(NySag);
		return RedirectToPage("Alle");
	}
}
