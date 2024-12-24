using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRealExample.Observers
{
    public interface IObserver
    {
        void Update(Object o);
    }
}
