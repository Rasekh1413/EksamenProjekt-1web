using EksamenProjekt_1web.Pages;
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EksamenProjekt_1web.Pages.Sager;

/// <summary>
/// PageModel-klasse for "Opret Sag".
/// </summary>
public class OpretModel : PageModel
{
	
	private ISagRepository _sagRepo;

	[BindProperty]
	public Sag NySag { get; set; }

	[BindProperty]
	public int SagId { get; set; }

	public SelectList Sag { get; set; }

	public OpretModel(IKundeRepository kundeRepo, ISagRepository sagRepo)
	{
		
		_sagRepo = sagRepo;

		Sag = new SelectList(_sagRepo.All, nameof(SagId));
	}

	public IActionResult OnPost()
	{
		NySag.Sagen = _sagRepo.Read(SagId);
		if (!ModelState.IsValid)
		{
			return Page();
		}

		_sagRepo.Create(NySag);
		return RedirectToPage("Alle");
	}
}
