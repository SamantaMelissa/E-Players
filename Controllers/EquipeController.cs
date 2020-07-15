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
        equipe.Imagem = form["Imagem"];


        equipeModel.Create(equipe);

        ViewBag.Equipes = equipeModel.ReadAll();
        return LocalRedirect("~/equipe");

        }
    }
}