using Microsoft.Extensions.Logging;
using SportsTeamsFuntionApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Common
{
    public class MyLogger : IMylogger
    {
        private readonly ILogger<MyLogger> _logger;

        public MyLogger(ILogger<MyLogger> logger)
        {
            _logger = logger;            
        }
        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void LogError(Exception exception, string message)
        {
            _logger.LogError(exception, message);
        }

        public void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
