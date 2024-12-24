using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_HW
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get ; set; }
        public double Interest { get; set ; }

        public void Execute()
        {
            this.Interest = this.Balance * 0.5;
        }

    }
}
