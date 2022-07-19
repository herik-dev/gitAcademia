using imageStorage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace imageStorage.Controllers
{
    public class ImagensController : Controller
    {
        private string caminhoServidor;

        public ImagensController(IWebHostEnvironment sistema)
        {
            caminhoServidor = sistema.WebRootPath;
        }

        //Ação da view upload
        public IActionResult Upload()
        {
            return View();
        }

        //Resultado da view upload
        [HttpPost]
        public IActionResult Upload(IFormFile foto)
        {
            string caminhoParaSalvarImagem = caminhoServidor + "\\imagem\\";
            string novoNomeParaImagem = Guid.NewGuid().ToString() + "_" + foto.FileName;

            if ( ! Directory.Exists(caminhoParaSalvarImagem))
            {
                Directory.CreateDirectory(caminhoParaSalvarImagem);
            }
            using (var stream = System.IO.File.Create(caminhoParaSalvarImagem + novoNomeParaImagem))
            {
                foto.CopyToAsync(stream);
            }
            @ViewBag.Message = $"Armazenamento Realizado!";
            return RedirectToAction("Upload");
        }

    }
}

