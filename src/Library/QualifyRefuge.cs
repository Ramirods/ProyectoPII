using System;

namespace Proyect;

public class QualifyRefuge
{
    private int Rating;
    private int TotalRatings;
    private double AverageRating;

    public void AddRating(int rating)
    {
        if (rating<=5 && rating>=0)
        {
            Rating += rating;
            TotalRatings++;
        }
        else
        {
            Console.WriteLine("Value is not valid, please insert a value between 0-5");
        }
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