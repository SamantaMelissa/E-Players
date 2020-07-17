using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula37_Eplayers.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Aula37_Eplayers.Controllers
{
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
           // um tipode lista equipe
           // ReadAll lista as equipes
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        //IFORMCOLLECTION --> GEGA DADOS DO FRONT E APLICAMOS NO CONTROLLER
        public IActionResult Cadastrar(IFormCollection form){

        Equipe equipe = new Equipe();
        equipe.IdEquipe = Int32.Parse(form ["IdEquipe"]);
        equipe.Nome = form["Nome"];
        

        //Upload da imagem
       

        var file    = form.Files[0];
        var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

            if(file != null)
            {
            if(!Directory.Exists(folder)){
            Directory.CreateDirectory(folder);
            }
            //FileName -> arquivo.pdf ou jpg
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))  
            {  
                file.CopyTo(stream);  
            }
             equipe.Imagem   = file.FileName;
            }
            else
            {
                equipe.Imagem   = "padrao.png";
            }
            // Upload Final

           

        equipeModel.Create(equipe);

        ViewBag.Equipes = equipeModel.ReadAll();
        return LocalRedirect("~/Equipe");

        }

        [Route("[controller]/{id}")]
        public IActionResult Excluir(int id)
        {
            equipeModel.Delete(id);
            return LocalRedirect("~/Equipe");

        }
    }
}
