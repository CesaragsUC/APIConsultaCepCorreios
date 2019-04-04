using Microsoft.AspNetCore.Mvc;
using RestSharp;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PesquisarCepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MostraResultado(int cep)
        {
            
                var resquest = new RestClient("http://www.viacep.com.br/ws/" + cep + "/json");
                var request = new RestRequest(Method.GET);
                IRestResponse response = resquest.Execute(request);
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dados>(response.Content);
                return View(data);
            
        }


    }
}