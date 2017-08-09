using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPS.Models;
using System;

namespace RPS.Tests 
{
  [TestClass]
  public class RPSTest : IDisposable
  {
    [TestMethod]
    public void GameWinner_Player1RockPlayer2Scissors_Player1Wins()
    {
        Game testGame = new Game("rock", "scissors");
        List<string> expected = new List<string> {"Player 1 Wins"};
        List<string> actual = testGame.GameWinner();
        CollectionAssert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void GameWinner_Player1RockPlayer2Paper_Player2Wins()
    {
        Game testGame = new Game("rock", "paper");
        List<string> expected = new List<string> {"Player 2 Wins"};
        List<string> actual = testGame.GameWinner();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GameWinner_Player1RockPlayer2Rock_NoOneWins()
    {
        Game testGame = new Game("rock", "rock");
        List<string> expected = new List<string> {"No One Wins"};
        List<string> actual = testGame.GameWinner();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GameWinner_Player1ScissorsPlayer2Rock_Player2Wins()
    {
        Game testGame = new Game("scissors", "rock");
        List<string> expected = new List<string> {"Player 2 Wins"};
        List<string> actual = testGame.GameWinner();
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GameWinner_Player1ScissorsPlayer2Scissors_NoOneWins()
    {
        Game testGame = new Game("scissors", "scissors");
        List<string> expected = new List<string> {"No One Wins"};
        List<string> actual = testGame.GameWinner();
        CollectionAssert.AreEqual(expected, actual);
    }


    public void Dispose()
    {
        Game.ClearAll();
    }
  }
}