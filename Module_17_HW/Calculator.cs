using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_HW
{
    public static class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.Execute();
        }
    }
}
