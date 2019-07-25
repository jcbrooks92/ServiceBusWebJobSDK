using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBusWebJob
{

    public class Functions
    {

        [FunctionName("TimerTriggerCSharp")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            if (myTimer.IsPastDue)
            {
                log.LogInformation("Timer is running late!");
            }
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }

        public static void ProcessMessasge([ServiceBusTrigger(topicName: "topic", subscriptionName: "sub", Connection = "SBConnection")] string myQueueItem, string MessageId, ILogger log)
        {
            {
                log.LogInformation($"{myQueueItem}\n{MessageId}");
            }
        }
    }
}
