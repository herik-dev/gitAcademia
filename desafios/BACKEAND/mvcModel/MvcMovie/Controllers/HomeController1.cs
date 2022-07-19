using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {

            return "Minha ação padrão";
        }
        public string Welcome(string nome, int vezes = 1, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"oi {nome}, vezez: {vezes}, ID ="{ID});
        }
        public string Teste()
        {
            return "aqui é só para mostrar o conteúdo do controller";
        }
    }
}
