using System;
using Microsoft.AspNetCore.Mvc;
using TicTacToe_Game.Controllers;
using TicTacToe_Game.Models;
using Xunit;

namespace TestProject2
{
    public class GameControllerTests
    {
        [Fact]
        public void MakeMove_ValidMove_ReturnsRedirectToActionResult()
        {
            // Arrange
            var controller = new GameController();
            controller.TempData["Board"] = new char[3, 3];
            controller.TempData["CurrentPlayer"] = 'X';

            // Act
            var result = controller.MakeMove(0, 0);

            // Assert
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void MakeMove_InvalidMove_DoesNotAlterGameBoard()
        {
            // Arrange
            var controller = new GameController();
            var gameBoard = new GameBoard
            {
                Board = new char[3, 3],
                CurrentPlayer = 'X'
            };
            controller.TempData["Board"] = gameBoard.Board;
            controller.TempData["CurrentPlayer"] = gameBoard.CurrentPlayer;

            // Act
            var result = controller.MakeMove(0, 0);

            // Assert
            var newGameBoard = (char[,])controller.TempData["Board"];
            Assert.Equal(gameBoard.Board, newGameBoard);
        }
    }
}