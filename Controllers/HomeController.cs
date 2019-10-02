using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        //Usei isso para evitar que o random gere os mesmos numeros
        private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

        public ActionResult Index()
        {
            //Fiz o mais simples possivel

            Torneio torneio = new Torneio();
            torneio.T1score = GenerateScore(0);
            torneio.T2score = GenerateScore(0);

            if (torneio.T1score > torneio.T2score)
                torneio.WinnerK1 = torneio.T1;
            else
                torneio.WinnerK1 = torneio.T2;

            torneio.T3score = GenerateScore(0);
            torneio.T4score = GenerateScore(0);

            if (torneio.T3score > torneio.T4score)
                torneio.WinnerK2 = torneio.T3;
            else
                torneio.WinnerK1 = torneio.T4;

            torneio.WinnerK1score = GenerateScore(0);
            torneio.WinnerK2score = GenerateScore(0);

            if (torneio.WinnerK1score > torneio.WinnerK2score)
                torneio.WinnerFinal = torneio.WinnerK1;
            else
                torneio.WinnerFinal = torneio.WinnerK2;

            return View(torneio); 
        }

        
        private int GenerateScore(int r)
        {
            r = random.Value.Next(0, 9);
            return r;
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}