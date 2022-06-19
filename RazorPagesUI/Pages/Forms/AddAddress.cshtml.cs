using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;

namespace RazorPagesUI.Pages.Forms;

public class AddAddressModel : PageModel
{
    [BindProperty]
    public AddressModel Address { get; set; }

    public void OnGet()
    {


    }

    public IActionResult OnPost()
    {
        /*
        
        ModelState.IsValid will basically tell you if there is any issues with your data posted to the server -
        based on the data annotations added to the properties of your model.

        if (ModelState.IsValid == false)
        {
            return Page();
        }

        */

        return RedirectToPage("/Index", new { Address.City });
    }
}
