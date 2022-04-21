using System.Text.RegularExpressions;
using System;
using Xunit;

using Wordle.Core;
namespace Wordle.UnitTests;

public class UnitTest1
{
    private WordRepository _wordRepository = new WordRepository();

    // [Fact]
    // public void GetWordle_ReturnsAlphabeticalLetters()
    // {
    //     var actual = someclass.GetWordle().ToCharArray();
    //     var pattern = "[A-Z]";
    //     var rgx = new Regex(pattern);
    //     Array.ForEach(actual, char => Assert.True(rgx.IsMatch(char.ToUpper())));
    // }

    [Fact]
    public void GetWorld_ReturnsA5LetterWord(){
        
        var expectedWordLength = 5;
        var actualWordLength = _wordRepository.GetWordle().Length;
        Assert.Equal(expectedWordLength, actualWordLength);
    }
}