/*
 * Author: Oluwatomi
 * Since: 2021/12/03
 * Description: Derived Class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommissionCalculator.BusinessObjects
{
    //Inherits base Class Properties
    public class SeniorAgent : Agent
    {

        //Overriding Base Calculate Method
        public override double Calculate()
        {
            BonusOrReduction = 0.015;
            double bonusPlusCommission;
            bonusPlusCommission = base.Calculate() + (SalesAmount * BonusOrReduction);

            //Return new Value
            return bonusPlusCommission;
        }
    }
}
