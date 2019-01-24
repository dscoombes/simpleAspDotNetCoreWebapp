using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
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
            Trace.WriteLine("Verbose message, in the OnGet method for Index.cshtml");
            Trace.TraceError("Error message, in the OnGet method for Index.cshtml");
            Trace.TraceWarning("Warning  message, in the OnGet method for Index.cshtml");
            Trace.TraceInformation("Information message, in the OnGet method for Index.cshtml");
            logger.LogInformation("OnGet:::::::::Info:::::::::");
            logger.LogDebug("OnGet:::::::::Debug:::::::::");
            logger.LogError("OnGet::::::::::::::Error::::");
            logger.LogWarning("OnGet::::::::::::Warning::::::");
            logger.LogTrace("OnGet:::::::::::::Trace:::::");
            logger.LogCritical("OnGet::::::::::::::Critical::::");
        }
    }
}
