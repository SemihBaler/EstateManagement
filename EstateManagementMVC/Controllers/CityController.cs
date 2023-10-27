using EstateManagementMVC.Dtos.CityDtos;
using EstateManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EstateManagementMVC.Controllers
{
    public class CityController : Controller
    {
        private readonly IHttpClientFactory _client;

        public CityController(IHttpClientFactory client)
        {
            _client = client;
        }

       
    }
}
