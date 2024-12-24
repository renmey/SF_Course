using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_HW
{
    public class DefaultAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public void Execute()
        {
            this.Interest = this.Balance * 0.4;

            if (this.Balance < 1000)
                this.Interest -= this.Balance * 0.2;

            if (this.Balance <= 1000)
                this.Interest -= this.Balance * 0.4;
        }
    }
}
