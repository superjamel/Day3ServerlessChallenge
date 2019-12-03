using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace WebhooksServerlessChallenge
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([BlobTrigger("images-hooked/{name}", Connection = "DefaultEndpointsProtocol=https;AccountName=imagesjamel;AccountKey=5Mil2CcSfgdDIRqlnTgEffEJG1uwz8L8992enuVL7EQBGQGFKNMz9mvKfVWrFblDqIrZF8XkztjiwV1OyxMCIA==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
