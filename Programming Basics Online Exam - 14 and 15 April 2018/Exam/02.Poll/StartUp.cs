using System;
public class StartUp
{
    public static void Main()
    {
        int numberOfParticipantInPoll = int.Parse(Console.ReadLine());
        int numberVoteLanguageFirst = int.Parse(Console.ReadLine());

        double numberVoteSecondPlace = (numberVoteLanguageFirst - (numberVoteLanguageFirst * 0.2));
        double numberVoteThirdPlace = (numberVoteSecondPlace - (numberVoteSecondPlace * 0.1));

        int middleVote = numberOfParticipantInPoll / 2;

        double firstPlace = (Math.Floor(numberVoteLanguageFirst + numberVoteSecondPlace + 
            numberVoteThirdPlace) - middleVote);
        
        if (firstPlace >= 0)
        {
            Console.WriteLine("First three languages have {0} votes more ", firstPlace);
        }
        else
        {
            Console.WriteLine("First three languages have {0} votes less of half votes", 
                Math.Abs(firstPlace));
        }
    }
}

