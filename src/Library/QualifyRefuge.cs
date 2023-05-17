using System;

namespace proyect;

public class QualifyRefuge
{
    private int Rating;
    private int TotalRatings;
    private double AverageRating;

    public void AddRating(int rating)
    {
        Rating += rating;
        TotalRatings++;
    }

    public double GenerateAverage()
    {
        if (TotalRatings == 0)
        {
            Console.WriteLine("No ratings available.");
            return 0;
        }

        AverageRating = (double)Rating / TotalRatings;
        return AverageRating;
    }
}