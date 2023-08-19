using System;
using Microsoft.AspNetCore.Mvc;
using TicTacToe_Game.Controllers;
using TicTacToe_Game.Models;
using Xunit;

namespace TestProject2
{
    public class GameControllerTests
    {
        public class GameTests
        {
            [Fact]
            public void Game_Starts_With_CurrentPlayer_X()
            {
                var game = new Game();

                Assert.Equal("X", game.CurrentPlayer);
            }

            [Fact]
            public void Game_CheckWin_Returns_True_If_X_Wins()
            {
                var game = new Game();

                game.MakeMove(0); // X
                game.MakeMove(3); // O
                game.MakeMove(1); // X
                game.MakeMove(4); // O
                game.MakeMove(2); // X

                Assert.Equal("X", game.Winner);
            }

            [Fact]
            public void Game_CheckWin_Returns_True_If_O_Wins()
            {
                var game = new Game();

                game.MakeMove(0); // X
                game.MakeMove(3); // O
                game.MakeMove(1); // X
                game.MakeMove(4); // O
                game.MakeMove(6); // X
                game.MakeMove(5); // O

                Assert.Equal("O", game.Winner);
            }

           


            [Fact]
            public void Game_Updates_Score_Correctly_For_X()
            {
                var game = new Game();

                game.MakeMove(0); // X
                game.MakeMove(3); // O
                game.MakeMove(1); // X
                game.MakeMove(4); // O
                game.MakeMove(2); // X

                Assert.Equal(1, game.ScoreX);
            }

            [Fact]
            public void Game_Updates_Score_Correctly_For_O()
            {
                var game = new Game();

                game.MakeMove(0); // X
                game.MakeMove(3); // O
                game.MakeMove(1); // X
                game.MakeMove(4); // O
                game.MakeMove(6); // X
                game.MakeMove(5); // O

                Assert.Equal(1, game.ScoreO);
            }
        }
    }
}