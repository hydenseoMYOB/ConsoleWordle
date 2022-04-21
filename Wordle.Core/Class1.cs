using Microsoft.VisualBasic;
namespace Wordle.Core;

public class WordRepository
{
    public Constants constants = new Constants();
    public WordRepository (){

    }

    public string GetWordle () {
        Random random = new Random();
        int index = random.Next(constants.ListOfPossibleWords.Count);
        return constants.ListOfPossibleWords[index];
    }
}