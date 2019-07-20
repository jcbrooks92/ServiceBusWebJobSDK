using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBusWebJob
{

    public class Functions
    {
        // public static void ProcessQueueMessage([ServiceBusTrigger("topic", "sub", Connection ="SBConnection")] string message, ExecutionContext executionContext, ILogger logger)
        public static void ProcessMessasge([ServiceBusTrigger(topicName: "topic", subscriptionName: "sub", Connection = "SBConnection")] string myQueueItem, string MessageId, ILogger log)
        {
            {
                log.LogInformation($"{myQueueItem}\n{MessageId}");
            }
        }
    }
}
