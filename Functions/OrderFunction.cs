using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace OrderProvider.Functions
{
    public class OrderFunction
    {
        private readonly ILogger<OrderFunction> _logger;

        public OrderFunction(ILogger<OrderFunction> logger)
        {
            _logger = logger;
        }

        [Function("OrderFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
