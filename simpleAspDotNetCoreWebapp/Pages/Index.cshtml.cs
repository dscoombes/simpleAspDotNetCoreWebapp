using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace simpleAspDotNetCoreWebapp.Pages
{
    public class IndexModel : PageModel
    {
        private ILogger logger = null;

        public IndexModel(ILogger loggerfactory)
        {
            this.logger = loggerfactory;
        }
        public void OnGet()
        {
<<<<<<< HEAD
            logger.LogInformation("Information message from OnGet method on Index.cshtml page");
            logger.LogDebug("Debug message from OnGet method on Index.cshtml page");
            logger.LogError("Error message from OnGet method on Index.cshtml page");
            logger.LogWarning("Warning message from OnGet method on Index.cshtml page");
            logger.LogTrace("Trace message from OnGet method on Index.cshtml page");
            logger.LogCritical("Critical message from OnGet method on Index.cshtml page");
=======
            Trace.WriteLine("Verbose message, in the OnGet method for Index.cshtml");
            Trace.TraceError("Error message, in the OnGet method for Index.cshtml");
            Trace.TraceWarning("Warning  message, in the OnGet method for Index.cshtml");
            Trace.TraceInformation("Information message, in the OnGet method for Index.cshtml");
            logger.LogInformation("This is a log message!");
>>>>>>> parent of 770bbfb... updates
        }
    }
}
