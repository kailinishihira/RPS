using Microsoft.AspNetCore.Mvc;
using RPS.Models;
using System.Collections.Generic;
using System;

namespace RPS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/rps/player2")]
        public ActionResult player2()
        {
            string player1 = (Request.Form["player1"]);
            Game.SetPlayer1Choice(player1);
            return View("player2", player1);
        }

        [HttpPost("/rps/results")]
        public ActionResult Results()
        { 
            string player2 = (Request.Form["player2"]);
            string player1 = GetPlayer1Choice();
            Game myGame = new Game (player1, player2);
            myGame.GameWinner();
            return View();
        }
    }
}