using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_HW
{
    public interface IAccount
    {
        // баланс учетной записи
         double Balance { get; set; }

        // процентная ставка
         double Interest { get; set; }

        void Execute();
    }
}
