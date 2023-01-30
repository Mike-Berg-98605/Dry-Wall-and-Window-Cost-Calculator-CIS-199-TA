
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants for WINDOWFEE, TWOWALLS
            const double WINDOWFEE = 100.00;
            const int TWOWALLS = 2;

            //holds initial value for windowFees
            double windowFees = 0;

            //These variables hold the console input values
            double longSideLength;
            double longSideHeight;
            double shortSideLength;
            double shortSideHeight;
            double supplierPlasterboardSize;
            int window1;
            int window2;
            double costPerSqFoot;
            double laborCostPerSQFoot;

            WriteLine("Welcome to the Dry Wall and Window Installation Calculator\n");

            // Prompt user and gather input
            Write("Enter the length of the Long Side(in feet): ");
            longSideLength = double.Parse(ReadLine());

            Write("Enter the height of the Long Side (in feet): ");
            longSideHeight = double.Parse(ReadLine());

            Write("Enter the length of the Short Side(in feet): ");
            shortSideLength = double.Parse(ReadLine());

            Write("Enter the height of the Short Side(in feet): ");
            shortSideHeight = double.Parse(ReadLine());

            Write("Enter the square foot size of the suppliers Plasterboard: ");
            supplierPlasterboardSize = double.Parse(ReadLine());

            Write("Enter 1 if you want a window, Enter 0 if you do not: ");
            window1 = int.Parse(ReadLine());

            Write("Enter 1 if you want a second window, Enter 0 if you do not: ");
            window2 = int.Parse(ReadLine());

            Write("Enter cost of Dry Wall per square foot: ");
            costPerSqFoot = double.Parse(ReadLine());

            Write("Enter cost of labor per square feet: ");
             laborCostPerSQFoot= double.Parse(ReadLine());

            // Perform Calculations
            //if window1 input is 1, add $100 fee
            if (window1 == 1)
            {
                windowFees += WINDOWFEE;
            }

            //if window2 input is 1, add $100 fee
            if (window2 == 1)
            {
                windowFees += WINDOWFEE;
            }

            //calculates total square feet needed by multiplying the long side length and height then multiplying that result by 2,
            //then adds result of short side length times height times 2, then adds celing dry wall square feet by multplying long side
            //length by short side length
            double totalSQFeetNeeded = (longSideLength * longSideHeight * TWOWALLS) + (shortSideLength * shortSideHeight * TWOWALLS)
                + (longSideLength * shortSideLength);

            //determines plasterboards needed
            double plasterboardsNeeded = totalSQFeetNeeded / supplierPlasterboardSize;
            //rounds up plasterboards needed by using Math.Round. first input variable you are rounding,
            //then input point to round from, MidpointRounding.AwayFromZero rounds up away from zero
            double plasterboardRoundUp = Math.Round(plasterboardsNeeded, 0, MidpointRounding.AwayFromZero);

            //calcualates cost of labor
            double totalCostOfLabor = (totalSQFeetNeeded * laborCostPerSQFoot);

            //calculates total cost
            double totalCost = ((totalSQFeetNeeded * costPerSqFoot) + windowFees + totalCostOfLabor);


            // Output results
            WriteLine();
            WriteLine($"Total SQ feet needed: {totalSQFeetNeeded:F2}");
            WriteLine($"Total Plasterboards needed: {plasterboardRoundUp}");
            WriteLine($"Labor Cost: {totalCostOfLabor:C}");
            WriteLine($"Total Cost: {totalCost:C}");

            Console.ReadLine();

        }
    }
}
