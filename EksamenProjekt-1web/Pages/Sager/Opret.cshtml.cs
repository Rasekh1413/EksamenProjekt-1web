using EksamenProjekt_1web.Pages;
using EksamenProjekt_1web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EksamenProjekt_1web.Pages.Sager;

/// <summary>
/// PageModel-klasse for "Opret Sag".
/// </summary>
///
public class OpretModel : PageModel
{
	private ISagRepository _sagRepo;

	[BindProperty]
	public Sag NySag { get; set; }

	public OpretModel(ISagRepository sagRepo)
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
