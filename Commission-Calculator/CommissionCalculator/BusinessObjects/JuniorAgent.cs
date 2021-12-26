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

    //Inherits Base Class Properties
    public class JuniorAgent : Agent
    {

        //Overriding Calculate Function
        public override double Calculate()
        {
            BonusOrReduction = -0.005;
            double reducedCommissionValue;
            reducedCommissionValue = base.Calculate() + (SalesAmount * BonusOrReduction);

            //Return new Value
            return reducedCommissionValue;
        }
    }
}
