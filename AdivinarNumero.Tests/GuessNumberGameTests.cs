using AdivinarNumero.Logica;
using System;
using Xunit;

namespace AdivinarNumero.Tests;

public class GuessNumberGameTests
{
    [Theory]
    [InlineData(50, 50, GuessResult.Correcto)]
    [InlineData(50, 46, GuessResult.MuyCaliente)] // diff 4
    [InlineData(50, 55, GuessResult.MuyCaliente)] // diff 5
    [InlineData(50, 44, GuessResult.Caliente)]    // diff 6
    public void Evaluate_BasicRanges(int target, int guess, GuessResult expected)
    {
        var game = new GuessNumberGame(target);
        Assert.Equal(expected, game.Evaluate(guess));
    }

    [Theory]
    [InlineData(50, 35, GuessResult.Caliente)] // diff 15 -> Caliente
    [InlineData(50, 34, GuessResult.Tibio)]   // diff 16 -> Tibio
    [InlineData(50, 20, GuessResult.Tibio)]   // diff 30 -> Tibio
    [InlineData(50, 19, GuessResult.Frio)]    // diff 31 -> Frío
    public void Evaluate_Boundaries(int target, int guess, GuessResult expected)
    {
        var game = new GuessNumberGame(target);
        Assert.Equal(expected, game.Evaluate(guess));
    }

    [Fact]
    public void Constructor_Throws_WhenTargetOutOfRange()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new GuessNumberGame(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new GuessNumberGame(101));
    }

    [Fact]
    public void Evaluate_Throws_WhenGuessOutOfRange()
    {
        var game = new GuessNumberGame(50);
        Assert.Throws<ArgumentOutOfRangeException>(() => game.Evaluate(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => game.Evaluate(101));
    }
}
