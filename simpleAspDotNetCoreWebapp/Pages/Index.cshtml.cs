using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace simpleAspDotNetCoreWebapp.Pages
{
    public class IndexModel : PageModel
    {
        private ILogger logger = null;

        public IndexModel(ILogger<DebugLogger> loggerfactory)
        {
            this.logger = loggerfactory;
        }
        public void OnGet()
        {
            logger.LogInformation("Information message from OnGet method on Index.cshtml page");
            logger.LogDebug("Debug message from OnGet method on Index.cshtml page");
            logger.LogError("Error message from OnGet method on Index.cshtml page");
            logger.LogWarning("Warning message from OnGet method on Index.cshtml page");
            logger.LogTrace("Trace message from OnGet method on Index.cshtml page");
            logger.LogCritical("Critical message from OnGet method on Index.cshtml page");
        }
    }
}
