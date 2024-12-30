using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTeamsFuntionApp.Services
{
    public class ContextService
    {
        public ContextService() 
        {
            CorrelationId=Guid.NewGuid().ToString();
        }

        public string CorrelationId { get; set; } = string.Empty;
    }
}
