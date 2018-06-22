using CodingChallenge;
using System;
using Xunit;

namespace CodingChallengeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "X", "X", "O" },
                { "X", "O", "O" },
                { "X", "O", "" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("X", winner);
        }

        [Fact]
        public void Test2()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "O", "O", "O" },
                { "X", "X", "O" },
                { "X", "O", "X" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("O", winner);
        }

        [Fact]
        public void Test3()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "O", "O", "X" },
                { "X", "X", "O" },
                { "O", "O", "X" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("-", winner);
        }

        [Fact]
        public void Test4()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "O", "O", "X" },
                { "X", "X", "O" },
                { "X", "O", "X" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("X", winner);
        }

        [Fact]
        public void Test5()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "O", "X", "X" },
                { "X", "O", "O" },
                { "X", "O", "O" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("O", winner);
        }

        [Fact]
        public void Test6()
        {
            var ticTacToe = new TicTacToe();
            var board = new string[,]
            {
                { "O", "X", "O" },
                { "X", "O", "O" },
                { "X", "O", "X" }
            };
            var winner = ticTacToe.ProcessWinner(board);
            Assert.Equal("-", winner);
        }
    }
}
