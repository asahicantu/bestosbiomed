using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiometricPortal.Pages
{
    public class HealthDataModel : PageModel
    {
        public string Title { get; private set; }

        public void OnGet()
        {
            Title = "Health Data";
        }
    }
}
