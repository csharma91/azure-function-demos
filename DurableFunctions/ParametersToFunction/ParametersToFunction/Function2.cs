using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ParallelDurableFunction
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task<string> Run(
            [ActivityTrigger] string msg,
            ILogger log)
        {
            log.LogWarning("This is Function 2");
            await Task.Delay(10000);
            log.LogWarning("Function 2 completed");
            msg += "Function 2";
            return msg;
        }
    }
}
