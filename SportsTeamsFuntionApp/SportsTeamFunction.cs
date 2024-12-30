using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using SportsTeamsFuntionApp.Abstractions;
using SportsTeamsFuntionApp.Common;
using SportsTeamsFuntionApp.Models;
using SportsTeamsFuntionApp.Services;

namespace SportsTeamsFuntionApp
{
    public class SportsTeamFunction
    {
        private readonly IMylogger _logger;
        private readonly ContextService _contextService;
        private readonly ISportsTeamsService _sportsTeamsService;

        public SportsTeamFunction(IMylogger logger, ContextService context, ISportsTeamsService sportsTeamsService)
        {
            _logger = logger;
            _contextService = context;
            _sportsTeamsService = sportsTeamsService;
        }

        [Function("SportsTeamFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            try
            {
                var city = req.Query["city"];
                string? cityRequested;
                if (string.IsNullOrEmpty(city))
                {
                    cityRequested = "All Cities";
                }
                else
                {
                    cityRequested = city;
                }

                _logger.LogInfo($"SportsTeamsFunctionApp is processing a request for sports teams for {cityRequested}. CorrelationId: {_contextService.CorrelationId}");
                var teams = _sportsTeamsService.Read(city);
                _logger.LogInfo($"SportsTeamsFunctionApp finished processing the request for {cityRequested}. Correlation Id: {_contextService.CorrelationId}");
                _logger.LogInfo("test");
                return new OkObjectResult(teams);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "error");

                // Return an Internal Server Error with problem details
                var problemDetails = new
                {
                    title = "Internal Server Error",
                    status = 500,
                    detail = "Internal server error"
                };

                return new ObjectResult(problemDetails)
                {
                    StatusCode = 500
                };
            }
        }
    }
}
