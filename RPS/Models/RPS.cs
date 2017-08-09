using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    private string _player1;
    private string _player2;
    private static string _player1Choice;
    private static List<string> _winnerList = new List<string> {};

    public Game (string inputPlayer1, string inputPlayer2)
    {
      _player1 = inputPlayer1;
      _player2 = inputPlayer2;
    }

    public static string GetPlayer1Choice()
    {
      return _player1Choice;
    }

    public static void SetPlayer1Choice(string player1Choice)
    {
      _player1Choice = player1Choice;
    }

    // public void SetPlayer1(string newPlayer1)
    // {
    //   _player1 = newPlayer1;
    // }
    // public string GetPlayer2()
    // {
    //   return _player2;
    // }
    // public void SetPlayer2(string newPlayer2) 
    // {
    //   _player2 = newPlayer2;
    // }

    public List<string> GameWinner()
    {
      if ( _player1 == "rock" && _player2 == "scissors")
      {
         _winnerList.Add("Player 1 Wins");
         
      } 
      else if (_player1 == "paper" && _player2 == "rock")
      {
         _winnerList.Add("Player 1 Wins");
      } 
      else if (_player1 == "scissors" && _player2 == "paper")
      {
         _winnerList.Add("Player 1 Wins");
      } 
      else if (_player1 == _player2)
      {
        _winnerList.Add("No One Wins");
      } 
      else 
      {
        _winnerList.Add("Player 2 Wins");
      }
      return _winnerList;
    }

    public static void ClearAll()
    {
      _winnerList.Clear();
    }
  }
}