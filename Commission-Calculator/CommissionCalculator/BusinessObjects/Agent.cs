/*
 * Author: Oluwatomi
 * Since: 2021/12/03
 * Description: Base Class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommissionCalculator.BusinessObjects
{
    //Base Class for Agent
    public class Agent
    {
        //Attributes for Base Class
        private string fName;
        private string lName;
        private string email;
        private double salesAmount;
        private double commRate;
        private double bonusOrReduction = 0;

        //Getters and Setters
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Email { get => email; set => email = value; }
        public double SalesAmount { get => salesAmount; set => salesAmount = value; }
        public double CommRate { get => commRate; set => commRate = value; }
        public double BonusOrReduction { get => bonusOrReduction; set => bonusOrReduction = value; }


        //Base Method to Calculate PAy
        public virtual double Calculate()
        {

            double commEarned;

            //Conditions for Commission Rate
            if (SalesAmount < 1000)
            {
                CommRate = 0.02;
            }
            else if (SalesAmount >= 1000 && SalesAmount <= 5000)
            {
                CommRate = 0.04;
            }
            else if (SalesAmount > 5000)
            {
                CommRate = 0.06;
            }

            commEarned = SalesAmount * commRate;

            return commEarned;

        }
    }
}
