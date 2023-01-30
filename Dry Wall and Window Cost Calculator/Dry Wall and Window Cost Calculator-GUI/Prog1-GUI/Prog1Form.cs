// This Windows Form application calculates the cost of installing dry wall and windows for a room in a house.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1_GUI
{
    public partial class Prog1Form : Form
    {
        public Prog1Form()
        {
            InitializeComponent();
        }

        private void calcEstimateBtn_Click(object sender, EventArgs e)
        {
            //constants for WINDOWFEE, TWOWALLS
            const double WINDOWFEE = 100.00;           
            const int TWOWALLS = 2;
            
            //holds initial value for windowFees
            double windowFees = 0;

            //These variables hold the GUI input values
            double longSideLength = double.Parse(longLengthTxt.Text);
            double longSideHeight = double.Parse(longHeightTxt.Text);
            double shortSideLength = double.Parse(shortSideLengthTxt.Text);
            double shortSideHeight = double.Parse(shortSideHeightTxt.Text);
            double supplierPlasterboardSize = double.Parse(sqFootSupplierTxt.Text);
            int window1 = int.Parse(firstWindowTxt.Text);
            int window2 = int.Parse(secondWindowTxt.Text);
            double costPerSqFoot = double.Parse(costSQFootTXT.Text);
            double laborCostPerSQFoot = double.Parse(laborCostSQFootTxt.Text);

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

            //outputs results of calculations
            TotalSQFeetNeededOutputLbl.Text = $"{totalSQFeetNeeded:F2}";
            plasterboardsNeededOutputLbl.Text = $"{plasterboardRoundUp}";
            laborCostOutputLabel.Text = $"{totalCostOfLabor:C2}";
            totalCostOutputLbl.Text = $"{totalCost:C2}";
        }

    }
}
