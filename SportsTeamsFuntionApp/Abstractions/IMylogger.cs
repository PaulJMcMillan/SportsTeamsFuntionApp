using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Abstractions
{
    public interface IMylogger
    {
        void LogInfo(string message);
        void LogError(Exception exception, string message);
        void LogDebug(string message);
    }
}
