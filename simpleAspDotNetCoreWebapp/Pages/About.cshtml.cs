using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simpleAspDotNetCoreWebapp.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
        System.Diagnostics.Trace.WriteLine("Verbose message, in the OnGet method for About.cshtml");
        System.Diagnostics.Trace.TraceError("Error message, in the OnGet method for About.cshtml");
        System.Diagnostics.Trace.TraceWarning("Warning  message, in the OnGet method for About.cshtml");
        System.Diagnostics.Trace.TraceInformation("Information message, in the OnGet method for About.cshtml");
        }
    }
}