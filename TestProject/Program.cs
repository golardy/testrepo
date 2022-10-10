using Amazon.Lambda.SNSEvents;
using Amazon.S3.Util;
//using Boden.Dynatrace.AwsLambda.OpenTelemetry.Traces;
using Boden.Product.Persistence.Models.Entities.Implementations.Hierarchy;
using Confluent.Kafka;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sss = new List<DateTime> 
            {
                new DateTime(2022,1,1),
                new DateTime(2023,1,1)
            };

            var result = sss.OrderByDescending(x=> x);
        }
    }

    public class S1: IS
    {
        /*public void S()
        {
            Console.WriteLine("From class");
        }*/
    }

    public interface IS
    {
        void S()
        {
            Console.WriteLine("From interface");
        }
    }
}
