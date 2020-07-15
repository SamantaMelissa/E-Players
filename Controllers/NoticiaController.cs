/*sdgsdg using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula37_Eplayers.Models;
using Microsoft.AspNetCore.Http;

namespace Aula37_Eplayers.Controllers
{
    public class NoticiaController : Controller
    {
        Noticias noticiaModel = new Noticias();


        public IActionResult Index()
        {
          
            ViewBag.Noticias = noticiaModel.ReadAll();
            return View();
        }


        public IActionResult Cadastrar(IFormCollection form){

        Noticias noticia = new Noticias();
        noticia.IdNoticias = Int32.Parse(form ["IdNoticias"]);
        noticia.Titulo = form["Titulo"];
        noticia.Texto = form["Texto"];
        noticia.Imagem = form["Imagem"];


        noticiaModel.Create(noticia);

        ViewBag.Noticias = noticiaModel.ReadAll();
        return LocalRedirect("~/noticia");

        }
    }
}
*/